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

        private TagRepository _tagRepository;
        public ITagRepository TagRepository => _tagRepository ?? (_tagRepository = new TagRepository(_dbContext));

        private ImageRepository _imageRepository;
        public IImageRepository ImageRepository => _imageRepository ?? (_imageRepository = new ImageRepository(_dbContext));

        private NoteRepository _noteRepository;
        public INoteRepository NoteRepository => _noteRepository ?? (_noteRepository = new NoteRepository(_dbContext));

        private UserRepository _userRepository;
        public IUserRepository UserRepository => _userRepository ?? (_userRepository = new UserRepository(_dbContext));


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
