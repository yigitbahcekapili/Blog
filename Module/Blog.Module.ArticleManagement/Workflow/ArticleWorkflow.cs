using AutoMapper;
using Blog.Infrastructure.Data.Contract;
using Blog.Infrastructure.Data.Entities;
using Blog.Module.ArticleManagement.Contract;
using Blog.Module.ArticleManagement.RequestModel.Article;
using Blog.Module.ArticleManagement.ResponseModel.Article;
using Blog.Module.ArticleManagement.Validator.Article;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Module.ArticleManagement.Workflow
{
    public class ArticleWorkflow : IArticleContract
    {
        private readonly IMapper _mapper;
        private readonly IArticleRepository _articleRepository;

        public ArticleWorkflow(IArticleRepository articleRepository,
                               IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        #region Get Article

        public GetArticleResponseModel GetArticle(GetArticleRequestModel requestModel)
        {
            Article article = GetArticleValidation(requestModel);

            var response = new GetArticleResponseModel()
            {
                Content = article.Content,
                Title = article.Title,
                CreateDate = article.CreatorDate
            };

            return response;
        }

        private Article GetArticleValidation(GetArticleRequestModel requestModel)
        {
            Article article = _articleRepository.GetById(requestModel.ArticleId);

            if (article == null)
                throw new System.Exception("Makale bulunamadı..");

            return article;
        }

        #endregion

        public void AddArticle(AddArticleRequestModel requestModel)
        {
            Article article = _mapper.Map<AddArticleRequestModel, Article>(requestModel);

            _articleRepository.Add(article);
        }

    }
}
