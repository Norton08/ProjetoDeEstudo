using System;
using Course.Entities;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            System.Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n ; i++)
            {
                System.Console.WriteLine($"Product #{i} data:");
                System.Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Price ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'c')
                {
                    list.Add(new Product(name,price));
                }

                    if (ch == 'u')
                {
                    System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }

                    if (ch == 'i')
                {
                    System.Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }

               
            }
            
            System.Console.WriteLine();
            System.Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                System.Console.WriteLine(product);
            }

            Console.ReadKey();
        }
    }
}
