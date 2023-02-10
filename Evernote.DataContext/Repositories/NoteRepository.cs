using Evernote.DataContext.Abstract;
using Evernote.DataContext.Generic;
using Evernote.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Evernote.DataContext.Repositories {
    public class NoteRepository : DbRepository<Note>, INoteRepository {
        public NoteRepository(DbContext context) : base(context) {
        }
    }
}
