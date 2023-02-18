using System.Linq.Expressions;
using Evernote.Domain;

namespace Evernote.DataContext.Abstract {
    public interface IDbRepository<T>
        where T : class, IDbEntity {

        Task<List<T>> GetAllItemsAsync(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includes);

        Task<T> AddItemAsync(T item);

        Task<IEnumerable<T>> AddItemsAsync(IEnumerable<T> items);

        Task<T> GetItemAsync(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] includes);

        Task<bool> ChangeItemAsync(T item);

        Task<bool> DeleteItemAsync(Guid id);
        Task<bool> DeleteItemsAsync(IEnumerable<T> entities);

        Task<int> SaveChangesAsync();
    }
}
