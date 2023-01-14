using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evernote.Entities;
using Evernote.Repositories.Abstract;

namespace Evernote.Repositories.Generic {
    public interface ITagRepository : IDbRepository<Tag> {
    }
}
