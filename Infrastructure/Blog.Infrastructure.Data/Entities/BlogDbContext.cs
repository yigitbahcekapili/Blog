using Microsoft.EntityFrameworkCore;

namespace Blog.Infrastructure.Data.Entities
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }
    }
}
