using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evernote.Entities;
using Evernote.Repositories.Abstract;
using Evernote.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace Evernote.Repositories {
    internal class TagRepository : DbRepository<Tag>, ITagRepository {
        public TagRepository(DbContext context) : base(context) {
        }
    }
}
