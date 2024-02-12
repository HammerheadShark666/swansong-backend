using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwanSong.Domain.Dto.Request;
using SwanSong.Domain.Dto.Response;
using SwanSong.Helper;
using SwanSong.Helper.Filter;
using SwanSong.Helper.Exceptions;
using SwanSong.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace SwanSong.Api.Controllers;

[ApiVersion("1.0")]
[Authorize]
[Route("api/members")]
[ApiController]
[ApiConventionType(typeof(DefaultApiConventions))]
[Produces(MediaTypeNames.Application.Json)]
[Consumes(MediaTypeNames.Application.Json)]
public class MembersController : Controller
{
    private readonly ILogger<MembersController> _logger;      
    private readonly IMemberService _memberService; 

    public MembersController(ILogger<MembersController> logger, IMemberService memberService)
    {
        _logger = logger; 
        _memberService = memberService; 
    }

    [HttpGet("")]
    public async Task<ActionResult<List<MemberResponse>>> GetAllAsync([FromQuery] PaginationFilter filter)
    {
        var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
        var pagedData = await _memberService.GetAllAsync(validFilter);
        var totalRecords = await _memberService.CountAsync();

        return Ok(PagingHelper.CreatePagedReponse<MemberResponse>(pagedData, validFilter, totalRecords));
    }

    [HttpGet("random")]
    public async Task<ActionResult<List<MemberResponse>>> GetRandomAsync()
    {
        return Ok(await _memberService.GetRandomAsync(10));
    }

    [HttpGet("member/{id}")]
    public async Task<ActionResult<MemberResponse>> GetMemberAsync(long id)
    { 
        return await _memberService.GetAsync(id);
    }

    [HttpGet("search/{criteria}")]
    public async Task<ActionResult<List<MemberResponse>>> SearchAsync(string criteria)
    {
        return Ok(await _memberService.SearchByNameAsync(criteria));
    }

    [HttpGet("search-by-letter/{letter}")]
    public async Task<ActionResult<List<MemberResponse>>> SearchByLetterAsync(string letter)
    {
        return Ok(await _memberService.SearchByLetterAsync(letter));
    }

    [HttpGet("{artistId}")]
    public async Task<ActionResult<List<MemberResponse>>> MemberMembersAsync(long artistId)
    {
        return await _memberService.GetMembersByArtistAsync(artistId);
    }

    [HttpPost("member/add")]
    public async Task<ActionResult<MemberActionResponse>> AddAsync([FromBody] MemberAddRequest memberAddRequest)
    {
        return Ok(await _memberService.AddAsync(memberAddRequest));
    }

    [HttpPost("member/update")]
    public async Task<ActionResult<MemberActionResponse>> UpdateAsync([FromBody] MemberUpdateRequest memberUpdateRequest)
    {
        return Ok(await _memberService.UpdateAsync(memberUpdateRequest));
    }

    [HttpDelete("member/{id}")]
    public async Task<ActionResult<MemberResponse>> DeleteAsync(long id)
    {
        return Ok(await _memberService.DeleteAsync(id));
    }

    [HttpPost("member/upload-photo/{id}")]
    [Consumes("multipart/form-data")]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SavePhotoAsync(long id)
    {
        return Ok(await _memberService.UpdateMemberPhotoAsync(id, Request.Form.Files[0]));
    }
}