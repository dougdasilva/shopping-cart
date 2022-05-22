using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopp.Entities
{
    internal class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock{ get; set; }

        public Product()
        {

        }

        public Product(int productID, string name, double price)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Stock = 10;
        }

        public int QtdStock(int qtd)
        {
            return 10 - qtd;
        }

        public override string ToString()
        {
            return "ID: " + ProductID 
                          + ", Name: " + Name 
                          + ", Price: " 
                          + Price.ToString("F2", CultureInfo.InvariantCulture)
                          + ", Stock: " + Stock;
        }
    }
}
