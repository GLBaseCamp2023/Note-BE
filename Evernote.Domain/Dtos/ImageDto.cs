namespace Evernote.Domain.Dtos;
public class ImageDto {
    public string Path { get; set; }
    public Guid NoteId { get; set; }
    public NoteDto Note { get; set; }

}
