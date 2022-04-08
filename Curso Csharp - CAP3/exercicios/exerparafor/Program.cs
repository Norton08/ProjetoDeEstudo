using System;

namespace exerparafor
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Numeros impares eu te darei");
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++) {
                if (i % 2 != 0) {
                
                Console.WriteLine(i);
                }
            }
        }
    }
}
