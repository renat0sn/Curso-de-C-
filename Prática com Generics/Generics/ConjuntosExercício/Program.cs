using System;
using System.Collections.Generic;

namespace ConjuntosExercício
{
    /* Em um portal de cursos online, cada usuário possui um código único, representado por
     * um número inteiro.
     * 
     * Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se
     * matricular em quantos cursos quiser. Assim, o número total de alunos de um instrutor
     * não é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haver
     * alunos repetidos em mais de um curso.
     * 
     * O instrutor Alex possui três cursos A, B, e C, e deseja saber seu número total de alunos.
     * 
     * Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a 
     * quantidade total de alunos dele.
     */
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> studentsId_A = new HashSet<int>();
            HashSet<int> studentsId_B = new HashSet<int>();
            HashSet<int> studentsId_C = new HashSet<int>();
            HashSet<int> studentsTotal = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int A = int.Parse(Console.ReadLine());
            for (int i = 0; i < A; i++)
            {
                int id = int.Parse(Console.ReadLine());
                studentsId_A.Add(id);
            }

            Console.Write("How many students for course B? ");
            int B = int.Parse(Console.ReadLine());
            for (int i = 0; i < B; i++)
            {
                int id = int.Parse(Console.ReadLine());
                studentsId_B.Add(id);
            }

            Console.Write("How many students for course C? ");
            int C = int.Parse(Console.ReadLine());
            for (int i = 0; i < C; i++)
            {
                int id = int.Parse(Console.ReadLine());
                studentsId_C.Add(id);
            }

            studentsTotal.UnionWith(studentsId_A);
            studentsTotal.UnionWith(studentsId_B);
            studentsTotal.UnionWith(studentsId_C);
            Console.WriteLine("Total students: " + studentsTotal.Count);

        }
    }
}
