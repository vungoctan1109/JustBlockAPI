using AutoMapper;
using JustBlog.Core.Infrastructures;
using JustBlog.Entity.Entities;
using JustBlog.Model.Category;
using JustBlog.Model.Common;
using JustBlog.Service.IServices;

namespace JustBlog.Service.Services;

public class CategoryService : BaseService<Category, CategoryCM, CategoryVM, CategoryUM>, ICategoryService
{
    public CategoryService(UnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {

    }
    public override async Task DeleteAsync(object id)
    {
        if (await unitOfWork.PostRepository.AnyAsync(c => c.CategoryId == (Guid)id))
        {
            throw new ArgumentException("Category is using");
        }
        await base.DeleteAsync(id);
    }

    public async Task<IEnumerable<Select>> GetToSelectAsync(int? page, int? pageSize)
    {
        return await unitOfWork.CategoryRepository.GetAsync<Select>(pageSize: pageSize, page: page);
    }
}
