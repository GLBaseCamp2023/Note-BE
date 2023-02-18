using Evernote.DataContext.Generic;
using Evernote.DataContext.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Evernote.DataContext {
    public static class DependencyInjection {
        public static void AddDataContext(this IServiceCollection services, IConfiguration configuration) {
            // TODO: We need to decide which database provider we will use (PostrgreSQl, MS SQL, etc.)

            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
