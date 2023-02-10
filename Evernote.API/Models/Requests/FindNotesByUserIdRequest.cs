namespace Evernote.API.Models.Requests {
    public record FindNotesByUserIdRequest 
    {
        public const string Route = "{userId}";
        public Guid UserId { get; init; }
    }
}
