using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.EntityLayer.Entities
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductCity { get; set; }
        public string ProductType { get; set; }
        public double ProductPrice { get; set; }
        public int ProductSize { get; set; }
        public string ProductImage { get; set; }
    }
}
