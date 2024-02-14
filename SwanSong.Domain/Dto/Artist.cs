using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record ArtistAddRequest(string Name, string Photo, int? FormationYear, int? DisbandYear,
                               int? CountryId); //, List<Member> Members, List<Album> Albums);

public record ArtistUpdateRequest(long Id, string Name, string Photo, int? FormationYear,
                                  int? DisbandYear, int? CountryId); //, List<Member> Members, List<Album> Albums);

public record ArtistLookUpResponse(long Id, string Name, string Photo);

public record ArtistResponse(long Id, string Name, string Photo, int? FormationYear,
                             int? DisbandYear, int? CountryId, List<MemberResponse> Members, List<AlbumResponse> Albums);

public record ArtistActionResponse(long Id, List<Message> Messages, bool IsValid);

public record ArtistPhotoActionResponse(string filename, bool IsValid);