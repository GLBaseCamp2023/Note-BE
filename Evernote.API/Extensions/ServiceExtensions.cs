using Evernote.Application.Implementations;
using Evernote.Application.Interfaces;

namespace Evernote.API.Extensions;
public static class ServiceExtensions {
    public static void ConfigureServices(this IServiceCollection services) {
        services.AddScoped<INoteService, NoteService>();
    }
}
