using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record AlbumSongAddRequest(long AlbumId, int? Order, int? Side, AlbumSongSongAddRequest Song);

public record AlbumSongSongAddRequest(string Title, string Length);

public record AlbumSongSongUpdateRequest(long Id, string Title, string Length);

public record AlbumSongUpdateRequest(long Id, long AlbumId, int? Order, int? Side, AlbumSongSongAddRequest Song);

public record AlbumSongResponse(long Id, long AlbumId, long SongId, SongResponse Song, int? Order, int? Side);

public record AlbumSongActionResponse(long Id, long SongId, List<Message> Messages, bool IsValid);