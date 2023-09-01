using GOREV_9.Models.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Reflection.Metadata;

namespace GOREV_9.Models.Data
{
    public class Gorev9DbContext:DbContext
    {
        public Gorev9DbContext(DbContextOptions<Gorev9DbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryPost> CategoryPosts { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostComment> PostComments { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<Setting> Settings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Post>()
                .HasData(
                new Post() { Id=1, Url="www.tugcebolat.com", Title="A"},
                
                new Post() { Id=2, Url="www.bolat.com/blog",Title="B"}
                );
            modelBuilder.Entity<PostImage>()
                .HasData(
                new PostImage() { Id = 1,PostId=1, Url="www.com"},
                new PostImage() { Id = 2,PostId=1, Url="www.comm." },
                new PostImage() { Id = 3,PostId=2, Url="olurmuboyle.com" }
                );
        }
    }
  


}
