using System.Collections.Generic;

namespace SwanSong.Domain.Dto;
 
public record ResetPasswordRequest(string Token, string Password, string ConfirmPassword);

public record ResetPasswordActionResponse(List<Message> Messages, bool IsValid);