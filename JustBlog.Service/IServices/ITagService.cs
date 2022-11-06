using JustBlog.Entity.Entities;
using JustBlog.Model.Common;
using JustBlog.Model.Tag;

namespace JustBlog.Service.IServices;

public interface ITagService : IBaseService<Tag, TagCM, TagVM, TagUM>
{
    Task<IEnumerable<Select>> GetToSelectAsync(int? page, int? pageSize);
}
