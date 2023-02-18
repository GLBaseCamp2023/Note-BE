using Evernote.DataContext.Abstract;
using Evernote.DataContext.Generic;
using Evernote.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Evernote.DataContext.Repositories {
    public class UserRepository : DbRepository<User>, IUserRepository {
        public UserRepository(DbContext context) : base(context) {
        }
    }
}
