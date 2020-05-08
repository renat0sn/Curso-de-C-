using System;
using System.Globalization;
using Interface.Entidades;
using Interface.Serviços;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complete os dados do contrato:");
            Console.Write("Número: ");
            int nContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Número de prestações: ");
            int meses = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Contrato contrato = new Contrato(nContrato, data, valor, meses, new Paypal());

            Registro.GerarRegistro(contrato);

        }
    }
}
