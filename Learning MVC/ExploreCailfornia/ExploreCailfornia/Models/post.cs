using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCailfornia.Models
{
    public class Post
    {
        [Display(Name = "Post Title")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5,
          ErrorMessage = "Title must be between 5 and 100 characters long")]
        public string Title { get; set; }
        public string Author { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5,
          ErrorMessage = "blog posts must be atleast 100 characters long")]
        [DataType(DataType.MultilineText)]
        public string Body{ get; set; } 
        public DateTime Posted { get; set; }


    }
}
