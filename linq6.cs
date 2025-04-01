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
        public decimal Amount { get; set; }  // Added Amount property for Assignment10
    }

    public class Assignment6
    {
        public static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>()
           {
               new Customer { CustomerId = 1, Name = "Alice" },
               new Customer { CustomerId = 2, Name = "Bob" },
               new Customer { CustomerId = 3, Name = "Charlie" },
               new Customer { CustomerId = 4, Name = "David" }
           };

            List<Order> orders = new List<Order>()
           {
               new Order { OrderId = 101, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-5), Amount = 60.00m },
               new Order { OrderId = 201, CustomerId = 2, OrderDate = DateTime.Now.AddDays(-10), Amount = 40.00m },
               new Order { OrderId = 103, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-2), Amount = 70.00m },
               new Order { OrderId = 301, CustomerId = 4, OrderDate = DateTime.Now.AddDays(-1), Amount = 80.00m },
               new Order { OrderId = 302, CustomerId = 4, OrderDate = DateTime.Now.AddDays(-7), Amount = 90.00m },
               new Order { OrderId = 104, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-3), Amount = 55.00m },
               new Order { OrderId = 202, CustomerId = 2, OrderDate = DateTime.Now.AddDays(-12), Amount = 52.00m }
           };

            decimal averageThreshold = 55.00m;
            int minOrderCount = 2;

            var topCustomers = orders
                .GroupBy(order => order.CustomerId)
                .Where(group => group.Count() >= minOrderCount) // Customers with at least `minOrderCount` orders
                .Select(group => new
                {
                    CustomerId = group.Key,
                    OrderCount = group.Count(),
                    AverageAmount = group.Average(order => order.Amount)
                })
                .Where(customerInfo => customerInfo.AverageAmount > averageThreshold) // High average order value
                .OrderByDescending(customerInfo => customerInfo.OrderCount) // Sort by order count (Descending)
                .Take(2) // Take top 2 customers
                .Join(customers, // Join with customer data
                    customerInfo => customerInfo.CustomerId,
                    customer => customer.CustomerId,
                    (customerInfo, customer) => customer.Name); // Select customer name

            Console.WriteLine("Top 2 Customers with High Average Order Value:");
            foreach (string customerName in topCustomers)
            {
                Console.WriteLine(customerName);
            }
        }
    }
}
