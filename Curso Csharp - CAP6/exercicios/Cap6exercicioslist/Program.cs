using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicioslist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered? ");
            int m = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= m; i++)
            {

                Console.WriteLine("Employee; #" + i + ":");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Salary");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
           
            Employee emp = list.Find(x => x.Id == searchId);

            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
