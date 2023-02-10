namespace Evernote.Domain.Dtos {
    public class UserDto {
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public List<NoteDto> Notes { get; set; }
    }
}
