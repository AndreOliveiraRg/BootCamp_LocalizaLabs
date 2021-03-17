using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamps
{
    public class ExerciciosParte1 : IExecutarExercicios
    {
        public void ExecutarExercicios()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Informe um dos exercícios da primeira parte: ");
            Console.WriteLine("1 - Consumo Médio do Automóvel");
            Console.WriteLine("2 - DDD");
            Console.WriteLine("3 - Aumento de salário");

            string menu = Convert.ToString(Console.ReadLine());

            switch (menu)
            {
                case "1":
                    Exercicio1();
                    break;
                case "2":
                    Exercicio2();
                    break;
                case "3":
                    Exercicio3();
                    break;
                default:
                    break;
            }
        }

        public static void Exercicio1()
        {
            Console.WriteLine("Exercicio - 1");

            int distancia;
            double combustivelGasto, consumoMedio;

            Console.WriteLine("Distancia: ");
            distancia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Computivel Gasto: ");
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio = Convert.ToDouble(distancia / combustivelGasto);

            Console.WriteLine("Resultado: {0:0.000} km/l", consumoMedio);
            Console.WriteLine("Fim\n");
        }
        public static void Exercicio2()
        {
            Console.WriteLine("Exercicio - 2");
            Console.WriteLine("DDD: ");
            int ddd = Convert.ToInt32(Console.ReadLine());

            switch (ddd)
            {
                case 61:
                    Console.WriteLine("Brasilia");
                    break;
                case 71:                             //complete os DDD's corretamente
                    Console.WriteLine("Salvador");
                    break;
                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 27:
                    Console.WriteLine("Vitoria");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
                default:
                    Console.WriteLine("DDD nao cadastrado");
                    break;
            }

            Console.WriteLine("Fim\n");
        }
        public static void Exercicio3()
        {
            Console.WriteLine("Exercicio - 3");

            double reajuste, novoSalario, percentual;
            Console.WriteLine("Informe o salário atual: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            //insira os valores corretos de acordo com o enunciado
            if (salario < 0.00)
                return;

            if (salario >= 0.00 && salario <= 400.00)
            {
                reajuste = salario * 0.15;
                novoSalario = salario + reajuste;
                percentual = 0.15 * 100;
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                reajuste = salario * 0.12;
                novoSalario = salario + reajuste;
                percentual = 0.12 * 100;
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                reajuste = salario * 0.10;
                novoSalario = salario + reajuste;
                percentual = 0.10 * 100;
            }
            else if (salario > 1200 && salario <= 2000.00)
            {
                reajuste = salario * 0.07;
                novoSalario = salario + reajuste;
                percentual = 0.07 * 100;
            }
            else
            {
                reajuste = salario * 0.04;
                novoSalario = salario + reajuste;
                percentual = 0.04 * 100;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
            Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
            Console.WriteLine("Em percentual: {0} %", percentual);

            Console.WriteLine("Fim\n");
        }
    }
}
