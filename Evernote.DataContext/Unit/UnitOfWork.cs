using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evernote.DataContext.Generic;
using Evernote.DataContext.Repositories;

namespace Evernote.DataContext.Unit {
    public class UnitOfWork : IUnitOfWork {


#pragma warning disable IDE0025

        public ITagRepository TagRepository => new TagRepository(_dbContext);
        public IImageRepository ImageRepository => new ImageRepository(_dbContext);
        public INoteRepository NoteRepository => new NoteRepository(_dbContext);
        public IUserRepository UserRepository => new UserRepository(_dbContext);


        private readonly AppDataContext _dbContext;

        public UnitOfWork(AppDataContext dbContext) {
            _dbContext = dbContext;
        }
#pragma warning disable IDE0022
        public async Task CompleteAsync() => await _dbContext.SaveChangesAsync();

        private bool _disposed;

        public async ValueTask DisposeAsync() {
            await DisposeAsync(true);

            GC.SuppressFinalize(this);
        }

        protected virtual async ValueTask DisposeAsync(bool disposing) {
            if (!_disposed) {
                if (disposing) {
                    await _dbContext.DisposeAsync();
                }


                _disposed = true;
            }
        }
    }
}
