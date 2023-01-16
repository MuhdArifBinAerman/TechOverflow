using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechOverflow.Shared.Domain
{
    public class Product 
    {
        public int Id { get; set; }
        public String PName { get; set; }
        public String PRetailPrice { get; set; }
        public String PBrand { get; set; }
        public String PDescription { get; set; }
        public int CatID { get; set; }
        public virtual Category Category{get;set;}
    }
}
