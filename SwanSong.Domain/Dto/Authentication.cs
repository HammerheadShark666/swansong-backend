using System.Collections.Generic;

namespace SwanSong.Domain.Dto;
 
public record ValidateResetTokenRequest(string Token);

public record LoginActionResponse(bool IsAuthenticated, string JwtToken, string RefreshToken, List<Message> Messages, bool IsValid);

public record LoginRequest(string Email, string Password, bool IsAuthenticated,
                           string JwtToken, string RefreshToken);

public record JwtRefreshTokenRequest(string RefreshToken);

public record JwtRefreshTokenActionResponse(bool IsAuthenticated, string JwtToken, string RefreshToken,
                                            string Role, List<Message> Messages, bool IsValid);