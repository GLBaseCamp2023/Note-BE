using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evernote.DataContext.Generic;

namespace Evernote.DataContext.Unit {
    internal interface IUnitOfWork : IAsyncDisposable {

        IUserRepository UserRepository { get; }
        ITagRepository TagRepository { get; }
        IImageRepository ImageRepository { get; }
        INoteRepository NoteRepository { get; }

        Task CompleteAsync();
    }
}
