using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppsCW2.Models
{
    public class CommentAnnounce
    {
        public virtual Announcement Announce { get; set; }

        public virtual Comment Comment { get; set; }
    }
}