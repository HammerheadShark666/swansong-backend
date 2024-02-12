using System;

namespace SwanSong.Helper.Exceptions;

public class RecordLabelNotFoundException : Exception
{
    public RecordLabelNotFoundException()
    {
    }

    public RecordLabelNotFoundException(string message)
        : base(message)
    {
    }

    public RecordLabelNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}