using AutoMapper;
using JustBlog.Core.Infrastructures;
using JustBlog.Service.IServices;
using System.Linq.Expressions;

namespace JustBlog.Service.Services
{
    public class BaseService<TEntity, TEntityCM, TEntityVM, TEntityUM> : IBaseService<TEntity, TEntityCM, TEntityVM, TEntityUM>
        where TEntity : class
        where TEntityCM : class
        where TEntityVM : class
        where TEntityUM : class
    {
        protected readonly UnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public BaseService(UnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public virtual async Task AddAsync(TEntityCM entity)
        {
            TEntity entityToAdd = _mapper.Map<TEntity>(entity);
            await unitOfWork.GetRepository<TEntity>().AddAsync(entityToAdd);
            await unitOfWork.SaveAsync();
        }

        public virtual async Task AddRangeAsync(IEnumerable<TEntityCM> entities)
        {
            IEnumerable<TEntity> entitiesToAdd = entities.Select(e => _mapper.Map<TEntity>(e));
            await unitOfWork.GetRepository<TEntity>().AddMultipleAsync(entitiesToAdd);
            await unitOfWork.SaveAsync();
        }

        public virtual async Task DeleteAsync(TEntityVM entityToDelete)
        {
            unitOfWork.GetRepository<TEntity>().Delete(_mapper.Map<TEntity>(entityToDelete));
            await unitOfWork.SaveAsync();
        }

        public virtual async Task DeleteAsync(object id)
        {
            unitOfWork.GetRepository<TEntity>().Delete(id);
            await unitOfWork.SaveAsync();
        }

        public virtual async Task DeleteRangeAsync(IEnumerable<TEntityVM> entities)
        {
            unitOfWork.GetRepository<TEntity>().DeleteMultiple(entities.Select(e => _mapper.Map<TEntity>(e)));
            await unitOfWork.SaveAsync();
        }

        public virtual async Task<TEntityVM?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await unitOfWork.GetRepository<TEntity>().FirstOrDefaultAsync<TEntityVM>(filter);
        }

        public virtual async Task<IEnumerable<TEntityVM>> GetAsync(int? page = null, int? pageSize = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "")
        {
            return await unitOfWork.GetRepository<TEntity>().GetAsync<TEntityVM>(page, pageSize, filter, orderBy, includeProperties);
        }

        public virtual async Task UpdateAsync(TEntityUM entityToUpdate)
        {
            unitOfWork.GetRepository<TEntity>().Update(_mapper.Map<TEntity>(entityToUpdate));
            await unitOfWork.SaveAsync();
        }

        public virtual async Task UpdateRangeAsync(IEnumerable<TEntityUM> entities)
        {
            unitOfWork.GetRepository<TEntity>().UpdateMultiple(entities.Select(e => _mapper.Map<TEntity>(e)));
            await unitOfWork.SaveAsync();
        }
    }
}
