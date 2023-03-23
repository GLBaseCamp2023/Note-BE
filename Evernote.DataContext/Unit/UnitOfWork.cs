using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evernote.DataContext.Generic;
using Evernote.DataContext.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Evernote.DataContext.Unit {
    public class UnitOfWork : IUnitOfWork {




        private readonly Lazy<ITagRepository> _tagRepository;
        private readonly Lazy<IImageRepository> _imageRepository;
        private readonly Lazy<INoteRepository> _noteRepository;
        private readonly Lazy<IUserRepository> _userRepository;

        private readonly AppDataContext _dbContext;
        public UnitOfWork(AppDataContext dbContext) {
            _dbContext = dbContext;
            _tagRepository = new Lazy<ITagRepository>(() => new TagRepository(_dbContext));
            _imageRepository = new Lazy<IImageRepository>(() => new ImageRepository(_dbContext));
            _noteRepository = new Lazy<INoteRepository>(() => new NoteRepository(_dbContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(_dbContext));
        }

#pragma warning disable IDE0025
        public ITagRepository TagRepository => _tagRepository.Value;
        public IImageRepository ImageRepository => _imageRepository.Value;
        public INoteRepository NoteRepository => _noteRepository.Value;
        public IUserRepository UserRepository => _userRepository.Value;




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
