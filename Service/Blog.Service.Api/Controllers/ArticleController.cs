using Blog.Infrastructure.Data.Entities;
using Blog.Module.ArticleManagement.Contract;
using Blog.Module.ArticleManagement.RequestModel.Article;
using Blog.Module.ArticleManagement.ResponseModel.Article;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Service.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleContract _articleContrat;

        public ArticleController(IArticleContract articleContract)
        {
            _articleContrat = articleContract;
        }

        [HttpGet("GetArticle")]
        public GetArticleResponseModel GetArticle([FromBody]GetArticleRequestModel request)
        {
            return _articleContrat.GetArticle(request);
        }

        [HttpPost("AddArticle")]
        public void AddArticle([FromBody]AddArticleRequestModel request)
        {
            _articleContrat.AddArticle(request);
        }

        [HttpPut("UpdateArticle")]
        public void UpdateArticle([FromBody]UpdateArticleRequestModel request)
        {
            _articleContrat.UpdateArticle(request);
        }

    }
}