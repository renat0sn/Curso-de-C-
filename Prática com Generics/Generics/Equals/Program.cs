using System;
using EqualsEGetHashCode;

namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email;
            Console.WriteLine("Cliente 1:");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Client c1 = new Client(name, email);

            Console.WriteLine("\nCliente 2:");
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Client c2 = new Client(name, email);

            Console.WriteLine("\nTESTE DE IGUALDADE:");
            Console.WriteLine("Equals: " + c1.Equals(c2));

            Console.WriteLine("GetHashCode: ");
            Console.WriteLine("c1: " + c1.GetHashCode());
            Console.WriteLine("c2: " + c2.GetHashCode());
        }
    }
}
