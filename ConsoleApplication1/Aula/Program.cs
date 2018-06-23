using System;

namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = CadastrarAluno();

            ImprimirDadosAluno(a);

            Console.ReadKey();


            Console.WriteLine(a.Nome);
            

            Console.WriteLine("Digite o nome do aluno: ");
            a.Nome = Console.ReadLine(); //set

            a.Matricula = 123; //set


            Console.WriteLine("Aluno: " + a.Nome); //get

            Console.ReadKey();
        }

        private static void ImprimirDadosAluno(Aluno a)
        {
            Console.WriteLine("Aluno" + a.Nome);
            Console.WriteLine("Matricula" + a.Matricula);
        }

        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();

            Console.WriteLine("Digite o Aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite o Matricula: ");
            a.Matricula = int.Parse(Console.ReadLine());
            return a;
        }
    }
}
