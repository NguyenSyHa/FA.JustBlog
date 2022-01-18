using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.JustBlog.Core.Models.Configurations
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Selling",
                    Description = "Online Selling",
                    UrlSlug = "A/B/C.com"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Streaming",
                    Description = "Show case stream",
                    UrlSlug = "A/D/C.com"
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Invididuals",
                    Description = "Private place for everyone in Internet",
                    UrlSlug = "A/B/C.com"
                },
                new Category
                {
                    CategoryId = 4,
                    Name = "Videos",
                    Description = "Place of Videos",
                    UrlSlug = "A/B/D.com"
                },
                new Category
                {
                    CategoryId = 5,
                    Name = "News",
                    Description = "Updating online news",
                    UrlSlug = "A/H/C.com"
                },
                new Category
                {
                    CategoryId = 6,
                    Name = "Meme",
                    Description = "Relaxing",
                    UrlSlug = "B/C/D.com"
                },
                new Category
                {
                    CategoryId = 7,
                    Name = "Short Videos",
                    Description = "Only from 2 to 5 minutes",
                    UrlSlug = "A/B/L.com"
                },
                new Category
                {
                    CategoryId = 8,
                    Name = "Photos Post",
                    Description = "Many wonderful photos",
                    UrlSlug = "V/B/C.com"
                },
                new Category
                {
                    CategoryId = 9,
                    Name = "Selection",
                    Description = "Post for Q/A",
                    UrlSlug = "V/T/C.com"
                },
                new Category
                {
                    CategoryId = 10,
                    Name = "Advertisement",
                    Description = "Introduce for games, products, ...",
                    UrlSlug = "A/Y/D.com"
                }
            );
        }
    }
}
