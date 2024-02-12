using SwanSong.Domain.Dto.Response;
using System;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto.Request;

public record AlbumAddRequest(string Name, long? ArtistId, DateTime? ReleaseDate, DateTime? RecordedDate, 
                              int? LabelId, int? StudioId, string Producers, string Arrangers, string Engineers, 
                              string Artwork, string Photo, List<AlbumSongResponse> Songs);

public record AlbumSongAddRequest(long AlbumId, int? Order, int? Side, AlbumSongSongAddRequest Song);

public record AlbumSongSongAddRequest(string Title, string Length);

public record AlbumSongSongUpdateRequest(long Id, string Title, string Length);

public record AlbumSongUpdateRequest(long Id, long AlbumId, int? Order, int? Side, AlbumSongSongAddRequest Song);

public record AlbumUpdateRequest(long Id, string Name, long? ArtistId, DateTime? ReleaseDate, 
                                 DateTime? RecordedDate, int? LabelId, int? StudioId, string Producers, 
                                 string Arrangers, string Engineers, string Artwork, string Photo, List<AlbumSongResponse> Songs);

public record ArtistAddRequest(string Name, string Photo, int? FormationYear, int? DisbandYear, 
                               int? CountryId, List<Member> Members, List<Album> Albums);

public record ArtistUpdateRequest(long Id, string Name, string Photo, int? FormationYear, 
                                  int? DisbandYear, int? CountryId, List<Member> Members, List<Album> Albums);

public record BirthPlaceAddRequest(string Name, int CountryId);

public record BirthPlaceUpdateRequest(int Id, string Name, int CountryId);

public record CountryAddRequest(string Name);

public record CountryUpdateRequest(int Id, string Name);

public record JwtRefreshTokenRequest(string RefreshToken);

public record LoginRequest(string Email, string Password, bool IsAuthenticated, 
                           string JwtToken, string RefreshToken);

public record MemberAddRequest(long ArtistId, string StageName, string FirstName, string MiddleName, 
                               string Surname, string Photo, DateTime? DateOfBirth, DateTime? DateOfDeath, 
                               int? BirthPlaceId);

public record MemberUpdateRequest(long Id, long ArtistId, string StageName, string FirstName, 
                                  string MiddleName, string Surname, string Photo, DateTime? DateOfBirth, 
                                  DateTime? DateOfDeath, int? BirthPlaceId);

public record ProfilePasswordChangeRequest(int Id, string Password, string ConfirmPassword, 
                                           string CurrentPassword, string Email);

public record ProfileRequest(string FirstName, string LastName, string Email);

public record RecordLabelAddRequest(string Name);

public record RecordLabelUpdateRequest(int Id, string Name);

public record RegisterRequest(string FirstName, string LastName, string Email, 
                              string Password, string ConfirmPassword);

public record RegisterVerifyEmailRequest(string Token);

public record ResetPasswordRequest(string Token, string Password, string ConfirmPassword);

public record StudioAddRequest(string Name);

public record StudioUpdateRequest(int Id, string Name);