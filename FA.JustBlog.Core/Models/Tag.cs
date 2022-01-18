using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FA.JustBlog.Core.Models
{
    public class Tag
    {
        [Key]
        public string TagId { get; set; }

        [Required(ErrorMessage = "Tag Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(255)]
        public string UrlSlug { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int Count { get; set; }

        public IList<PostTagMap> PostTagMaps { get; set; }
    }
}
