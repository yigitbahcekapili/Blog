using AutoMapper;
using Blog.Infrastructure.Data.Entities;
using Blog.Module.ArticleManagement.RequestModel.Article;

namespace Blog.Module.ArticleManagement.AutoMapper
{
    public class ArticleManagementMapperProfile : Profile
    {
        public ArticleManagementMapperProfile()
        {
            CreateMap<AddArticleRequestModel, Article>()
                    .ForMember(x => x.ArticleId, opt => opt.Ignore())
                    .ForMember(x => x.CreatorDate, opt => opt.Ignore())
                    .ForMember(x => x.ModifiedUserDate, opt => opt.Ignore())
                    .ForMember(x => x.IsActive, opt => opt.Ignore());

            CreateMap<UpdateArticleRequestModel, Article>()
                    .ForMember(x => x.ArticleId, opt => opt.Ignore())
                    .ForMember(x => x.CreatorDate, opt => opt.Ignore())
                    .ForMember(x => x.ModifiedUserDate, opt => opt.Ignore());
        }
    }
}
