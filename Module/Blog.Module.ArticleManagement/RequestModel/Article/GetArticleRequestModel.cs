using Blog.Module.ArticleManagement.Validator.Article;
using FluentValidation.Attributes;

namespace Blog.Module.ArticleManagement.RequestModel.Article
{
    [Validator(typeof(GetArticleRequestModelValidator))]
    public class GetArticleRequestModel
    {
        public int ArticleId { get; set; }
    }
}
