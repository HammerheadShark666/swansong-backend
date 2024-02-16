using AutoMapper;
using SwanSong.Data.Helper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Exceptions;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class RefreshTokenService : IRefreshTokenService
{
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<LoginRequest> _validatorHelper;

    public RefreshTokenService(IMapper mapper,
                               IValidatorHelper<LoginRequest> validatorHelper,
                               IUnitOfWork unitOfWork)
    {
        _validatorHelper = validatorHelper;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public void RemoveExpiredRefreshTokens(int accountId)
    {
        _unitOfWork.RefreshTokens.RemoveExpired(EnvironmentVariablesHelper.JwtSettingsRefreshTokenTtl, accountId);
        DataHelper.CompleteContextAction(null, null, _unitOfWork);
    }

    public async Task AddRefreshToken(RefreshToken refreshToken)
    {
        await _unitOfWork.RefreshTokens.AddAsync(refreshToken);
        await DataHelper.CompleteContextActionAsync(null, null, _unitOfWork);
    }

    public RefreshToken GenerateRefreshToken(string ipAddress, Account account)
    {
        var refreshTokenExpires = DateTime.Now.AddDays(EnvironmentVariablesHelper.JwtSettingsRefreshTokenExpiryDays);
        var refreshToken = AuthenticationHelper.GenerateRefreshToken(ipAddress, refreshTokenExpires);
        refreshToken.Account = account;

        return refreshToken;
    }

    public async Task<RefreshToken> GetRefreshTokenAsync(string token)
    {
        var refreshToken = await _unitOfWork.RefreshTokens.ByTokenAsync(token);
        if (refreshToken == null || !refreshToken.IsActive)
        {
            throw new AppException(ConstantMessages.InvalidToken);
        }

        return refreshToken;
    }
}