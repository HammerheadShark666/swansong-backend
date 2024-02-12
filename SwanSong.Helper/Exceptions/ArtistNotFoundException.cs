using System;

namespace SwanSong.Helper.Exceptions;

public class ArtistNotFoundException : Exception
{
    public ArtistNotFoundException()
    {
    }

    public ArtistNotFoundException(string message)
        : base(message)
    {
    }

    public ArtistNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}