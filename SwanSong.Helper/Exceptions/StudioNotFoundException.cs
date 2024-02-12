using System;

namespace SwanSong.Helper.Exceptions;

public class StudioNotFoundException : Exception
{
    public StudioNotFoundException()
    {
    }

    public StudioNotFoundException(string message)
        : base(message)
    {
    }

    public StudioNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}