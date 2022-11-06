using JustBlog.Entity.Entities;
using JustBlog.Model.Post;

namespace JustBlog.Service.IServices;

public interface IPostService : IBaseService<Post, PostCM, PostVM, PostUM>
{
    Task<IEnumerable<PostVM>> LatestAsync(int page, int pageSize);
    Task<IEnumerable<PostVM>> MostInterestingAsync(int page, int pageSize);
    Task<IEnumerable<PostVM>> MostViewedAsync(int page, int pageSize);
    Task<IEnumerable<PostVM>> PublishedAsync(int page, int pageSize);
    Task<IEnumerable<PostVM>> UnPublishedAsync(int page, int pageSize);
    Task<IEnumerable<PostVM>> CategoryNameAsync(string name);
}
