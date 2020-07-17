using Blog.Infrastructure.Data.Contract;
using Blog.Infrastructure.Data.Entities;

namespace Blog.Infrastructure.Data.Implementation
{
    public class ArticleRepository : GenericRepository<Article>, IArticleRepository
    {
        public ArticleRepository(BlogDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
