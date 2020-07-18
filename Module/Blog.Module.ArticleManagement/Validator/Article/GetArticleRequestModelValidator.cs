using Blog.Module.ArticleManagement.RequestModel.Article;
using FluentValidation;

namespace Blog.Module.ArticleManagement.Validator.Article
{
    public class GetArticleRequestModelValidator : AbstractValidator<GetArticleRequestModel>
    {
        public GetArticleRequestModelValidator()
        {
            RuleFor(x => x.ArticleId).GreaterThan(0).WithMessage("Makale benzersiz numarası boş olamaz.");
        }
    }
}
