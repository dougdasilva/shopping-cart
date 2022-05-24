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
        public List<OrderItem> Products { get; set; } = new List<OrderItem>();

        public ShoppCart()
        {

        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem order in Products)
            {
                sum += order.SubTotal();
            }
            return sum;
        }

    }
}
