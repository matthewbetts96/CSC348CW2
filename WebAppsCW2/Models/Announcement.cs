using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppsCW2.Models
{
    public class Announcement
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}