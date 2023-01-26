using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Evernote.Entities;

namespace Evernote.Repositories.Abstract {
    public interface IDbRepository<T>
        where T : class, IDbEntity {

        Task<List<T>> GetAllItemsAsync(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includes);

        Task<bool> AddItemAsync(T item);

        Task<int> AddItemsAsync(IEnumerable<T> items);

        Task<T> GetItemAsync(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includes);

        Task<bool> ChangeItemAsync(T item);

        Task<bool> DeleteItemAsync(Guid id);
        Task<bool> DeleteItemsAsync(IEnumerable<T> entities);

        Task<int> SaveChangesAsync();
    }
}
