using Blog.Module.ArticleManagement.Validator.Article;
using FluentValidation.Attributes;

namespace Blog.Module.ArticleManagement.RequestModel.Article
{
    [Validator(typeof(UpdateArticleRequestModelValidator))]
    public class UpdateArticleRequestModel
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }
    }
}
