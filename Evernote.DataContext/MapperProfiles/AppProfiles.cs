using AutoMapper;
using Evernote.Domain.Dtos;
using Evernote.Domain.Entities;

namespace Evernote.DataContext.MapperProfiles; 
public class AppProfiles : Profile {
    public AppProfiles() {
        CreateMap<Note, NoteDto>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<Image, ImageDto>().ReverseMap();
        CreateMap<Tag, TagDto>().ReverseMap();
        CreateMap<TagNote, TagNoteDto>().ReverseMap();
    }
}
