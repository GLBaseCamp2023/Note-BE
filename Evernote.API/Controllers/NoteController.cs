using AutoMapper;
using Evernote.API.Models.Requests;
using Evernote.API.Models.Responses;
using Evernote.Application.Interfaces;
using Evernote.Domain.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Evernote.API.Controllers;

public class NoteController : ApiControllerBase<NoteController> 
{
    private readonly INoteService _noteService; 

    public NoteController(
        IMapper mapper,
        ILogger<NoteController> logger,
        INoteService noteService)
        : base(mapper, logger)
    {
        _noteService = noteService;
    }

    // TODO: Add pagination
    [HttpGet(FindNotesByUserIdRequest.Route)]
    [ProducesResponseType(typeof(FindNotesByUserIdResponse), 200)]
    public async Task<FindNotesByUserIdResponse> FindNotesByUserId([FromBody] FindNotesByUserIdRequest request)
    {
        var notes = await _noteService.GetUserNotesAsync(request.UserId);
        return new FindNotesByUserIdResponse 
        {
            Notes = notes
        };
    }

    // TODO: Add tags and images to request
    // TODO: Get and write userId
    [HttpPost]
    [ProducesResponseType(typeof(AddNoteRequest), 201)]
    public async Task<AddNoteResponse> AddNote([FromBody] AddNoteRequest request) 
    {
        var note = Mapper.Map<NoteDto>(request);
        var createdNote = await _noteService.AddNoteAsync(note);
        return new AddNoteResponse 
        {
            Note = createdNote
        };
    }

    [HttpDelete]
    [ProducesResponseType(typeof(DeleteNoteResponse), 200)]
    public async Task<DeleteNoteResponse> DeleteNote([FromBody] DeleteNoteRequest request) 
    {
        var isSuccess = await _noteService.DeleteNoteAsync(request.NoteId);

        return new DeleteNoteResponse {
            IsSuccess = isSuccess
        };
    }
}
