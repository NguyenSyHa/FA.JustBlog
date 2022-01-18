using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FA.JustBlog.Core.Models.Configurations
{
    public class PostTagMapSeedConfiguration : IEntityTypeConfiguration<PostTagMap>
    {
        public void Configure(EntityTypeBuilder<PostTagMap> builder)
        {
            builder.HasData(
                new PostTagMap
                {
                    PostId = "Post01",
                    TagId = "Tag1"
                },
                new PostTagMap
                {
                    PostId = "Post01",
                    TagId = "Tag2"
                },
                new PostTagMap
                {
                    PostId = "Post02",
                    TagId = "Tag2"
                },
                new PostTagMap
                {
                    PostId = "Post02",
                    TagId = "Tag4"
                },
                new PostTagMap
                {
                    PostId = "Post03",
                    TagId = "Tag4"
                },
                new PostTagMap
                {
                    PostId = "Post03",
                    TagId = "Tag6"
                },
                new PostTagMap
                {
                    PostId = "Post03",
                    TagId = "Tag8"
                },
                new PostTagMap
                {
                    PostId = "Post04",
                    TagId = "Tag4"
                },
                new PostTagMap
                {
                    PostId = "Post04",
                    TagId = "Tag8"
                },
                new PostTagMap
                {
                    PostId = "Post05",
                    TagId = "Tag3"
                },
                new PostTagMap
                {
                    PostId = "Post05",
                    TagId = "Tag5"
                },
                new PostTagMap
                {
                    PostId = "Post06",
                    TagId = "Tag5"
                },
                new PostTagMap
                {
                    PostId = "Post07",
                    TagId = "Tag5"
                },
                new PostTagMap
                {
                    PostId = "Post08",
                    TagId = "Tag7"
                },
                new PostTagMap
                {
                    PostId = "Post08",
                    TagId = "Tag8"
                },
                new PostTagMap
                {
                    PostId = "Post09",
                    TagId = "Tag8"
                },
                new PostTagMap
                {
                    PostId = "Post10",
                    TagId = "Tag10"
                }
            );
        }
    }
}
