using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechOverflow.Shared.Domain
{
    public class ModPost:PostBody
    {
        public int ModID { get; set; }
        public virtual Staff Staff { get; set; }
        public int PostID { get; set; }
        public virtual Post Post { get; set; }
    }

}
