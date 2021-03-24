using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamps
{
    public class ExerciciosParte2 : IExecutarExercicios
    {
        public void ExecutarExercicios()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Informe um dos exercícios da segunda parte: ");
            Console.WriteLine("1 - Média 1");
            Console.WriteLine("2 - Crescimento Populacional");
            Console.WriteLine("3 - Bazinga!");
            Console.WriteLine("4 - Tempo de um Evento");
            Console.WriteLine("5 - Comunicação em Piralândia");

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
                case "4":
                    Exercicio4();
                    break;
                case "5":
                    Exercicio5();
                    break;
                default:
                    break;
            }
        }

        public static void Exercicio1()
        {
            Console.WriteLine("Exercicio - 1");

            double a, b, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            //complete com as variaveis
            mediaP = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));
            Console.WriteLine("Fim\n");
        }
        public static void Exercicio2()
        {
            Console.WriteLine("Exercicio - 2");

            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                //string[] valores = Console.ReadLine().Split();
                string[] valores = "100 150 1.0 0".Replace(".", ",").Split();

                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

                cpa = (double.Parse(valores[2]));
                cpb = (double.Parse(valores[3]));

                while (pa <= pb)
                {
                    if (anos > 100)
                        break;

                    pa += (int)(pa * (cpa / 100));
                    pb += (int)(pb * (cpb / 100));
                    anos++;
                }

                if (anos <= 100)
                    Console.WriteLine("{0} anos.", (int)anos);
                else
                    Console.WriteLine("Mais de 1 seculo.");

                Console.WriteLine("Fim\n");
            }
        }
        public static void Exercicio3()
        {
            Console.WriteLine("Exercicio - 3");
            int qtdTeste = int.Parse(Console.ReadLine());

            string v1, v2;

            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();

                v1 = valores[0];
                v2 = valores[1];

                if ((v1 == "tesoura" && v2 == "papel")
                    || (v1 == "papel" && v2 == "pedra") //complete a solução
                    || (v1 == "pedra" && v2 == "lagarto")
                    || (v1 == "lagarto" && v2 == "Spock")
                    || (v1 == "Spock" && v2 == "tesoura")
                    || (v1 == "tesoura" && v2 == "lagarto")
                    || (v1 == "lagarto" && v2 == "papel")
                    || (v1 == "papel" && v2 == "Spock")
                    || (v1 == "Spock" && v2 == "pedra")
                    || (v1 == "pedra" && v2 == "tesoura"))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);
                else if (v1 == v2)   //complete a solucao
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }

            Console.WriteLine("Fim\n");
        }
        public static void Exercicio4()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Dia 5");
            sb.AppendLine("8 : 10 : 11");
            sb.AppendLine("Dia 6");
            sb.AppendLine("8 : 9 : 11");

            string[] dados = sb.ToString().Replace(" ", "").Split("\n");
            
            int diaI = Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(dados[0], @"[^\d]", ""));            
            int horaI = Convert.ToInt32(dados[1].Split(":")[0]);
            int minI =  Convert.ToInt32(dados[1].Split(":")[1]);
            int secI =  Convert.ToInt32(dados[1].Split(":")[2]);

            int diaF = Convert.ToInt32(System.Text.RegularExpressions.Regex.Replace(dados[2], @"[^\d]", ""));
            int horaF = Convert.ToInt32(dados[3].Split(":")[0]);
            int minF = Convert.ToInt32(dados[3].Split(":")[1]);
            int secF = Convert.ToInt32(dados[3].Split(":")[2]);

            DateTime inicio = new DateTime(2021, 3, diaI, horaI, minI, secI);
            DateTime fim = new DateTime(2021, 3, diaF, horaF, minF, secF);

            var dif = (fim - inicio);

            Console.WriteLine("{0} dia(s)", dif.Days);
            Console.WriteLine("{0} hora(s)", dif.Hours);
            Console.WriteLine("{0} minuto(s)", dif.Minutes);
            Console.WriteLine("{0} segundo(s)", dif.Seconds);
        }
        public static void Exercicio5()
        {
            Console.WriteLine("Exercicio - 5");
            Console.WriteLine("Informe o número: ");

            string numero = Console.ReadLine();

            string numero_invertido = "";

            for (int i = numero.Length - 1; i >= 0; i--)
                numero_invertido += numero[i].ToString();

            Console.WriteLine(numero_invertido);
            Console.WriteLine("Fim\n");
        }
    }
}
