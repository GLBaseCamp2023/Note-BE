using Evernote.Domain.Dtos;

namespace Evernote.API.Models.Responses {
    public record FindNotesByUserIdResponse {
        public IEnumerable<NoteDto> Notes { get; init; }
    }
}
