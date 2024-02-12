using System;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto.Response;

public record AlbumLookUpResponse(long Id, string Name, DateTime? ReleaseDate, string ArtistName, 
                                  string Photo, string Length, string Tracks); 

public record AlbumResponse(long Id, string Name, long? ArtistId, string ArtistName, 
                            DateTime? ReleaseDate, DateTime? RecordedDate, int? LabelId, int? StudioId, 
                            string Producers, string Arrangers, string Engineers, string Artwork, 
                            string Photo, List<AlbumSongResponse> Songs);

public record AlbumActionResponse(long Id, List<Message> Messages, bool IsValid); 

public record AlbumPhotoActionResponse(string filename, bool IsValid);

public record AlbumSongResponse(long Id, long AlbumId, long SongId, SongResponse Song, int? Order, int? Side); 

public record AlbumSongActionResponse(long Id, long SongId, List<Message> Messages, bool IsValid);

public record ArtistLookUpResponse(long Id, string Name);

public record ArtistResponse(long Id, string Name, string Photo, int? FormationYear, 
                             int? DisbandYear, int? CountryId, List<Member> Members, List<Album> Albums);

public record ArtistActionResponse(long Id, List<Message> Messages, bool IsValid);

public record ArtistPhotoActionResponse(string filename, bool IsValid);

public record BirthPlaceResponse(int Id, string Name, int? CountryId);

public record BirthPlaceActionResponse(long Id, string Name, List<Message> Messages, bool IsValid);

public record CountryResponse(int Id, string Name);

public record CountryActionResponse(long Id, string name, List<Message> Messages, bool IsValid);
 
public record LoginActionResponse(bool IsAuthenticated, string JwtToken, string RefreshToken, List<Message> Messages, bool IsValid);

public record JwtRefreshTokenActionResponse(bool IsAuthenticated, string JwtToken, string RefreshToken, 
                                            string Role, List<Message> Messages, bool IsValid);
public record MemberResponse(long Id, long ArtistId, string StageName, 
                             string FirstName, string MiddleName, string Surname, 
                             string Photo, DateTime? DateOfBirth, DateTime? DateOfDeath);

public record MemberActionResponse(long Id, List<Message> Messages, bool IsValid);

public record MemberPhotoActionResponse(string filename, bool IsValid);

public record MessageResponse(List<Message> Messages, string Severity);

public record ProfilePasswordChangeActionResponse(List<Message> Messages, bool IsValid);

public record ProfileResponse(string FirstName, string LastName, string Email);

public record ProfileActionResponse(string FirstName, string LastName, string Email, List<Message> Messages, bool IsValid); 

public record RecordLabelResponse(int Id, string Name);

public record RecordLabelActionResponse(long Id, string name, List<Message> Messages, bool IsValid);
 
public record RegisterActionResponse(string FirstName, string LastName, string Email, List<Message> Messages, bool IsValid);

public record RegisterVerifyEmailActionResponse(List<Message> Messages, bool IsValid);

public record ResetPasswordActionResponse(List<Message> Messages, bool IsValid);
 
public record SongResponse(long Id, string Title, string Length);

public record SongActionResponse(long Id, List<Message> Messages, bool IsValid);

public record StudioResponse(int Id, string Name);

public record StudioActionResponse(long Id, string name, List<Message> Messages, bool IsValid);