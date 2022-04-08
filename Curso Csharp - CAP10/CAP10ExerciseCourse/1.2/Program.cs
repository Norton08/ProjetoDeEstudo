﻿using System;
using Course.Entities;
using System.Collections.Generic;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            System.Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Tax payer #{i} data:");
                System.Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    System.Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, healthExpenditures));
                }
                else
                {
                    System.Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income ,numberOfEmployees));
                }
            }
            double sum = 0.0;
            System.Console.WriteLine();
            System.Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer obj in list)
            {
                double tax = obj.Tax();
                System.Console.WriteLine(obj.Name + ": R$ " + tax.ToString("F2"));
                sum += tax;
            }
            System.Console.WriteLine();
            System.Console.WriteLine("TOTAL TAXES: R$ " + sum.ToString("F2"));
            Console.ReadKey();
        }    
    }
}
