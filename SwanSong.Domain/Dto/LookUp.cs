using System.Collections.Generic;

namespace SwanSong.Domain.Dto;

public record BirthPlaceAddRequest(string Name, int CountryId);

public record BirthPlaceUpdateRequest(int Id, string Name, int CountryId);

public record CountryAddRequest(string Name);

public record CountryUpdateRequest(int Id, string Name);

public record RecordLabelAddRequest(string Name);

public record RecordLabelUpdateRequest(int Id, string Name);

public record StudioAddRequest(string Name);

public record StudioUpdateRequest(int Id, string Name);

public record BirthPlaceResponse(int Id, string Name, int? CountryId);

public record BirthPlaceActionResponse(long Id, string Name, List<Message> Messages, bool IsValid);

public record CountryResponse(int Id, string Name);

public record CountryActionResponse(long Id, string name, List<Message> Messages, bool IsValid);

public record RecordLabelResponse(int Id, string Name);

public record RecordLabelActionResponse(long Id, string name, List<Message> Messages, bool IsValid);

public record StudioResponse(int Id, string Name);

public record StudioActionResponse(long Id, string name, List<Message> Messages, bool IsValid);

