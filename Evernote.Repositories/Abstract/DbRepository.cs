using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Evernote.Entities;
using Microsoft.EntityFrameworkCore;

namespace Evernote.Repositories.Abstract {
    public class DbRepository<T> : IDbRepository<T>
        where T : class, IDbEntity {
        private DbContext _context;
        private DbSet<T> _dbSet;




        public DbRepository(DbContext context) {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<bool> AddItemAsync(T entity) {
            _dbSet.Add(entity);

            return await SaveChangesAsync() > 0;

        }

        public async Task<int> AddItemsAsync(IEnumerable<T> entities) {
            await _dbSet.AddRangeAsync(entities);
            return await SaveChangesAsync();
        }

        public async Task<bool> ChangeItemAsync(T entity) {


            _dbSet.Attach(entity).State = EntityState.Modified;
            return await SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteItemAsync(Guid id) {
            T candidate = await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
            _dbSet.Remove(candidate);
            return await SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteItemsAsync(IEnumerable<T> entities) {
            foreach (var item in entities) {
                var h = _dbSet.Find(item.Id);
                _dbSet.Remove(h);
            }
            return await SaveChangesAsync() > 0;
        }
        public async Task<T> GetItemAsync(Expression<Func<T, bool>>? filter = null,params Expression<Func<T, object>>[] includes) {
            IQueryable<T> query = _dbSet;
            query = query.AsNoTracking();

            if (filter != null) {
                query = query.Where(filter);
            }
            if (includes != null) {
                query = includes.Aggregate(query,
                    (current, include) => current.Include(include));
            }
            return await query.FirstOrDefaultAsync();
        }


        public async Task<int> SaveChangesAsync() {

            return await _context.SaveChangesAsync();

        }

        public async Task<List<T>> GetAllItemsAsync(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includes) {
            IQueryable<T> query = _dbSet;
            if (filter != null) {
                query = query.Where(filter);
            }
            if (includes != null) {
                query = includes.Aggregate(query,
                    (current, include) => current.Include(include));
            }
            return await query.ToListAsync();
        }
    }
}
