using Evernote.DataContext.Abstract;
using Evernote.DataContext.Generic;
using Evernote.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Evernote.DataContext.Repositories {
    public class TagRepository : DbRepository<Tag>, ITagRepository {
        public TagRepository(AppDataContext context) : base(context) {
        }
    }
}
