namespace Evernote.API.Models.Requests; 
public record DeleteNoteRequest 
{
    public const string Route = "{noteId}";
    public Guid NoteId { get; init; }
}
