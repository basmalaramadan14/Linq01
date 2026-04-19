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
            //        var sortedProducts = Source.ProductList
            //.OrderBy(p => p.UnitPrice);

            //        foreach (var p in sortedProducts)
            //        {
            //            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //        }
            #endregion

            #region Q04
            //        var filteredProducts = Source.ProductList
            //.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //        foreach (var p in filteredProducts)
            //        {
            //            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //        }
            #endregion


            #region Q05
            //        var result = Source.ProductList
            //.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //        foreach (var p in result)
            //        {
            //            Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            //        }
            #endregion

            #region Q06 
            var result = Source.ProductList
    .Select(p => new
    {
        Name = p.ProductName,
        Price = p.UnitPrice,
        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
    });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
            }
            #endregion

            #region Q07
            #endregion

            #region Q08
            #endregion

            #region Q09
            #endregion

            #region Q10
            #endregion

            #region Q11
            #endregion

            #region Q12
            #endregion

            #region Q13
            #endregion
        }

    }
}
