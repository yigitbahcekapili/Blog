using System;

namespace Blog.Infrastructure.Data.Entities
{
    public class EntityBase
    {
        public bool IsActive { get; set; }
        public int CreatorUserId { get; set; }
        public DateTime CreatorDate { get; set; }
        public int? ModifiedUserId { get; set; }
        public DateTime? ModifiedUserDate { get; set; }
    }
}
