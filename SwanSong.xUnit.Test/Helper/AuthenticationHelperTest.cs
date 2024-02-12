using SwanSong.Domain;
using SwanSong.Helpers.Authentication;
using System;
using Xunit;

namespace SwanSong.xUnit.Test.Helper;

public class AuthenticationHelperTest
{
    [Fact]
    public void Create_jwt_token_valid_return_jwt_token()
    {
        int expiryHours = 7;
        string secret = "test-secret-for-testing-jwt-token-generation";
        Account account = new()
        {
            Id = 1,
            Email = "test@test.com"
        };

        string actualJwtToken = AuthenticationHelper.GenerateJwtToken(account, expiryHours, secret);
        string expectedJwtToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEiLCJlbWFpbCI6InRlc3RAdGVzdC5jb20iLCJqdGkiOi";
        Assert.StartsWith(expectedJwtToken, actualJwtToken);
    }

    [Fact]
    public void Create_random_token_valid_return_token()
    {
        string actualToken = AuthenticationHelper.CreateRandomToken();
        Assert.True(actualToken.Length > 25);
    }

    [Fact]
    public void Generate_refresh_token_valid_is_active_return_token()
    {
        string ipAddress = "0.0.0.1";
        var refreshTokenExpires = DateTime.Now.AddSeconds(60);
        RefreshToken actualRefreshToken = AuthenticationHelper.GenerateRefreshToken(ipAddress, refreshTokenExpires);

        Assert.Equal(actualRefreshToken.CreatedByIp, ipAddress);
        Assert.True(actualRefreshToken.IsActive);
        Assert.False(actualRefreshToken.IsExpired);
        Assert.True(actualRefreshToken.Token.Length > 25);
    }

    [Fact]
    public void Generate_refresh_token_valid_has_expired_return_token()
    {
        string ipAddress = "0.0.0.1";
        var refreshTokenExpires = DateTime.Now.AddSeconds(-60);
        RefreshToken actualRefreshToken = AuthenticationHelper.GenerateRefreshToken(ipAddress, refreshTokenExpires);

        Assert.Equal(actualRefreshToken.CreatedByIp, ipAddress);
        Assert.False(actualRefreshToken.IsActive);
        Assert.True(actualRefreshToken.IsExpired);
        Assert.True(actualRefreshToken.Token.Length > 25);
    }
}
