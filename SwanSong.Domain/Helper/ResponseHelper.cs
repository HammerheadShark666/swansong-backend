using FluentValidation;
using FluentValidation.Results;
using SwanSong.Domain.Dto;
using System.Collections.Generic;

namespace SwanSong.Domain.Helper;

public class ResponseHelper
{
    public static List<Message> GetMessages(List<ValidationFailure> rules)    
    {
        List<Message> messages = new();
        foreach (ValidationFailure validationFailure in rules)
        {
            messages.Add(new Message(validationFailure.ErrorMessage, GetServerity(validationFailure.Severity)));
        }

        return messages;        
    }

    public static string GetServerity(Severity severity)
    {
        return severity switch
        {
            Severity.Error => "error",
            Severity.Warning => "warning",
            Severity.Info => "info",
            _ => "",
        };
    }
}
