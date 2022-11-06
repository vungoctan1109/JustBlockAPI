using AutoMapper;
using JustBlog.Core.Infrastructures;
using JustBlog.Core.IRepositories;
using JustBlog.Entity.Context;
using JustBlog.Entity.Entities;

namespace JustBlog.Core.Repositories;

public class PostRepository : BaseRepository<Post>, IPostRepository
{
    public PostRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
