using Evernote.DataContext.Abstract;
using Evernote.DataContext.Generic;
using Evernote.DataContext.Repositories;
using Evernote.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Evernote.DataContext {
    public static class DependencyInjection {
        public static void AddDataContext(this IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<AppDataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DataConnection")));

            services.AddScoped<IImageRepository, ImageRepository>();
            services.AddScoped<INoteRepository, NoteRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
