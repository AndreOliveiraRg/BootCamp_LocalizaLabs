using BootCamps;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu = "";


            Console.WriteLine("Exercicios BootCamps LocalizaLabs");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Exercicios parte I");
            Console.WriteLine("2 - Exercicios parte II");
            Console.WriteLine(" ");
            Console.Write("Informe qual grupo de exercícios deseja executar: ");
            menu = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");

            switch (menu)
            {
                case "1":
                    ExecutarExercicios.Executar(new ExerciciosParte1());
                    break;
                case "2":
                    ExecutarExercicios.Executar(new ExerciciosParte2());
                    break;
                default:
                    break;
            }
        }
    }
}
