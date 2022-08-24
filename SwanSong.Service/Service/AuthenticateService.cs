using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using SwanSong.Azure.Storage.Interfaces;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Exceptions;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Domain.Model.Settings;
using SwanSong.Helper;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BC = BCrypt.Net.BCrypt;

namespace SwanSong.Service
{
    public class AuthenticateService : BaseService<Login, LoginDto>, IAuthenticateService
    {
        private readonly JwtSettings _jwtSettings; 

        public AuthenticateService(IMapper mapper,
                            IValidator<Login> validator,
                            IMemoryCache memoryCache,
                            IUnitOfWork unitOfWork,
                            IOptions<JwtSettings> jwtSettings,
                            IAzureStorageBlobHelper azureStorageHelper) : base(validator, memoryCache, unitOfWork, mapper, azureStorageHelper)
        {
            _jwtSettings = jwtSettings.Value; 
        }

        public async Task<LoginDto> AuthenticateAsync(LoginDto loginDto, string ipAddress)
        {
            var login = _mapper.Map<Login>(loginDto);

            ValidationResult result = await BeforeSaveAsync(login);
            if (!result.IsValid)
                return GetDto(login, result.Errors, false);
             
            var account = await _unitOfWork.Accounts.GetAsync(loginDto.Email);
            var refreshToken = GenerateRefreshToken(account, ipAddress);
            account = await UpdateRefreshTokenAsync(account, ipAddress, refreshToken);             
            var jwtToken = AuthenticationHelper.GenerateJwtToken(account, _jwtSettings.TokenExpiryMinutes, _jwtSettings.Secret);

            return GetLoginDto(account, await AfterSaveAsync(login, null), true, jwtToken, refreshToken.Token);
        } 

        private async Task<Account> UpdateRefreshTokenAsync(Account account, string ipAddress, RefreshToken refreshToken)
        {          
            RemoveOldRefreshTokens(account);
            account.RefreshTokens.Add(refreshToken);
            _unitOfWork.Accounts.Update(account);
            await _unitOfWork.Complete();

            return account;
        }

        public async Task<JwtRefreshTokenDto> RefreshTokenAsync(string token, string ipAddress)
        {
            var (RefreshToken, account) = await GetRefreshTokenAsync(token);
            var newRefreshToken = GetNewRefreshToken(ipAddress);

            RemoveOldRefreshTokens(account);
            account.RefreshTokens.Add(newRefreshToken);

            _unitOfWork.Accounts.Update(account);
            await _unitOfWork.Complete();

            var jwtToken = AuthenticationHelper.GenerateJwtToken(account, _jwtSettings.TokenExpiryMinutes, _jwtSettings.Secret);

            return CreateJwtRefreshTokenDto(account, jwtToken, newRefreshToken.Token);
        }

        private void RemoveOldRefreshTokens(Account account)
        {
            account.RefreshTokens.RemoveAll(x =>
                                    !x.IsActive &&
                                    x.Created.AddDays(_jwtSettings.RefreshTokenTTL) <= DateTime.Now);
        }

        private RefreshToken GenerateRefreshToken(Account account, string ipAddress)
        {
            var refreshTokenExpires = DateTime.Now.AddDays(_jwtSettings.RefreshTokenExpiryDays);
            return AuthenticationHelper.GenerateRefreshToken(ipAddress, refreshTokenExpires);
        } 

        private RefreshToken GetNewRefreshToken(string ipAddress)
        {
            var refreshTokenExpires = DateTime.Now.AddDays(_jwtSettings.RefreshTokenExpiryDays);
            return AuthenticationHelper.GenerateRefreshToken(ipAddress, refreshTokenExpires);
        }

        private async Task<(RefreshToken, Account)> GetRefreshTokenAsync(string token)
        {
            var account = await _unitOfWork.Accounts.GetByRefreshTokenAsync(token);
            if (account == null) throw new AppException(ConstantMessages.InvalidToken);
            var refreshToken = account.RefreshTokens.Single(x => x.Token == token);
            if (!refreshToken.IsActive) throw new AppException(ConstantMessages.InvalidToken);
            return (refreshToken, account);
        }

        public JwtRefreshTokenDto CreateJwtRefreshTokenDto(Account account, string jwtToken, string token)
        {
            var response = _mapper.Map<JwtRefreshTokenDto>(account);
            response.JwtToken = jwtToken;
            response.RefreshToken = token;
            return response;
        } 

        private LoginDto GetLoginDto(Account account, List<ValidationFailure> rules, bool isValid, string jwtToken, string refreshToken)
        {
            LoginDto loginDto = _mapper.Map<LoginDto>(account);
            loginDto.Rules = rules;
            loginDto.IsValid = isValid; 
            loginDto.JwtToken = jwtToken;
            loginDto.RefreshToken = refreshToken;  
            return loginDto;
        }
    }
}
