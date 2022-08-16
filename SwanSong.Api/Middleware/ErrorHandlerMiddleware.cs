using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto;
using SwanSong.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using static SwanSong.Helper.Enums;

namespace SwanSong.Api.Middleware
{
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
                var result = "Error";
                var errors = new Object[] { };
                var response = context.Response;
                response.ContentType = "application/json";
                MessageDto messageDto = null;

                switch (error)
                {
                    case AppException e:
                        // custom application error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        messageDto = new MessageDto(e.Message, "error");
                        result = Newtonsoft.Json.JsonConvert.SerializeObject(new Object[] { messageDto });
                        break;
                    case KeyNotFoundException e:
                        // not found error
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        result = Newtonsoft.Json.JsonConvert.SerializeObject(error);
                        break;
                    default:
                        // unhandled error
                        _logger.LogError(error, error.Message);
                        response.StatusCode = (int)HttpStatusCode.InternalServerError; 
                        messageDto = new MessageDto(error.Message, MessageSeverity.error.ToString());
                        result = Newtonsoft.Json.JsonConvert.SerializeObject(new Object[] { messageDto });
                        break;
                }

                await response.WriteAsync(result);
            }
        }
    }
}