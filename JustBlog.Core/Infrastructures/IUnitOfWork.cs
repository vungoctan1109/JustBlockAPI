using JustBlog.Core.IRepositories;

namespace JustBlog.Core.Infrastructures
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        ITagRepository TagRepository { get; }
        IPostRepository PostRepository { get; }
        Task SaveAsync();
    }
}