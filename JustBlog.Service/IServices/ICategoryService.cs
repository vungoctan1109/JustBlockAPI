using JustBlog.Entity.Entities;
using JustBlog.Model.Category;
using JustBlog.Model.Common;

namespace JustBlog.Service.IServices;

public interface ICategoryService : IBaseService<Category, CategoryCM, CategoryVM, CategoryUM>
{
    Task<IEnumerable<Select>> GetToSelectAsync(int? page, int? pageSize);
}
