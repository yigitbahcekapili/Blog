using Blog.Module.ArticleManagement.Validator.Article;
using FluentValidation.Attributes;

namespace Blog.Module.ArticleManagement.RequestModel.Article
{
    [Validator(typeof(AddArticleRequestModelValidator))]
    public class AddArticleRequestModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
