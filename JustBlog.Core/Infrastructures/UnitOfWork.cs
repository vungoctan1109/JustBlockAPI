using AutoMapper;
using JustBlog.Core.IRepositories;
using JustBlog.Core.Repositories;
using JustBlog.Entity.Context;

namespace JustBlog.Core.Infrastructures;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext context;
    private ICategoryRepository categoryRepository;
    private IPostRepository postRepository;
    private ITagRepository tagRepository;
    public readonly IMapper _mapper;

    public UnitOfWork(IMapper mapper)
    {
        context = new ApplicationDbContext();
        categoryRepository = new CategoryRepository(context, mapper);
        tagRepository = new TagRepository(context, mapper);
        postRepository = new PostRepository(context, mapper);
        _mapper = mapper;
    }

    public ICategoryRepository CategoryRepository
    {
        get
        {
            if (categoryRepository == null)
            {
                categoryRepository = new CategoryRepository(context, _mapper);
            }
            return categoryRepository;
        }
    }

    public ITagRepository TagRepository
    {
        get
        {
            if (tagRepository == null)
            {
                tagRepository = new TagRepository(context, _mapper);
            }
            return tagRepository;
        }
    }

    public IPostRepository PostRepository
    {
        get
        {
            if (postRepository == null)
            {
                postRepository = new PostRepository(context, _mapper);
            }
            return postRepository;
        }
    }
    public async Task SaveAsync()
    {
        await context.SaveChangesAsync();
    }
    public IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class
    {
        return new BaseRepository<TEntity>(context, _mapper);
    }

    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
