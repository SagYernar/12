using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager
                  .ConnectionStrings["MyModel"]
                  .ToString();

            MyModel model = new MyModel();

            //TASK 1
            //var orders = model.Orders.Select(p=>p.OrderDate).OrderBy(p=>p.Value).ToList();
            //Console.WriteLine(orders.First());
            //Console.WriteLine(orders.Last());
            //Console.ReadLine();

            //TASK 2
            //var res = model.Orders.Select(p => (p.RequiredDate.Value.Day - p.OrderDate.Value.Day)).OrderBy(p=>p).ToList();
            //Console.WriteLine(res.Last());
            //Console.ReadLine();

            //Task 3
            //var employees = model.Employees.ToList();
            //var postals = model.Employees.Select(p => p.PostalCode);

            //List<int> post = new List<int>();
            //int tmp;
            //foreach(var item in postals)
            //{
            //    if(Int32.TryParse(item, out tmp))
            //    {
            //        post.Add(tmp);
            //    }
            //}

            //foreach(var item in employees)
            //{
            //    foreach (var p in post)
            //    {                    
            //        if (item.PostalCode == p.ToString())
            //        {
            //            Console.WriteLine(item.LastName);
            //        }
            //    }
            //}
            //Console.ReadLine();

            // Task 4
            //var customers = model.Customers.ToList();
            //var countries = model.Customers.Select(p => p.Country).Distinct();
            //int amount;

            //foreach (var item in countries)
            //{
            //    amount = 0;
            //    Console.Write("{0} - ",item);
            //    foreach (var inner in customers)
            //    {
            //        if(inner.Country == item)
            //        {
            //            amount++;
            //        }
            //    }
            //    Console.WriteLine(amount);
            //}
            //Console.ReadLine();

            // Task 5
            //var employees = model.Employees.ToList();
            //var orders = model.Orders.ToList();

            //foreach(var item in employees)
            //{
            //    Console.WriteLine("{0}:",item.EmployeeID);
            //    foreach(var inner in orders)
            //    {
            //        if(item.EmployeeID == inner.EmployeeID)
            //        {
            //            Console.WriteLine(" {0}",inner.OrderID);
            //        }
            //    }
            //}
            //Console.ReadLine();

            // Task 6
            //var expOrders = from orders in (from orderDetails in model.Order_Details.ToList()
            //                                          group orderDetails by orderDetails.OrderID into od
            //                                          select new
            //                                          {
            //                                              OrderId = od.Key,
            //                                              TotalSum = od.Sum(p => (p.Quantity * p.UnitPrice))
            //                                          })
            //                          where orders.TotalSum >= 5000
            //                          select orders;

            //var midOrders = from orders in (from orderDetails in model.Order_Details.ToList()
            //                                   group orderDetails by orderDetails.OrderID into od
            //                                   select new
            //                                   {
            //                                       OrderId = od.Key,
            //                                       TotalSum = od.Sum(p => (p.Quantity * p.UnitPrice))
            //                                   })
            //                   where orders.TotalSum >= 1000 && orders.TotalSum < 5000
            //                   select orders;

            //var cheapOrders = from orders in (from orderDetails in model.Order_Details.ToList()
            //                                     group orderDetails by orderDetails.OrderID into od
            //                                     select new
            //                                     {
            //                                         OrderId = od.Key,
            //                                         TotalSum = od.Sum(p => (p.Quantity * p.UnitPrice))
            //                                     })
            //                     where orders.TotalSum < 1000
            //                     select orders;

            //Console.WriteLine("Orders > 5000$: ");
            //foreach (var item in expOrders)
            //{
            //    Console.WriteLine($"{item.OrderId}-{item.TotalSum}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Orders between 5000$ && 1000$: ");
            //foreach (var item in midOrders)
            //{
            //    Console.WriteLine($"{item.OrderId}-{item.TotalSum}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Orders < 1000$: ");
            //foreach (var item in cheapOrders)
            //{
            //    Console.WriteLine($"{item.OrderId}-{item.TotalSum}");
            //}
            //Console.ReadLine();

            //Task 7
            //var orders = model.Order_Details.ToList();
            //var products = model.Products.ToList();
            //int id = orders[0].OrderID;
            //Console.WriteLine(id);
            //foreach (var item in orders)
            //{
            //    if (item.OrderID != id)
            //    {
            //        id = item.OrderID;
            //        Console.WriteLine("{0}:", id);
            //    }

            //    foreach (var inner in products)
            //    {
            //        if(item.ProductID==inner.ProductID)
            //        Console.WriteLine(" {0}", inner.ProductName);
            //    }
            //}
            //Console.ReadLine();

            //Task 8
            //var orders = model.Orders.OrderBy(p=>p.CustomerID).ToList();
            //string cust = orders[0].CustomerID;
            //Console.WriteLine("{0}:",cust);

            //foreach(var item in orders)
            //{
            //    if(item.CustomerID != cust)
            //    {
            //        cust = item.CustomerID;
            //        Console.WriteLine("{0}:", cust);
            //    }
            //    Console.WriteLine(" {0}", item.EmployeeID);
            //}
            //Console.ReadLine();

            //Task 9
            //var product = model.Products.ToList();
            //var orderdet = model.Order_Details.ToList();
            //var orders = model.Orders.ToList();

            //foreach (var item in product)
            //{
            //    Console.WriteLine("{0}:", item.ProductName);
            //    foreach(var inner in orderdet)
            //    {
            //        if(item.ProductID == inner.ProductID)
            //        {
            //            foreach(var ininer in orders)
            //            {
            //                if(ininer.OrderID == inner.OrderID)
            //                {
            //                    Console.WriteLine(" {0}",ininer.CustomerID);
            //                }
            //            }
            //        }
            //    }
            //}
            //Console.ReadLine();

            //Task 10
            //var sum = from employeeSum in (from employees in (from order in model.Orders.ToList()
            //                                                                join orderDetails in model.Order_Details.ToList()
            //                                                                on order.OrderID equals orderDetails.OrderID
            //                                                                select new
            //                                                                {
            //                                                                    order.EmployeeID,
            //                                                                    Sum = orderDetails.Quantity * orderDetails.UnitPrice
            //                                                                })
            //                                             group employees by employees.EmployeeID into e
            //                                             select new
            //                                             {
            //                                                 EmployeeId = e.Key,
            //                                                 TotalSum = e.Sum(p => p.Sum)
            //                                             })
            //                        join employees in model.Employees
            //                        on employeeSum.EmployeeId equals employees.EmployeeID
            //                        select new { employees.FirstName, employees.LastName, employeeSum.TotalSum };

            //foreach (var item in sum)
            //{
            //    Console.WriteLine($"{item.FirstName} {item.LastName} - {item.TotalSum}");
            //}
            //Console.ReadLine();

            // Task 11
            //var top = (from products in (from orderDetails in (from orderDetails in (from orderDetails in model.Order_Details.ToList()
            //                                                                         select new
            //                                                                         {
            //                                                                             ProductID = orderDetails.ProductID,
            //                                                                             Quantity = orderDetails.Quantity
            //                                                                         })
            //                                                   group orderDetails by orderDetails.ProductID into od
            //                                                   select new
            //                                                   {
            //                                                       ProductId = od.Key,
            //                                                       TotalQuantity = od.Sum(p => p.Quantity)
            //                                                   })
            //                             join products in model.Products
            //                             on orderDetails.ProductId equals products.ProductID
            //                             select new
            //                             {
            //                                 products.ProductName,
            //                                 orderDetails.TotalQuantity
            //                             })
            //           orderby products.TotalQuantity descending
            //           select products).Take(3);

            //foreach (var item in top)
            //{
            //    Console.WriteLine($"{item.ProductName}-{item.TotalQuantity}");
            //}
            //Console.ReadLine();

            // Task 12S
            //var top = (from countries in (from groupedOrders in (from orders in model.Orders.ToList()
            //                                                     select new
            //                                SS                     {
            //                                                         orders.ShipCountry,
            //                                                         orders.OrderID
            //                                                     })
            //                              group groupedOrders by groupedOrders.ShipCountry into g
            //                              select new
            //                              {
            //                                  Country = g.Key,
            //                                  QuantityOfOrders = g.Count()
            //                              })
            //           orderby countries.Country descending
            //           select countries.Country).Take(3);

            //foreach (var item in top)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadLine();
        }
    }
}
