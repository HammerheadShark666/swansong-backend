using System.Collections.Generic;

namespace SwanSong.Domain.Dto;


public record SongResponse(long Id, string Title, string Length);

public record SongActionResponse(long Id, List<Message> Messages, bool IsValid);

