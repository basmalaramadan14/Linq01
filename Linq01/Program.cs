using Linq01.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
   

    class Program
    {

        static void Main(string[] args)
        {
            var seafoodProducts = Source.ProductList
                .Where(p => p.Category == "Seafood");

            foreach (var product in seafoodProducts)
            {
                Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            }
        }
    }
}
