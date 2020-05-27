using System;
using System.IO;
using System.Collections.Generic;
namespace DictionaryExercício
{
    class Program
    {
        /* Na contagem de votos de uma eleição, são gerados vários registros de votação
         * contendo o nome do candidato e a quantidade de votos (formato .csv) que ele
         * obteve em uma urna de votação. Você deve fazer um programa para ler os registros
         * de votação a partir de um arquivo, e daí gerar um relatório consolidado com os
         * totais de cada candidato.
         */
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            Dictionary<string, int> poll = new Dictionary<string, int>();

            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                using (sr)
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = int.Parse(line[1]);
                        if (poll.ContainsKey(name))
                        {
                            poll[name] += votes;
                        }
                        else
                        {
                            poll[name] = votes;
                        }
                    }
                }

                foreach (KeyValuePair<string, int> key in poll)
                {
                    Console.WriteLine(key.Key + ": " + key.Value);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
