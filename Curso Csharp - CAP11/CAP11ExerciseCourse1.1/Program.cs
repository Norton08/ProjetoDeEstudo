using System;
using Course.Entities;
using Course.Entities.Exceptions;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Enter account data");
            System.Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.Write("Holder: ");string holder = Console.ReadLine();
            System.Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            System.Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account acc = new Account(number,holder,balance,withdrawLimit);

            System.Console.WriteLine();
            System.Console.WriteLine("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            try
            {
            acc.Withdraw(amount);
            Console.WriteLine("New balance: " + acc.Balance.ToString("F2"));
            }
            catch(DomainException e)
            {
                System.Console.WriteLine("Withdraw error : " + e.Message);
            }
            

        }
    }
}
