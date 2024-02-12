using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Domain.Exceptions;
using SwanSong.Domain.Helper;
using SwanSong.Domain.Model.Authentication;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class AuthenticateService : IAuthenticateService
{ 
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<Login> _validatorHelper;

    public AuthenticateService(IMapper mapper,
                               IValidatorHelper<Login> validatorHelper, 
                               IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper; 
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    #region Public Functions

    public async Task<LoginActionResponse> AuthenticateAsync(LoginRequest loginRequest, string ipAddress)
    {
        var login = _mapper.Map<Login>(loginRequest);

        await _validatorHelper.ValidateAsync(login, Constants.ValidationEventBeforeSave);
                
        var account = await _unitOfWork.Accounts.GetAsync(loginRequest.Email);
        var refreshToken = GenerateRefreshToken(ipAddress);
        account = await UpdateRefreshTokenAsync(account, ipAddress, refreshToken);
        var jwtToken = AuthenticationHelper.GenerateJwtToken(account, EnvironmentVariablesHelper.JwtSettingsTokenExpiryMinutes, EnvironmentVariablesHelper.JwtSettingsSercret);

        return GetLoginActionResponse(account, await _validatorHelper.AfterEventAsync(login, Constants.ValidationEventAfterSave), true, jwtToken, refreshToken.Token);
    }

    public async Task<JwtRefreshTokenActionResponse> RefreshTokenAsync(string token, string ipAddress)
    {
        var (RefreshToken, account) = await GetRefreshTokenAsync(token);
        var newRefreshToken = GenerateRefreshToken(ipAddress);

        RemoveOldRefreshTokens(account);

        account = await UpdateAccountRefreshTokenAsync(account, newRefreshToken);

        var jwtToken = AuthenticationHelper.GenerateJwtToken(account, EnvironmentVariablesHelper.JwtSettingsTokenExpiryMinutes, EnvironmentVariablesHelper.JwtSettingsSercret);

        return CreateJwtRefreshTokenResponse(account, jwtToken, newRefreshToken.Token);
    }

    #endregion

    #region Private Functions

    private async Task<Account> UpdateRefreshTokenAsync(Account account, string ipAddress, RefreshToken refreshToken)
    {          
        RemoveOldRefreshTokens(account);
        account.RefreshTokens.Add(refreshToken);
        _unitOfWork.Accounts.Update(account);
        await _unitOfWork.Complete();

        return account;
    }

    
    private async Task<Account> UpdateAccountRefreshTokenAsync(Account account, RefreshToken refreshToken)
    {
        account.RefreshTokens.Add(refreshToken);

        _unitOfWork.Accounts.Update(account);
        await _unitOfWork.Complete();

        return account;
    }

    private void RemoveOldRefreshTokens(Account account)
    {
        account.RefreshTokens.RemoveAll(x =>
                                !x.IsActive &&
                                x.Created.AddDays(EnvironmentVariablesHelper.JwtSettingsRefreshTokenTtl) <= DateTime.Now);
    }

    private RefreshToken GenerateRefreshToken(string ipAddress)
    {  
        var refreshTokenExpires = DateTime.Now.AddDays(EnvironmentVariablesHelper.JwtSettingsRefreshTokenExpiryDays);
        return AuthenticationHelper.GenerateRefreshToken(ipAddress, refreshTokenExpires);
    } 

    private async Task<(RefreshToken, Account)> GetRefreshTokenAsync(string token)
    {
        var account = await _unitOfWork.Accounts.GetByRefreshTokenAsync(token);
        if (account == null)
        {
            throw new AppException(ConstantMessages.InvalidToken);
        }

        var refreshToken = account.RefreshTokens.Single(x => x.Token == token);
        if (!refreshToken.IsActive)
        {
            throw new AppException(ConstantMessages.InvalidToken);
        }

        return (refreshToken, account);
    }

    private JwtRefreshTokenActionResponse CreateJwtRefreshTokenResponse(Account account, string jwtToken, string token)
    {
        var response = _mapper.Map<JwtRefreshTokenActionResponse>(account);
        response = response with { JwtToken = jwtToken, RefreshToken = token };
        return response; 
    } 

    private LoginActionResponse GetLoginActionResponse(Account account, FluentValidation.Results.ValidationResult validationResult, bool isValid, string jwtToken, string refreshToken)
    { 
        return new LoginActionResponse(isValid, jwtToken, refreshToken, ResponseHelper.GetMessages(validationResult.Errors), true);
    }

    #endregion
}