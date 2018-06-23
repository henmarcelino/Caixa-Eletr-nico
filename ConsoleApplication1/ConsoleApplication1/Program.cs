using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;

            int ValorSaque = 0;

            int Nota100Count = 0;
            int Nota50Count = 0;
            int Nota20Count = 0;
            int Nota10Count = 0;
            int Nota5Count = 0;
            int Nota2Count = 0;
            int Nota1Count = 0;

            Console.Write("Digite o valor que deseja sacar: ");

            try
            {
                ValorSaque = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Não é possivel efetuar saque com centavos!");
            }

            Console.WriteLine();

            while (ValorSaque >= 100)
            {
                ValorSaque = ValorSaque - 100;
                Nota100Count++;
            }
            while (ValorSaque >= 50)
            {
                ValorSaque = ValorSaque - 50;
                Nota50Count++;
            }
            while (ValorSaque >= 20)
            {
                ValorSaque = ValorSaque - 20;
                Nota20Count++;
            }
            while (ValorSaque >= 10)
            {
                ValorSaque = ValorSaque - 10;
                Nota10Count++;
            }
            while (ValorSaque >= 5)
            {
                ValorSaque = ValorSaque - 5;
                Nota5Count++;
            }
            while (ValorSaque >= 2)
            {
                ValorSaque = ValorSaque - 2;
                Nota2Count++;
            }
            while (ValorSaque == 1)
            {
                ValorSaque = ValorSaque - 1;
                Nota1Count++;
            }

            Console.WriteLine("Notas de R$100 sacadas: " + Nota100Count + ".");
            Console.WriteLine("Notas de R$50 sacadas: " + Nota50Count + ".");
            Console.WriteLine("Notas de R$20 sacadas: " + Nota20Count + ".");
            Console.WriteLine("Notas de R$10 sacadas: " + Nota10Count + ".");
            Console.WriteLine("Notas de R$5 sacadas: " + Nota5Count + ".");
            Console.WriteLine("Notas de R$2 sacadas: " + Nota2Count + ".");
            Console.WriteLine("Notas de R$1 sacadas: " + Nota1Count + ".");

            Console.ReadKey();
        }
    }
}