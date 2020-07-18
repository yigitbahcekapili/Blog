using Blog.Module.ArticleManagement.RequestModel.Article;
using Blog.Module.ArticleManagement.ResponseModel.Article;

namespace Blog.Module.ArticleManagement.Contract
{
    public interface IArticleContract
    {
        GetArticleResponseModel GetArticle(GetArticleRequestModel requestModel);
        void AddArticle(AddArticleRequestModel requestModel);
        void UpdateArticle(UpdateArticleRequestModel requestModel);
        void DeleteArticle(int id);
    }
}
