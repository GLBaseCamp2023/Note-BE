using AutoMapper;
using Evernote.Application.Interfaces;
using Evernote.DataContext.Generic;
using Evernote.Domain.Dtos;
using Evernote.Domain.Entities;

namespace Evernote.Application.Implementations {
    public class NoteService : INoteService {
        
        private readonly INoteRepository noteRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public NoteService(
            INoteRepository noteRepository,
            IUserRepository userRepository,
            IMapper mapper) {
            this.noteRepository = noteRepository;
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<NoteDto> AddNoteAsync(NoteDto note) {
            var noteEntity = mapper.Map<Note>(note);
            var createdNote = await noteRepository.AddItemAsync(noteEntity);

            await noteRepository.SaveChangesAsync();

            return mapper.Map<NoteDto>(createdNote);
        }

        public async Task DeleteNoteAsync(Guid id) {

                await noteRepository.DeleteItemAsync(id);
                await noteRepository.SaveChangesAsync();

      
          

        }

        public async Task<IEnumerable<NoteDto>> GetUserNotesAsync(Guid userId) {
            var user = await userRepository.GetItemAsync(n => n.Id == userId, n => n.Notes);
            var notes = mapper.Map<IEnumerable<NoteDto>>(user.Notes);

            return notes;
        }
    }
}
