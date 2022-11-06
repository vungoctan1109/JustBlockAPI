using AutoMapper;
using JustBlog.Core.Infrastructures;
using JustBlog.Entity.Entities;
using JustBlog.Model.Post;
using JustBlog.Service.IServices;

namespace JustBlog.Service.Services;

public class PostService : BaseService<Post, PostCM, PostVM, PostUM>, IPostService
{

    public PostService(UnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
    }

    public async Task<IEnumerable<PostVM>> CategoryNameAsync(string name)
    {
        return await unitOfWork.PostRepository.GetAsync<PostVM>(filter: c => c.Category.Name == name);
    }

    public override async Task DeleteAsync(object id)
    {
        IBaseRepository<PostTagMap> postTagRepository = unitOfWork.GetRepository<PostTagMap>();
        IEnumerable<PostTagMap> postTag = await postTagRepository.GetAsync(filter: pt => pt.PostId == (Guid)id);
        unitOfWork.GetRepository<PostTagMap>().DeleteMultiple(postTag);
        await base.DeleteAsync(id);
    }

    public async Task<IEnumerable<PostVM>> LatestAsync(int page, int pageSize)
    {
        return await unitOfWork.PostRepository.GetAsync<PostVM>(orderBy: p => p.OrderBy(p => p.PostedOn), page: page, pageSize: pageSize);
    }

    public async Task<IEnumerable<PostVM>> MostInterestingAsync(int page, int pageSize)
    {
        return await unitOfWork.PostRepository.GetAsync<PostVM>(orderBy: p => p.OrderBy(p => p.TotalRate), page: page, pageSize: pageSize);
    }

    public async Task<IEnumerable<PostVM>> MostViewedAsync(int page, int pageSize)
    {
        return await unitOfWork.PostRepository.GetAsync<PostVM>(orderBy: p => p.OrderBy(p => p.ViewCount), page: page, pageSize: pageSize);

    }

    public async Task<IEnumerable<PostVM>> PublishedAsync(int page, int pageSize)
    {
        return await unitOfWork.PostRepository.GetAsync<PostVM>(filter: c => c.Published == true, page: page, pageSize: pageSize);
    }

    public async Task<IEnumerable<PostVM>> UnPublishedAsync(int page, int pageSize)
    {
        return await unitOfWork.PostRepository.GetAsync<PostVM>(filter: c => c.Published == false, page: page, pageSize: pageSize);
    }

    public override async Task UpdateAsync(PostUM entityToUpdate)
    {
        IBaseRepository<PostTagMap> postTagRepository = unitOfWork.GetRepository<PostTagMap>();
        IEnumerable<PostTagMap> postTag = await postTagRepository.GetAsync(filter: pt => pt.PostId == entityToUpdate.Id);
        unitOfWork.GetRepository<PostTagMap>().DeleteMultiple(postTag);
        await base.UpdateAsync(entityToUpdate);
    }
}
