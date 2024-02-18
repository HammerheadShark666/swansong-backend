using MediatR;
using SwanSong.Domain;
using System.Collections.Generic;

namespace SwanSong.Data.MediatR.Queries;

public class GetCountryListQuery : IRequest<List<Country>> { }