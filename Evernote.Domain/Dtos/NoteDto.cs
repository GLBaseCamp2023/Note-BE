namespace Evernote.Domain.Dtos;
public class NoteDto {
    public string Text { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime LastChangeDate { get; set; }
    public Guid UserId { get; set; }
    public UserDto User { get; set; }
    public List<ImageDto> Images { get; set; }
    public List<TagDto> Tags { get; set; }
    public List<TagNoteDto> TagNotes { get; set; }
}
