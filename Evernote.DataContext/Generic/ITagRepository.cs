using Evernote.DataContext.Abstract;
using Evernote.Domain.Entities;

namespace Evernote.DataContext.Generic {
    public interface ITagRepository : IDbRepository<Tag> {
    }
}
