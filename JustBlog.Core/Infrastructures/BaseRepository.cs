using AutoMapper;
using AutoMapper.QueryableExtensions;
using JustBlog.Entity.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JustBlog.Core.Infrastructures;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    protected readonly ApplicationDbContext context;
    protected readonly DbSet<TEntity> dbSet;
    public readonly IMapper _mapper;

    public BaseRepository(ApplicationDbContext context, IMapper mapper)
    {
        this.context = context;
        dbSet = context.Set<TEntity>();
        _mapper = mapper;

    }
    public virtual async Task<IEnumerable<TEntity>> GetAsync(int? page = null, int? pageSize = null,
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        string includeProperties = "")
    {
        IQueryable<TEntity> query = dbSet.AsQueryable();
        if (filter != null)
        {
            query = query.Where(filter);
        }
        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (string includeProperty in includeProperties.Split
            (new char[] { ',' }, StringSplitOptions.TrimEntries))
            {
                query = query.Include(includeProperty);
            }
        }

        if (orderBy != null)
        {
            query = orderBy(query);
        }
        if (page != null)
        {
            query = pageSize != null
                ? query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value)
                : query.Skip((page.Value - 1) * 10).Take(10);
        }
        return await query.ToListAsync();
    }
    public virtual async Task<IEnumerable<TResult>> GetAsync<TResult>(Expression<Func<TEntity, TResult>> selector,
        int? page = null, int? pageSize = null,
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        string includeProperties = "")
    {
        IQueryable<TEntity> query = dbSet.AsQueryable();

        if (filter != null)
        {
            query = query.Where(filter);
        }
        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (string includeProperty in includeProperties.Split
                 (new char[] { ',' }, StringSplitOptions.TrimEntries))
            {
                query = query.Include(includeProperty);
            }
        }


        if (orderBy != null)
        {
            query = orderBy(query);
        }

        if (page != null)
        {
            query = pageSize != null
                ? query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value)
                : query.Skip((page.Value - 1) * 10).Take(10);
        }
        return await query.Select(selector).ToListAsync();
    }
    public virtual async Task<TEntity?> GetByIdAsync(object id)
    {
        return await dbSet.FindAsync(id);
    }

    public virtual async Task AddAsync(TEntity entity)
    {
        await dbSet.AddAsync(entity);
    }
    public virtual void Delete(object id)
    {
        TEntity? entityToDelete = dbSet.Find(id);
        if (entityToDelete != null)
        {
            dbSet.Remove(entityToDelete);
        }
    }
    public virtual void Delete(TEntity entityToDelete)
    {
        dbSet.Remove(entityToDelete);
    }
    public virtual void Update(TEntity entityToUpdate)
    {
        dbSet.Update(entityToUpdate);

    }
    public virtual async Task<int> CountAsync(
        Expression<Func<TEntity, bool>>? filter = null,
        string includeProperties = "")

    {
        IQueryable<TEntity> query = dbSet.AsQueryable();

        if (filter != null)
        {
            query = query.Where(filter);
        }


        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (string includeProperty in includeProperties.Split
                 (new char[] { ',' }, StringSplitOptions.TrimEntries))
            {
                query = query.Include(includeProperty);
            }
        }
        return await query.CountAsync();
    }

    public virtual async Task AddMultipleAsync(IEnumerable<TEntity> entities)
    {
        await dbSet.AddRangeAsync(entities);
    }

    public virtual void DeleteMultiple(IEnumerable<TEntity> entities)
    {
        dbSet.RemoveRange(entities);
    }

    public virtual void UpdateMultiple(IEnumerable<TEntity> entities)
    {
        dbSet.UpdateRange(entities);

    }

    public virtual async Task<TResult?> FirstOrDefaultAsync<TResult>(Expression<Func<TEntity, bool>> filter)
    {
        return await dbSet.Where(filter).ProjectTo<TResult>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
    }

    public virtual async Task<IEnumerable<TResult>> GetAsync<TResult>(int? page = null, int? pageSize = null, Expression<Func<TEntity, bool>>? filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, string includeProperties = "")
    {
        IQueryable<TEntity> query = dbSet.AsQueryable();

        if (filter != null)
        {
            query = query.Where(filter);
        }
        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (string includeProperty in includeProperties.Split
                 (new char[] { ',' }, StringSplitOptions.TrimEntries))
            {
                query = query.Include(includeProperty);
            }
        }


        if (orderBy != null)
        {
            query = orderBy(query);
        }

        if (page != null)
        {
            query = pageSize != null
                ? query.Skip((page.Value - 1) * pageSize.Value).Take(pageSize.Value)
                : query.Skip((page.Value - 1) * 10).Take(10);
        }
        return await query.ProjectTo<TResult>(_mapper.ConfigurationProvider).ToListAsync();
    }

    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> filter)
    {
        return await dbSet.AnyAsync(filter);
    }
}