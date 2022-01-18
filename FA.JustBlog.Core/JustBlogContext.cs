using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core
{
    public class JustBlogContext : DbContext
    {
        private readonly string connectionString = @"Server=DESKTOP-J8U25NA\SQL2014;Database=JustBlogDB;User=sa;password=1234567";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PostTagMap>().HasKey(sc => new { sc.PostId, sc.TagId });

            modelBuilder.Entity<PostTagMap>()
                .HasOne<Post>(p => p.Post)
                .WithMany(s => s.PostTagMaps)
                .HasForeignKey(p => p.PostId);

            modelBuilder.Entity<PostTagMap>()
                .HasOne<Tag>(t => t.Tag)
                .WithMany(s => s.PostTagMaps)
                .HasForeignKey(t => t.TagId);

            modelBuilder.ApplyConfiguration(new CategorySeedConfiguration());
            modelBuilder.ApplyConfiguration(new TagSeedConfiguration());
            modelBuilder.ApplyConfiguration(new PostSeedConfiguration());
            modelBuilder.ApplyConfiguration(new PostTagMapSeedConfiguration());
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<PostTagMap> PostTagMaps { get; set; }
    }
}
