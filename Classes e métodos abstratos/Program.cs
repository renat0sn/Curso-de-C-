using System;
using System.Globalization;
using System.Collections.Generic;
using Contribuinte.Entities;

namespace Contribuinte
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> list = new List<Taxpayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");

                Console.Write("Individual or company (i/c)? ");
                char ic = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ic == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new NaturalPerson(name, annualIncome, healthSpending));
                }

                else if(ic == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new JuridicalPerson(name, annualIncome, employees));
                }
            }

            double sum = 0;
            Console.WriteLine("\nTAXES PAID:");
            foreach(Taxpayer tax in list)
            {
                Console.WriteLine(tax.Name + ": $ " + tax.TaxCalc().ToString("F2", CultureInfo.InvariantCulture));
                sum += tax.TaxCalc();
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
