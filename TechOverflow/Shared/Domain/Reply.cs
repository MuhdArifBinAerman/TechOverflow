using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechOverflow.Shared.Domain
{
    public class Reply:PostBody
    {
        public int PostID { get; set; }
        public virtual Post Post { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }

    }
}
