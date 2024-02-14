using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record MessageResponse(List<Message> Messages, string Severity);

public record Message(string Text, string Severity); 