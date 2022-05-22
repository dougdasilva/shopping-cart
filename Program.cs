using Shopp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Product productA = new Product(1, "Mouse", 25.99);
            products.Add(productA);
            Product productB = new Product(2, "Teclado", 36.99);
            products.Add(productB);
            Product productC = new Product(3, "Webcam", 89.99);
            products.Add(productC);
            Product productD = new Product(4, "Fone", 121.99);
            products.Add(productD);

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }


        }
    }
}
