using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechOverflow.Shared.Domain
{
    public abstract class Person
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String Name { get; set; }
        public int ContactNo { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public DateTime DoB { get; set; }
        public String Gender { get; set; }
    }
}
