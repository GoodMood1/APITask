using System.Data.Entity;

namespace BlogsAPI.Models.Entities
{
    public class BlogAPIDbContext : DbContext
    {
        public BlogAPIDbContext() : base("BlogAPIDb") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Blog> Blogs { get; set; }
    }
}