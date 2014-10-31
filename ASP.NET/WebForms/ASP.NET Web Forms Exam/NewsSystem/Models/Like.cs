using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsSystem.Models
{
    public class Like
    {
        public int Id { get; set; }

        public string Value { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }
    }
}
