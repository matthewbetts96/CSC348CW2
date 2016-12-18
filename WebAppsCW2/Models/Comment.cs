﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppsCW2.Models
{
    public class Comment
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "You need to include a comment!")]
        public string CommentBody { get; set; } 

        public ApplicationUser User { get; set; }

        public virtual Announcement AnnounceID { get; set; }
    }
}