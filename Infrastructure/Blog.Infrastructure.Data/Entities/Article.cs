namespace Blog.Infrastructure.Data.Entities
{
    public class Article : EntityBase
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

    }
}