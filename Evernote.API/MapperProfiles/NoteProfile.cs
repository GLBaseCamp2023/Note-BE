using AutoMapper;
using Evernote.API.Models.Requests;
using Evernote.Domain.Dtos;

namespace Evernote.API.MapperProfiles {
    public class NoteProfile : Profile
    {
        protected NoteProfile() 
        {
            CreateMap<AddNoteRequest, NoteDto>();
        } 
    }
}
