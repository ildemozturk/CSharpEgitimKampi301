using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}

/*
 * field-variable-property
 * int x; direkt class içindeyse FIELD
 * int x {get; set;} değerleri alırsa PROPERTY
 * metot içinde tanımlanıyorsa  VARIABLE
   void test()
{
int x;
}
 */
