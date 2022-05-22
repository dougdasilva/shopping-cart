using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopp.Entities
{
    internal class ShoppCart
    {
        public int Quantity { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public ShoppCart()
        {

        }

        public void Total()
        {

        }

    }
}
