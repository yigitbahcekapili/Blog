using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Blog.Infrastructure.Data.Entities
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Article> Article { get; set; }


        public override int SaveChanges()
        {
            SetEntityBaseProperty();

            return base.SaveChanges();
        }

        private void SetEntityBaseProperty()
        {
            var addedEntityBase = ChangeTracker.Entries<EntityBase>().Where(x => x.State == EntityState.Added)
                                                                     .Select(x => x.Entity);

            var modifiedEntityBase = ChangeTracker.Entries<EntityBase>().Where(x => x.State == EntityState.Modified)
                                                                        .Select(x => x.Entity);

            var date = DateTime.UtcNow;

            foreach (var addedEntity in addedEntityBase)
            {
                addedEntity.CreatorDate = date;
                addedEntity.IsActive = true;
            }

            foreach (var modifiedEntity in modifiedEntityBase)
            {
                modifiedEntity.ModifiedUserDate = date;
            }
        }

    }
}
