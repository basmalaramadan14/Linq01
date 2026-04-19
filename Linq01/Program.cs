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
            #region Q01
            //var seafoodProducts = Source.ProductList
            //    .Where(p => p.Category == "Seafood");

            //foreach (var product in seafoodProducts)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //}
            #endregion
            #region Q02 
            //        var productNames = Source.ProductList
            //.Select(p => p.ProductName);

            //        foreach (var name in productNames)
            //        {
            //            Console.WriteLine(name);
            //        }
            #endregion
            #region Q03
            var sortedProducts = Source.ProductList
    .OrderBy(p => p.UnitPrice);

            foreach (var p in sortedProducts)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            }
            #endregion

            #region Q04
            #endregion 

            #region Q05
            #endregion
        }

    }
}
