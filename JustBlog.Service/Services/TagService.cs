using AutoMapper;
using JustBlog.Core.Infrastructures;
using JustBlog.Entity.Entities;
using JustBlog.Model.Common;
using JustBlog.Model.Tag;
using JustBlog.Service.IServices;

namespace JustBlog.Service.Services;

public class TagService : BaseService<Tag, TagCM, TagVM, TagUM>, ITagService
{
    public TagService(UnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {

    }
    public override async Task DeleteAsync(object id)
    {
        IBaseRepository<PostTagMap> postTagRepository = unitOfWork.GetRepository<PostTagMap>();
        IEnumerable<PostTagMap> postTag = await postTagRepository.GetAsync(filter: pt => pt.TagId == (Guid)id);
        unitOfWork.GetRepository<PostTagMap>().DeleteMultiple(postTag);
        await base.DeleteAsync(id);
    }
    public async Task<IEnumerable<Select>> GetToSelectAsync(int? page, int? pageSize)
    {
        return await unitOfWork.TagRepository.GetAsync<Select>(pageSize: pageSize, page: page);
    }
}
