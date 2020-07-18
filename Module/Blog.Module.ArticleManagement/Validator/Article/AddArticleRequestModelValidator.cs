using Blog.Module.ArticleManagement.RequestModel.Article;
using FluentValidation;

namespace Blog.Module.ArticleManagement.Validator.Article
{
    public class AddArticleRequestModelValidator : AbstractValidator<AddArticleRequestModel>
    {
        public AddArticleRequestModelValidator()
        {
            RuleFor(x => x.Title).NotNull().WithMessage("Başlık alanı boş olamaz");
            RuleFor(x => x.Content).NotNull().WithMessage("İçerik alanı boş olamaz");
        }
    }
}
