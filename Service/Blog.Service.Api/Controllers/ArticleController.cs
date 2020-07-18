using Blog.Infrastructure.Data.Entities;
using Blog.Module.ArticleManagement.Contract;
using Blog.Module.ArticleManagement.RequestModel.Article;
using Blog.Module.ArticleManagement.ResponseModel.Article;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Blog.Service.Api.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleContract _articleContrat;

        public ArticleController(IArticleContract articleContract)
        {
            _articleContrat = articleContract;
        }

        [HttpGet]
        public GetArticleResponseModel GetArticle([FromBody]GetArticleRequestModel request)
        {
            return _articleContrat.GetArticle(request);
        }

        [HttpGet]
        public ICollection<Article> GetAllArticle()
        {
            return _articleContrat.GetAllArticle();
        }

        [HttpPost]
        public void AddArticle([FromBody]AddArticleRequestModel request)
        {
            _articleContrat.AddArticle(request);
        }

        [HttpPut]
        public void UpdateArticle([FromBody]UpdateArticleRequestModel request)
        {
            _articleContrat.UpdateArticle(request);
        }

        [HttpDelete]
        public void DeleteArticle([FromBody]int id)
        {
            _articleContrat.DeleteArticle(id);
        }

    }
}