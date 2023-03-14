using Evernote.DataContext.Abstract;
using Evernote.DataContext.Generic;
using Evernote.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Evernote.DataContext.Repositories {
    public class ImageRepository : DbRepository<Image>, IImageRepository {
        public ImageRepository(AppDataContext context) : base(context) {
        }
    }
}
