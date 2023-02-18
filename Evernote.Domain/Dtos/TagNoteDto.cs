namespace Evernote.Domain.Dtos;
public class TagNoteDto {
    public Guid NoteId { get; set; }
    public NoteDto Note { get; set; }
    public Guid TagId { get; set; }
    public TagDto Tag { get; set; }
}
