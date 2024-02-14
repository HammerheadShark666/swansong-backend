using System;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record AlbumAddRequest(string Name, long? ArtistId, DateTime? ReleaseDate, DateTime? RecordedDate,
                              int? LabelId, int? StudioId, string Producers, string Arrangers, string Engineers,
                              string Artwork, string Photo, List<AlbumSongResponse> Songs);

public record AlbumUpdateRequest(long Id, string Name, long? ArtistId, DateTime? ReleaseDate,
                                 DateTime? RecordedDate, int? LabelId, int? StudioId, string Producers,
                                 string Arrangers, string Engineers, string Artwork, string Photo, List<AlbumSongResponse> Songs);

public record AlbumLookUpResponse(long Id, string Name, DateTime? ReleaseDate, string ArtistName,
                                  string Photo, string Length, string Tracks);

public record AlbumResponse(long Id, string Name, long? ArtistId, string ArtistName,
                            DateTime? ReleaseDate, DateTime? RecordedDate, int? LabelId, int? StudioId,
                            string Producers, string Arrangers, string Engineers, string Artwork,
                            string Photo, List<AlbumSongResponse> Songs);

public record AlbumActionResponse(long Id, List<Message> Messages, bool IsValid);

public record AlbumPhotoActionResponse(string filename, bool IsValid);