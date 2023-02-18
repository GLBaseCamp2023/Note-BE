namespace Evernote.API.Models.Requests {
    public record AddNoteRequest 
    {
        public string Text { get; init; }
        public DateTime CreationDate { get; } = DateTime.Now;
        public DateTime LastChangeDate { get; } = DateTime.Now;
    }
}
