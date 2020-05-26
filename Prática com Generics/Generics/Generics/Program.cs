using System;
using System.Collections.Generic;
using System.Globalization;
using Generics.Entities;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for (int i = 0; i < N; i++)
            {
                string[] line = Console.ReadLine().Split(',');
                Product p = new Product(line[0], double.Parse(line[1], CultureInfo.InvariantCulture));
                list.Add(p);
            }

            Console.WriteLine("Most expensive:");
            CalculationService calc = new CalculationService();
            Console.WriteLine(calc.Max(list).ToString());
        }
    }
}
