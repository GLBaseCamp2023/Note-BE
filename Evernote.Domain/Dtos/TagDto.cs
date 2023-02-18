namespace Evernote.Domain.Dtos;
public class TagDto {
    public string Name { get; set; }

    public List<NoteDto> Notes { get; set; }
    public List<TagNoteDto> TagNotes { get; set; }
}
