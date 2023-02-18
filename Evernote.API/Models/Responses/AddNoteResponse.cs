using Evernote.Domain.Dtos;

namespace Evernote.API.Models.Responses;
public record AddNoteResponse 
{
    public NoteDto Note { get; init; }
}
