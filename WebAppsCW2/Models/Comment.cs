using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppsCW2.Models
{
    public class Comment
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "You need to include a comment!")]
        public string CommentBody { get; set; }

        [ScaffoldColumn(false)]
        public ApplicationUser User { get; set; }

        [ScaffoldColumn(false)]
        public virtual Announcement AnnounceID { get; set; }
    }
}