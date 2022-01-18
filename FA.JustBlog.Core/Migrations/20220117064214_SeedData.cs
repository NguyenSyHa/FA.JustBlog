using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FA.JustBlog.Core.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "Online Selling", "Selling", "A/B/C.com" },
                    { 9, "Post for Q/A", "Selection", "V/T/C.com" },
                    { 8, "Many wonderful photos", "Photos Post", "V/B/C.com" },
                    { 7, "Only from 2 to 5 minutes", "Short Videos", "A/B/L.com" },
                    { 6, "Relaxing", "Meme", "B/C/D.com" },
                    { 10, "Introduce for games, products, ...", "Advertisement", "A/Y/D.com" },
                    { 4, "Place of Videos", "Videos", "A/B/D.com" },
                    { 3, "Private place for everyone in Internet", "Invididuals", "A/B/C.com" },
                    { 2, "Show case stream", "Streaming", "A/D/C.com" },
                    { 5, "Updating online news", "News", "A/H/C.com" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Count", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { "Tag9", 100, "Tag for Selection", "Tag 9", "A/O/Z.com" },
                    { "Tag1", 100, "Tag for Selling", "Tag 1", "X/Y/Z.com" },
                    { "Tag2", 100, "Tag for Streaming", "Tag 2", "X/T/Z.com" },
                    { "Tag3", 100, "Tag for Invididuals", "Tag 3", "A/A/Z.com" },
                    { "Tag4", 100, "Tag for Videos", "Tag 4", "X/X/T.com" },
                    { "Tag5", 100, "Tag for News", "Tag 5", "X/V/A.com" },
                    { "Tag6", 100, "Tag for Meme", "Tag 6", "V/U/Z.com" },
                    { "Tag7", 100, "Tag for Short Videos", "Tag 7", "X/D/A.com" },
                    { "Tag8", 100, "Tag for Photos Post", "Tag 8", "B/A/Z.com" },
                    { "Tag10", 100, "Tag for Advertisement", "Tag 10", "U/Y/R.com" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "CategoryId", "Count", "Modified", "PostContent", "PostedOn", "Published", "ShortDescription", "Title", "UrlSlug" },
                values: new object[,]
                {
                    { "Post01", 1, 0, null, "Hàng uy tín chất lượng cao", "Nhóm bán hàng quần áo", new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quần Áo nhập lậu từ Trung Quốc", "Bán Quần Áo", "M/N/O.com" },
                    { "Post02", 1, 0, new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hàng uy tín chất lượng cao", "Fanpage bán nhà", new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhà nhập lậu từ Campuchia", "Bán nhà", "M/A/I.com" },
                    { "Post03", 2, 0, null, "Full Livestream 10/1/2022.", "Kênh youtube nào đó", new DateTime(2022, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nơi chia sẻ, kể khổ", "Streaming hôm qua ....", "Y/T/O.com" },
                    { "Post04", 2, 0, null, "No Content", "Kênh nimo nào đó", null, "Giao lưu đấu trường máy tính", "Stream hôm qua", "A/I/O.com" },
                    { "Post05", 3, 0, null, "Snvv", "Trang cá nhân của anh ấy", new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hôm nay là ngày sinh nhật của anh ấy", "BirthDate", "S/O/A.com" },
                    { "Post06", 4, 0, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Khởi đầu ở Mu với cú hat trick siêu hạng", "Youtube", new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhìn lại sự nghiệp của Rooney ở MU", "Rooney's Timeline", "D/Q/O.com" },
                    { "Post07", 5, 0, null, "Hà Nội dẫn đầu với ....", "Vnexpress.net", new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ngày nay ghi nhân gần 3000 người nhiễm", "Thông tin dịch bệnh 16/01/2022", "P/W/A.com" },
                    { "Post08", 7, 0, null, "Câu chuyện làm xong bài báo cáo trong 1 ngày", "Kho lưu trữ tin", null, "Điều nổi bật", "Tập tin của tôi", "M/A/T.com" },
                    { "Post09", 8, 0, null, "Tôi đến hạ long và ăn cơm bình dân ở đó mất 80k", "Trang cá nhân nào đó", new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hạ Vọng thật đẹp", "Ảnh đi du lịch", "T/A/R.com" },
                    { "Post10", 10, 0, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ra mắt bản mới", "Nhóm bán hàng quần áo", new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game thể thao top trên thế giới", "Game PES", "K/N/I.com" }
                });

            migrationBuilder.InsertData(
                table: "PostTagMaps",
                columns: new[] { "PostId", "TagId" },
                values: new object[,]
                {
                    { "Post01", "Tag1" },
                    { "Post08", "Tag8" },
                    { "Post08", "Tag7" },
                    { "Post07", "Tag5" },
                    { "Post06", "Tag5" },
                    { "Post05", "Tag5" },
                    { "Post05", "Tag3" },
                    { "Post09", "Tag8" },
                    { "Post04", "Tag8" },
                    { "Post03", "Tag8" },
                    { "Post03", "Tag6" },
                    { "Post03", "Tag4" },
                    { "Post02", "Tag4" },
                    { "Post02", "Tag2" },
                    { "Post01", "Tag2" },
                    { "Post04", "Tag4" },
                    { "Post10", "Tag10" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post01", "Tag1" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post01", "Tag2" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post02", "Tag2" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post02", "Tag4" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post03", "Tag4" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post03", "Tag6" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post03", "Tag8" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post04", "Tag4" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post04", "Tag8" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post05", "Tag3" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post05", "Tag5" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post06", "Tag5" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post07", "Tag5" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post08", "Tag7" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post08", "Tag8" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post09", "Tag8" });

            migrationBuilder.DeleteData(
                table: "PostTagMaps",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { "Post10", "Tag10" });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: "Tag9");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post01");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post02");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post03");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post04");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post05");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post06");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post07");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post08");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post09");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "PostId",
                keyValue: "Post10");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: "Tag1");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: "Tag10");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: "Tag2");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: "Tag3");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: "Tag4");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: "Tag5");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: "Tag6");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: "Tag7");

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: "Tag8");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10);
        }
    }
}
