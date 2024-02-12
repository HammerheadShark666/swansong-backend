using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using SwanSong.Data;
using SwanSong.Helper;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwanSong.Api.Middleware;

public class JwtMiddleware
{
    private readonly RequestDelegate _next; 
    
    public JwtMiddleware(RequestDelegate next)
    {
        _next = next;     
    }

    public async Task Invoke(HttpContext context, SwanSongContext swanSongContext)
    {
        var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

        if (token != null)
        {
            await AttachAccountToContext(context, swanSongContext, token);
        }            

        await _next(context);
    }

    private async Task AttachAccountToContext(HttpContext context, SwanSongContext swanSongContext, string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(EnvironmentVariablesHelper.JwtSettingsSercret);
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var accountId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

            // attach account to context on successful jwt validation
            context.Items[ConstantMessages.Account] = await swanSongContext.Accounts.FindAsync(accountId);
        }
        catch 
        {
            // do nothing if jwt validation fails
            // account is not attached to context so request won't have access to secure routes
        }
    }
}