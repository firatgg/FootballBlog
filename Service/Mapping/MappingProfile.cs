using AutoMapper;
using DataAccess.Identity;
using Entity.Entities;
using FootBallBlog.ViewModels;

namespace Service.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Article, ArticleViewModel>().ReverseMap();
            CreateMap<Category, CategoryViewModel>().ReverseMap();
            CreateMap<Comment, CommentViewModel>().ReverseMap();
            CreateMap<AppUser, UserViewModel>().ReverseMap();
            CreateMap<AppUser, LoginViewModel>().ReverseMap();
            CreateMap<AppRole, RoleViewModel>().ReverseMap();

        }
    }
}
