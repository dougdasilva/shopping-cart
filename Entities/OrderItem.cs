using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopp.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }

        public Product Product { get; set; }

        public double SubTotal()
        {
            return Quantity * Product.Price;
        }
    }
}
