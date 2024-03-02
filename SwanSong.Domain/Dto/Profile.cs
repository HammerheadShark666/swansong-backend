using System.Collections.Generic;

namespace SwanSong.Domain.Dto;
 
public record ProfilePasswordChangeRequest(int Id, string Password, string ConfirmPassword,
                                           string CurrentPassword, string Email);

public record ProfileRequest(int Id, string FirstName, string LastName, string Email);

public record ProfilePasswordChangeActionResponse(List<Message> Messages, bool IsValid);

public record ProfileResponse(string FirstName, string LastName, string Email);

public record ProfileActionResponse(string FirstName, string LastName, string Email, List<Message> Messages, bool IsValid);