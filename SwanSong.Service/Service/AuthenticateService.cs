using AutoMapper;
using SwanSong.Data.UnitOfWork.Interfaces;
using SwanSong.Domain;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Exceptions;
using SwanSong.Domain.Helper;
using SwanSong.Helper;
using SwanSong.Helper.Interfaces;
using SwanSong.Helpers.Authentication;
using SwanSong.Service.Interfaces;
using System.Threading.Tasks;

namespace SwanSong.Service;

public class AuthenticateService : IAuthenticateService
{
    public readonly IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    public readonly IValidatorHelper<LoginRequest> _validatorHelper;
    public readonly IRefreshTokenService _refreshTokenService;

    public AuthenticateService(IMapper mapper,
                               IValidatorHelper<LoginRequest> validatorHelper,
                               IUnitOfWork unitOfWork,
                               IRefreshTokenService refreshTokenService)
    {
        _validatorHelper = validatorHelper;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _refreshTokenService = refreshTokenService;
    }

    #region Public Functions

    public async Task<LoginActionResponse> AuthenticateAsync(LoginRequest loginRequest, string ipAddress)
    {
        var login = _mapper.Map<LoginRequest>(loginRequest);

        await _validatorHelper.ValidateAsync(login, Constants.ValidationEventBeforeSave);

        var account = await GetAccountAsync(loginRequest.Email);
        var refreshToken = _refreshTokenService.GenerateRefreshToken(ipAddress, account);

        _refreshTokenService.RemoveExpiredRefreshTokens(account.Id); 
        await _refreshTokenService.AddRefreshToken(refreshToken);

        var jwtToken = AuthenticationHelper.GenerateJwtToken(account,
                                                             EnvironmentVariablesHelper.JwtSettingsTokenExpiryMinutes,
                                                             EnvironmentVariablesHelper.JwtSettingsSercret);

        var validationResult = await _validatorHelper.AfterEventAsync(login, Constants.ValidationEventAfterSave);

        return new LoginActionResponse(true, jwtToken, refreshToken.Token, 
                                       new ProfileResponse(account.FirstName, account.LastName, account.Email), 
                                       ResponseHelper.GetMessages(validationResult.Errors), true); 
    }

    public async Task<JwtRefreshTokenActionResponse> RefreshTokenAsync(string token, string ipAddress)
    {
        var refreshToken = await _refreshTokenService.GetRefreshTokenAsync(token);
        var newRefreshToken = _refreshTokenService.GenerateRefreshToken(ipAddress, refreshToken.Account);

        _refreshTokenService.RemoveExpiredRefreshTokens(refreshToken.Account.Id);
        await _refreshTokenService.AddRefreshToken(newRefreshToken);

        var jwtToken = AuthenticationHelper.GenerateJwtToken(refreshToken.Account, EnvironmentVariablesHelper.JwtSettingsTokenExpiryMinutes, EnvironmentVariablesHelper.JwtSettingsSercret);

        return new JwtRefreshTokenActionResponse(refreshToken.Account.IsAuthenticated, jwtToken, token, 
                                                 new ProfileResponse(refreshToken.Account.FirstName, refreshToken.Account.LastName, refreshToken.Account.Email), 
                                                 refreshToken.Account.Role.ToString(), new System.Collections.Generic.List<Domain.Dto.Message>(), true);

    }

    #endregion

    #region Private Functions
  
    private async Task<Account> GetAccountAsync(string email)
    {
        var account = await _unitOfWork.Accounts.GetAsync(email);
        if (account == null)
        {
            throw new AppException(ConstantMessages.InvalidToken);
        }

        return account;
    }     

    #endregion
}