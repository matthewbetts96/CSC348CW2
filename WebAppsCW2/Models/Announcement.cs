using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAppsCW2.Models
{
    public class Announcement
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [ScaffoldColumn(false)]
        public string Title { get; set; }

        [ScaffoldColumn(false)]
        public string Body { get; set; }

        [ScaffoldColumn(false)]
        public IEnumerable<Comment> Comments { get; set; }
    }
}