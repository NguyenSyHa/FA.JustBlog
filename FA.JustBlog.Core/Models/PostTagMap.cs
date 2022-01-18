namespace FA.JustBlog.Core.Models
{
    public class PostTagMap
    {
        public string PostId { get; set; }
        public Post Post { get; set; }
        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
