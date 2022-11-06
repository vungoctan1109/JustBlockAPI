using AutoMapper;
using JustBlog.Entity.Entities;
using JustBlog.Model.Category;
using JustBlog.Model.Post;
using JustBlog.Model.Tag;

namespace JustBlog.Api
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Category, CategoryVM>()
                .ForMember(dest => dest.PostTitles,
                    opt => opt.MapFrom(src => src.Posts.Select(x => x.Title).ToList())
                ).ForMember(
                    dest => dest.PostIds,
                    opt => opt.MapFrom(src => src.Posts.Select(x => x.Id).ToList())
                ).ReverseMap();

            CreateMap<CategoryCM, Category>().ReverseMap();
            CreateMap<CategoryUM, Category>().ReverseMap();

            CreateMap<PostCM, Post>()
                .ForMember(dest => dest.PostTagMaps,
                    opt => opt.MapFrom(src => src.Tags.Select(x => new PostTagMap { TagId = x }).ToList())
                ).ReverseMap();

            CreateMap<Post, PostVM>()
                .ForMember(dest => dest.Tags,
                    opt => opt.MapFrom(src => src.PostTagMaps.Select(x => x.Tag.Name).ToList())
                ).ReverseMap();

            CreateMap<PostUM, Post>()
                .ForMember(dest => dest.PostTagMaps,
                    opt => opt.MapFrom(src => src.Tags.Select(x => new PostTagMap { TagId = x }).ToList())
                ).ReverseMap();

            CreateMap<TagCM, Tag>().ReverseMap();
            CreateMap<Tag, TagVM>().ReverseMap();
            CreateMap<TagUM, Tag>().ReverseMap();

        }

    }
}