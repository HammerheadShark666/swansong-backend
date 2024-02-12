using SwanSong.Domain.Dto;
using System;

namespace SwanSong.Helper.Exceptions;

public class FailedValidationException : Exception
{
    public FailedValidationException(FailedValidationResponse failedValidationResponse) 
    {
        FailedValidationResponse = failedValidationResponse;
    }

    public FailedValidationResponse FailedValidationResponse { get; set; }
}