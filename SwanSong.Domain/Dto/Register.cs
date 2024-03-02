using System.Collections.Generic;

namespace SwanSong.Domain.Dto; 

public record RegisterRequest(string FirstName, string LastName, string Email,
                              string Password, string ConfirmPassword);

public record RegisterVerifyEmailRequest(string Token);

public record RegisterActionResponse(string FirstName, string LastName, string Email, List<Message> Messages, bool IsValid);

public record RegisterVerifyEmailActionResponse(List<Message> Messages, bool IsValid);