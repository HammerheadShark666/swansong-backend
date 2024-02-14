﻿using SwanSong.Domain.Dto;
using System.Threading.Tasks;

namespace SwanSong.Service.Interfaces;

public interface ISongService
{
    Task<SongActionResponse> DeleteAsync(long id);
}