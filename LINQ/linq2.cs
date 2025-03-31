using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQAssignments
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
   }

   public class Order
    {
       public int OrderId { get; set; }
       public int CustomerId { get; set; }
       public DateTime OrderDate { get; set; }
    }

    public class Assignment7
    {
       public static void Main(string[] args)
        {
           List<Product> products = new List<Product>()
           {
                new Product { Name = "Laptop", Category = "Electronics", Price = 1200.00m },
                new Product { Name = "Mouse", Category = "Electronics", Price = 25.00m },
                new Product { Name = "Book", Category = "Books", Price = 20.00m },
               new Product { Name = "T-Shirt", Category = "Apparel", Price = 30.00m },
                new Product { Name = "Ebook", Category = "Books", Price = 25.00m },
                new Product { Name = "Keyboard", Category = "Electronics", Price = 75.00m },
                new Product { Name = "Jeans", Category = "Apparel", Price = 25.00m }
            };

           // LINQ to group by category and calculate the average price
           var averagePricesByCategory = products
              .GroupBy(product => product.Category)
               .Select(group => new
                {
                    Category = group.Key,
                    AveragePrice = group.Average(product => product.Price)
                });

            Console.WriteLine("Average Prices by Category:");
            foreach (var categoryPrice in averagePricesByCategory)
           {
               Console.WriteLine($"{categoryPrice.Category}: {categoryPrice.AveragePrice:F2}");            }

            Console.WriteLine("\n=============================================\n");

            List<Customer> customers = new List<Customer>()
            {
                new Customer { CustomerId = 1, Name = "Alice" },
                new Customer { CustomerId = 2, Name = "Bob" },
                new Customer { CustomerId = 3, Name = "Charlie" },
                new Customer { CustomerId = 4, Name = "David" }
            };

            List<Order> orders = new List<Order>()
            {
                new Order { OrderId = 101, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-5) },
                new Order { OrderId = 201, CustomerId = 2, OrderDate = DateTime.Now.AddDays(-10) },
               new Order { OrderId = 103, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-2) },
                new Order { OrderId = 301, CustomerId = 4, OrderDate = DateTime.Now.AddDays(-1) },
                new Order { OrderId = 302, CustomerId = 4, OrderDate = DateTime.Now.AddDays(-7) }
            };

           // LINQ to join customers and orders
           var customerOrders = customers.GroupJoin(
               orders,
               customer => customer.CustomerId,
                order => order.CustomerId,
               (customer, orderList) => new
              {
                   CustomerName = customer.Name,
                   OrderIds = orderList.Select(order => order.OrderId).ToList()
                });

         Console.WriteLine("Customer Orders:");
          foreach (var customerOrder in customerOrders)
          {
              Console.WriteLine($"{customerOrder.CustomerName}: {string.Join(", ", customerOrder.OrderIds)}");
           }
       }
    }
}
