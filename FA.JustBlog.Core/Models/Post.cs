using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FA.JustBlog.Core.Models
{
    public class Post
    {
        [Key]
        public string PostId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; }

        [Display(Name = "Short Description")]
        [StringLength(255)]
        public string ShortDescription { get; set; }

        [Display(Name = "Post Content")]
        [StringLength(255)]
        public string PostContent { get; set; }

        [StringLength(255)]
        public string UrlSlug { get; set; }

        public DateTime? Published { get; set; }

        [Display(Name = "Posted On")]
        [StringLength(200)]
        public string PostedOn { get; set; }

        public int Count { get; set; }

        public DateTime? Modified { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public IList<PostTagMap> PostTagMaps { get; set; }
    }
}