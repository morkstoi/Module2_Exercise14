using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductList
{
    public enum CategoryType
    {
        Еда,
        БытоваяТехника
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ImagePath { get; set; }
        public CategoryType ProductCategory { get; set; }
    }
}
