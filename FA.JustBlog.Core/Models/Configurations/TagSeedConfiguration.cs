using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.JustBlog.Core.Models.Configurations
{
    public class TagSeedConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasData(
                new Tag
                {
                    TagId = "Tag1",
                    Name = "Tag 1",
                    Description = "Tag for Selling",
                    UrlSlug = "X/Y/Z.com",
                    Count = 100
                },
                new Tag
                {
                    TagId = "Tag2",
                    Name = "Tag 2",
                    Description = "Tag for Streaming",
                    UrlSlug = "X/T/Z.com",
                    Count = 100
                },
                new Tag
                {
                    TagId = "Tag3",
                    Name = "Tag 3",
                    Description = "Tag for Invididuals",
                    UrlSlug = "A/A/Z.com",
                    Count = 100
                },
                new Tag
                {
                    TagId = "Tag4",
                    Name = "Tag 4",
                    Description = "Tag for Videos",
                    UrlSlug = "X/X/T.com",
                    Count = 100
                },
                new Tag
                {
                    TagId = "Tag5",
                    Name = "Tag 5",
                    Description = "Tag for News",
                    UrlSlug = "X/V/A.com",
                    Count = 100
                },
                new Tag
                {
                    TagId = "Tag6",
                    Name = "Tag 6",
                    Description = "Tag for Meme",
                    UrlSlug = "V/U/Z.com",
                    Count = 100
                },
                new Tag
                {
                    TagId = "Tag7",
                    Name = "Tag 7",
                    Description = "Tag for Short Videos",
                    UrlSlug = "X/D/A.com",
                    Count = 100
                },
                new Tag
                {
                    TagId = "Tag8",
                    Name = "Tag 8",
                    Description = "Tag for Photos Post",
                    UrlSlug = "B/A/Z.com",
                    Count = 100
                },
                new Tag
                {
                    TagId = "Tag9",
                    Name = "Tag 9",
                    Description = "Tag for Selection",
                    UrlSlug = "A/O/Z.com",
                    Count = 100
                },
                new Tag
                {
                    TagId = "Tag10",
                    Name = "Tag 10",
                    Description = "Tag for Advertisement",
                    UrlSlug = "U/Y/R.com",
                    Count = 100
                }
            );
        }
    }
}
