using System;
using Course.Entities.Enums;
using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter cliente data:");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter order data: ");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name,email,birthDate);
            Order order = new Order(DateTime.Now, status, client);

            System.Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                System.Console.WriteLine($"Enter #{i} item data:");
                System.Console.Write("Product name: ");
                string productName = Console.ReadLine();
                System.Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Product product = new Product(productName, price);

                System.Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);

            }

            System.Console.WriteLine();
            System.Console.WriteLine("ORDER SUMMARY: ");
            System.Console.WriteLine(order);

        }
    }
}
