using Blog.Module.ArticleManagement.RequestModel.Article;
using FluentValidation;

namespace Blog.Module.ArticleManagement.Validator.Article
{
    public class UpdateArticleRequestModelValidator : AbstractValidator<UpdateArticleRequestModel>
    {
        public UpdateArticleRequestModelValidator()
        {
            RuleFor(x => x.ArticleId).GreaterThan(0).WithMessage("Makale benzersiz numarası boş olamaz.");
            RuleFor(x => x.Content).NotNull().WithMessage("İçerik bilgisi boş olamaz.");
            RuleFor(x => x.Title).NotNull().WithMessage("Başlık bilgisi boş olamaz.");
            RuleFor(x => x.IsActive).NotNull().WithMessage("Aktiflik bilgisi boş olamaz.");
        }
    }
}
