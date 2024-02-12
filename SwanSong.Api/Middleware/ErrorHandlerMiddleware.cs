using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using SwanSong.Api.Helpers.Extensions;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Dto.Response;
using SwanSong.Domain.Exceptions;
using SwanSong.Helper.Exceptions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using static SwanSong.Helper.Enums;

namespace SwanSong.Api.Middleware;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public ErrorHandlerMiddleware(RequestDelegate next, ILogger<ErrorHandlerMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception error)
        { 
            var response = context.Response;
            response.ContentType = "application/json";
            MessageResponse messageResponse = null;

            switch (error)
            {
                case FailedValidationException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        messageResponse = new MessageResponse(e.FailedValidationResponse.Messages, MessageSeverity.error.ToString());
                        break;
                case AlbumNotFoundException:
                case AlbumSongNotFoundException:
                case ArtistNotFoundException:
                case BirthPlaceNotFoundException:
                case CountryNotFoundException:
                case MemberNotFoundException:
                case RecordLabelNotFoundException:
                case SongNotFoundException:
                case StudioNotFoundException:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        messageResponse = new MessageResponse(new List<Message>() { new Message(error.Message, MessageSeverity.error.ToString()) }, MessageSeverity.error.ToString());
                        break;
                case AppException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        messageResponse = new MessageResponse(new List<Message>() { new Message(e.Message, MessageSeverity.error.ToString()) }, MessageSeverity.error.ToString());
                        break;
                case KeyNotFoundException e:
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;
                default:
                         _logger.LogError(error, error.Message);
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        messageResponse = new MessageResponse(new List<Message>() { new Message(error.Message, MessageSeverity.error.ToString()) }, MessageSeverity.error.ToString());
                        break;
            } 

            await response.WriteAsync(messageResponse.SerializeWithCamelCase());
        }
    }
}