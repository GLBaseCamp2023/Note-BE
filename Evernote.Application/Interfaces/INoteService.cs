using Evernote.Domain.Dtos;

namespace Evernote.Application.Interfaces;
public interface INoteService {
    Task<IEnumerable<NoteDto>> GetUserNotesAsync(Guid userId);
    Task<NoteDto> AddNoteAsync(NoteDto note);
    Task<bool> DeleteNoteAsync(Guid id);
}
