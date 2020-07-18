using System;

namespace Blog.Module.ArticleManagement.ResponseModel.Article
{
    public class GetArticleResponseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
