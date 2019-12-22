using System;
using System.Collections.Generic;
using Produtos.Entities;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int nP = int.Parse(Console.ReadLine());

            List<Product> list = new List<Product>();

            for(int i=1; i<=nP; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());

                string name;
                Console.Write("Name: ");
                name = Console.ReadLine();

                double price;
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine());

                if(c == 'i')
                {
                    double customsFee;
                    Console.Write("Customs fee: ");
                    customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                }

                else if(c == 'u')
                {
                    DateTime manufactureDate;
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }

                else if(c == 'c')
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach(Product pr in list)
            {
                Console.WriteLine(pr.PriceTag());
            }
        }
    }
}
