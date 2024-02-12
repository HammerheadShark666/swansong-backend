using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Helper.Exceptions;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[Authorize]
[Route("api/record-labels")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class RecordLabelController : Controller
{
    private readonly ILogger<RecordLabelController> _logger;      
    private readonly IRecordLabelService _recordLabelService;

    public RecordLabelController(ILogger<RecordLabelController> logger, IRecordLabelService recordLabelService)
    {
        _logger = logger;
        _recordLabelService = recordLabelService;
    }

    [HttpGet("")]
    public async Task<ActionResult<List<RecordLabelResponse>>> GetAllAsync()
    {
        return Ok(await _recordLabelService.GetAllAsync()); 
    }

    [HttpPost("record-label/add")]
    public async Task<IActionResult> AddRecordLabelAsync([FromBody] RecordLabelAddRequest recordLabelAddRequest)
    {
        return Ok(await _recordLabelService.AddAsync(recordLabelAddRequest));
    }

    [HttpPost("record-label/update")]
    public async Task<IActionResult> UpdateRecordLabelAsync([FromBody] RecordLabelUpdateRequest recordLabelUpdateRequest)
    {
        return Ok(await _recordLabelService.UpdateAsync(recordLabelUpdateRequest));
    }

    [Authorize]
    [HttpDelete("record-label/{id}")]
    public async Task<ActionResult<RecordLabelResponse>> DeleteAsync(int id)
    {
        return Ok(await _recordLabelService.DeleteAsync(id));
    } 
}