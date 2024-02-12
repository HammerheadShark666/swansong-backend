using System;

namespace SwanSong.Helper.Exceptions;

public class AlbumSongNotFoundException : Exception
{
    public AlbumSongNotFoundException()
    {
    }

    public AlbumSongNotFoundException(string message)
        : base(message)
    {
    }

    public AlbumSongNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}