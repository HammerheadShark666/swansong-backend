using System;
using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record MemberAddRequest(long ArtistId, string StageName, string FirstName, string MiddleName,
                               string Surname, string Photo, DateTime? DateOfBirth, DateTime? DateOfDeath,
                               int? BirthPlaceId);

public record MemberUpdateRequest(long Id, long ArtistId, string StageName, string FirstName,
                                  string MiddleName, string Surname, string Photo, DateTime? DateOfBirth,
                                  DateTime? DateOfDeath, int? BirthPlaceId);

public record MemberResponse(long Id, long ArtistId, string StageName,
                             string FirstName, string MiddleName, string Surname,
                             string Photo, DateTime? DateOfBirth, DateTime? DateOfDeath);

public record MemberActionResponse(long Id, List<Message> Messages, bool IsValid);

public record MemberPhotoActionResponse(string filename, bool IsValid);

