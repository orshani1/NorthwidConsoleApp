using NorthwidConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class HW
{
    static void Main()
    {
        var DB = new NorthwindContext().Products;
        #region Quest1
        //var qur1 = DB.Select(c => new { c.ProductName, c.QuantityPerUnit });
        //foreach (var item in qur1)
        //{
        //    Console.WriteLine(item);
        //} 
        #endregion
        #region Quest2
        //var ques2 = DB.Where(c => c.Discontinued == false
        //).Select(c => new { c.ProductId, c.ProductName }).OrderBy(c=>c.ProductName);
        //foreach (var product in ques2)
        //{
        //    Console.WriteLine(product);
        //} 
        #endregion
        #region Quest3
        //var query = DB.
        //    Where(c => c.Discontinued == true).
        //    Select(c => new {c.ProductId,c.ProductName}).
        //    OrderBy(c=>c.ProductId);
        #endregion
        #region Quest4
        //var qury = DB
        //    .Select(p => new { p.ProductName, p.UnitPrice })
        //    .OrderByDescending(p=> p.UnitPrice);
        //foreach (var product in qury)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion
        #region Quest5
        //var query = DB.
        //    Where(p => p.UnitPrice < 20).
        //    Where(p => p.Discontinued == false).
        //    Select(p => new { p.ProductId, p.ProductName, p.UnitPrice }).
        //    OrderByDescending(p=> p.UnitPrice);
        //foreach (var product in query)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion
        #region Quest6
        //var query = DB.
        //    Where(p=> p.UnitPrice <= 25 && p.UnitPrice >= 15).
        //    Select(p=> new {p.ProductId,p.ProductName,p.UnitPrice }).
        //    OrderByDescending(p=> p.UnitPrice);
        //foreach (var product in query)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion
        #region Quest7
        //var query = DB.
        //    Where(p=> p.UnitPrice > DB.Select(s=> s.UnitPrice).Average()).
        //    Select(p => new { p.ProductName,p.UnitPrice }).
        //    OrderByDescending(p=> p.UnitPrice);
        //foreach (var product in query)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion
        #region Quest8
        //var query = DB.Take(10).
        //    Where(s=>  DB.Where(s.UnitPrice >= ).
        //    Select(p=> p.UnitPrice));
        #endregion
        #region Quest9
        //var query = DB.Select(p => p.ProductName);
        //foreach (var product in query)
        //{
        //    Console.WriteLine(product.Count());
        //}
        #endregion
        #region Quest10
        //var query = DB.
        //    Where(p => p.UnitsInStock < p.UnitsOnOrder).
        //    Select(p => new { p.ProductName, p.UnitsOnOrder, p.UnitsInStock });
        //foreach (var product in query)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion
    }
}