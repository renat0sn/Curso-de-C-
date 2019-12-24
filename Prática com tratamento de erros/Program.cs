using System;
using System.Globalization;
using ConsoleApp2.Entities;
using ConsoleApp2.Entities.Exceptions;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");

                int number;
                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());

                string holder;
                Console.Write("Holder: ");
                holder = Console.ReadLine();

                double initialBalance;
                Console.Write("Initial balance: ");
                initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double withdrawLimit;
                Console.Write("Withdraw limit: ");
                withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                double withdraw;
                Console.Write("\n\nEnter amount for withdraw: ");
                withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                acc.Withdraw(withdraw);

                Console.WriteLine("New balance: $ " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
        }
    }
}
