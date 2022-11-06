using System.Linq.Expressions;

namespace JustBlog.Core.Infrastructures
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task AddAsync(TEntity entity);
        Task AddMultipleAsync(IEnumerable<TEntity> entities);
        Task<int> CountAsync(Expression<Func<TEntity, bool>>? filter = null, string includeProperties = "");
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void DeleteMultiple(IEnumerable<TEntity> entities);
        Task<TResult?> FirstOrDefaultAsync<TResult>(Expression<Func<TEntity, bool>> filter);
        Task<IEnumerable<TEntity>> GetAsync(int? page = null, int? pageSize = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "");
        Task<IEnumerable<TResult>> GetAsync<TResult>(int? page = null, int? pageSize = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "");
        Task<IEnumerable<TResult>> GetAsync<TResult>(Expression<Func<TEntity, TResult>> selector, int? page = null, int? pageSize = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "");
        Task<TEntity?> GetByIdAsync(object id);
        void Update(TEntity entityToUpdate);
        void UpdateMultiple(IEnumerable<TEntity> entities);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter);
    }
}