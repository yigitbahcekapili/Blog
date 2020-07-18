using Blog.Infrastructure.Data.Entities;
using Blog.Module.ArticleManagement.RequestModel.Article;
using Blog.Module.ArticleManagement.ResponseModel.Article;
using System.Collections.Generic;

namespace Blog.Module.ArticleManagement.Contract
{
    public interface IArticleContract
    {
        GetArticleResponseModel GetArticle(GetArticleRequestModel requestModel);
        void AddArticle(AddArticleRequestModel requestModel);
    }
}
