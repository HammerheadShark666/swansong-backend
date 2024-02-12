﻿using System;

namespace SwanSong.Helper.Exceptions;

public class AlbumNotFoundException : ArgumentNullException //Exception
{
    public AlbumNotFoundException()
    {
    }

    public AlbumNotFoundException(string message)
        : base(message)
    {
    }

    public AlbumNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}