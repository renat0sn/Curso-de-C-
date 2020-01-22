using System;
using System.IO;
using System.Collections.Generic;
using teste.Entities;
using System.Globalization;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> p = new List<Item>();
            string path = @"G:\Teste";

            try
            {
                using (StreamReader sr = File.OpenText(path + @"\dados.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] campos = new string[3];
                        campos = sr.ReadLine().Split(",");

                        Product pr = new Product(campos[0], double.Parse(campos[1].Replace('.', ',')));
                        p.Add(new Item(pr, int.Parse(campos[2])));
                    }
                }

                Directory.CreateDirectory(path + @"\Out");
                using (StreamWriter sw = File.CreateText(path + @"\Out\summary.csv"))
                {
                    foreach(Item i in p)
                    {
                        sw.WriteLine("Produto: "
                            + i.Produto.Objeto
                            + ", Preco total: RS"
                            + i.SubTotal().ToString("F2", CultureInfo.InvariantCulture)
                            );
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Source file: " + Path.GetFullPath(path));
            Console.WriteLine("Output file: " + Path.GetFullPath(path + @"\Out\summary.csv"));
        }
    }
}
