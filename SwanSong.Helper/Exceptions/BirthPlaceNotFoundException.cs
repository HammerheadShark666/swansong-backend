using System;

namespace SwanSong.Helper.Exceptions;

public class BirthPlaceNotFoundException : Exception
{
    public BirthPlaceNotFoundException()
    {
    }

    public BirthPlaceNotFoundException(string message)
        : base(message)
    {
    }

    public BirthPlaceNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}