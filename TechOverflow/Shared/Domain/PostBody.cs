using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechOverflow.Shared.Domain
{
    public abstract class PostBody
    {
        public int Id { get; set; }
        public DateTime DateTimeMade { get; set; }
        public String Text { get; set; }

    }
}
