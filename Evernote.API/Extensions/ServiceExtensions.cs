using Evernote.API.MapperProfiles;
using Evernote.Application.Implementations;
using Evernote.Application.Interfaces;
using Evernote.DataContext.Unit;

namespace Evernote.API.Extensions;
public static class ServiceExtensions {
    public static void ConfigureServices(this IServiceCollection services) {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<INoteService, NoteService>();
    }

    public static void ConfigureAutoMapper(this IServiceCollection services) {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    } 
}
