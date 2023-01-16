using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechOverflow.Shared.Domain
{
    public class Post:PostBody
    {
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int PostID { get; set; }
        public virtual User User { get; set; }
    }
}
