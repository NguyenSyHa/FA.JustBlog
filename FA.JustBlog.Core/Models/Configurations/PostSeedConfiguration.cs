using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FA.JustBlog.Core.Models.Configurations
{
    public class PostSeedConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(
                new Post
                {
                    PostId = "Post01",
                    Title = "Bán Quần Áo",
                    ShortDescription = "Quần Áo nhập lậu từ Trung Quốc",
                    PostContent = "Hàng uy tín chất lượng cao",
                    UrlSlug = "M/N/O.com",
                    Published = new DateTime(2021, 10, 28),
                    PostedOn = "Nhóm bán hàng quần áo",
                    CategoryId = 1
                },
                new Post
                {
                    PostId = "Post02",
                    Title = "Bán nhà",
                    ShortDescription = "Nhà nhập lậu từ Campuchia",
                    PostContent = "Hàng uy tín chất lượng cao",
                    UrlSlug = "M/A/I.com",
                    Published = new DateTime(2021, 11, 28),
                    PostedOn = "Fanpage bán nhà",
                    Modified = new DateTime(2021, 11, 29),
                    CategoryId = 1
                },
                new Post
                {
                    PostId = "Post03",
                    Title = "Streaming hôm qua ....",
                    ShortDescription = "Nơi chia sẻ, kể khổ",
                    PostContent = "Full Livestream 10/1/2022.",
                    UrlSlug = "Y/T/O.com",
                    Published = new DateTime(2022, 1, 10),
                    PostedOn = "Kênh youtube nào đó",
                    CategoryId = 2
                },
                new Post
                {
                    PostId = "Post04",
                    Title = "Stream hôm qua",
                    ShortDescription = "Giao lưu đấu trường máy tính",
                    PostContent = "No Content",
                    UrlSlug = "A/I/O.com",
                    PostedOn = "Kênh nimo nào đó",
                    CategoryId = 2
                },
                new Post
                {
                    PostId = "Post05",
                    Title = "BirthDate",
                    ShortDescription = "Hôm nay là ngày sinh nhật của anh ấy",
                    PostContent = "Snvv",
                    UrlSlug = "S/O/A.com",
                    Published = new DateTime(2021, 10, 21),
                    PostedOn = "Trang cá nhân của anh ấy",
                    CategoryId = 3
                },
                new Post
                {
                    PostId = "Post06",
                    Title = "Rooney's Timeline",
                    ShortDescription = "Nhìn lại sự nghiệp của Rooney ở MU",
                    PostContent = "Khởi đầu ở Mu với cú hat trick siêu hạng",
                    UrlSlug = "D/Q/O.com",
                    Published = new DateTime(2021, 08, 28),
                    PostedOn = "Youtube",
                    Modified = new DateTime(2021, 10, 23),
                    CategoryId = 4
                },
                new Post
                {
                    PostId = "Post07",
                    Title = "Thông tin dịch bệnh 16/01/2022",
                    ShortDescription = "Ngày nay ghi nhân gần 3000 người nhiễm",
                    PostContent = "Hà Nội dẫn đầu với ....",
                    UrlSlug = "P/W/A.com",
                    Published = new DateTime(2022, 1, 16),
                    PostedOn = "Vnexpress.net",
                    CategoryId = 5
                },
                new Post
                {
                    PostId = "Post08",
                    Title = "Tập tin của tôi",
                    ShortDescription = "Điều nổi bật",
                    PostContent = "Câu chuyện làm xong bài báo cáo trong 1 ngày",
                    UrlSlug = "M/A/T.com",
                    PostedOn = "Kho lưu trữ tin",
                    CategoryId = 7
                },
                new Post
                {
                    PostId = "Post09",
                    Title = "Ảnh đi du lịch",
                    ShortDescription = "Hạ Vọng thật đẹp",
                    PostContent = "Tôi đến hạ long và ăn cơm bình dân ở đó mất 80k",
                    UrlSlug = "T/A/R.com",
                    Published = new DateTime(2021, 06, 28),
                    PostedOn = "Trang cá nhân nào đó",
                    CategoryId = 8
                },
                new Post
                {
                    PostId = "Post10",
                    Title = "Game PES",
                    ShortDescription = "Game thể thao top trên thế giới",
                    PostContent = "Ra mắt bản mới",
                    UrlSlug = "K/N/I.com",
                    Published = new DateTime(2021, 10, 18),
                    PostedOn = "Nhóm bán hàng quần áo",
                    Modified = new DateTime(2021, 10, 28),
                    CategoryId = 10
                }
            );
        }
    }
}
