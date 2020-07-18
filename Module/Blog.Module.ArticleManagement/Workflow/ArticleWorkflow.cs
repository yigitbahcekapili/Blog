using AutoMapper;
using Blog.Infrastructure.Data.Contract;
using Blog.Infrastructure.Data.Entities;
using Blog.Module.ArticleManagement.Contract;
using Blog.Module.ArticleManagement.RequestModel.Article;
using Blog.Module.ArticleManagement.ResponseModel.Article;
using System.Collections.Generic;

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

        #region Get

        public GetArticleResponseModel GetArticle(GetArticleRequestModel requestModel)
        {
            Article article = GetArticleById(requestModel.ArticleId);

            var response = new GetArticleResponseModel()
            {
                Content = article.Content,
                Title = article.Title,
                CreateDate = article.CreatorDate
            };

            return response;
        }

        public ICollection<Article> GetAllArticle()
        {
            return _articleRepository.GetList();
        }

        private Article GetArticleById(int articleId)
        {
            Article article = _articleRepository.GetById(articleId);

            if (article == null)
                throw new System.Exception("Makale bulunamadı..");

            return article;
        }

        #endregion

        #region Add

        public void AddArticle(AddArticleRequestModel requestModel)
        {
            Article article = _mapper.Map<AddArticleRequestModel, Article>(requestModel);

            _articleRepository.Add(article);
        }

        #endregion

        #region Update

        public void UpdateArticle(UpdateArticleRequestModel requestModel)
        {
            Article article = GetArticleById(requestModel.ArticleId);

            article = _mapper.Map(requestModel, article);

            _articleRepository.Update(article);
        }

        #endregion

        #region Delete

        public void DeleteArticle(int id)
        {
            _articleRepository.Delete(id);
        }

        #endregion

    }
}
