using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_AplicacaoTranferenciaBancaria
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirContas();
                        break;
                    case "3":
                    Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                    Depositar();
                        break;
                    case "C":
                        Console.Clear();                        
                        break;
                    default:
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
        private static void Sacar()
        {
            ValidarConta();

            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorDeposito);
        }
        private static void Transferir()
        {
            ValidarConta();

            Console.WriteLine("Digite o número da conta de origem: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser transferido: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Transferir(valorDeposito, listContas[indiceContaDestino]);
        }
        private static void Depositar()
        {
            ValidarConta();

            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());
                        
            listContas[indiceConta].Depositar(valorDeposito);
        }
        private static void InserirContas()
        {
            Console.WriteLine("Inserir nova conta");

            Console.WriteLine("Digite 1 para Conta Física ou 2 para Jurídica: ");
            int tipoConta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o Nome do Cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o crédito: ");
            double credito = Convert.ToDouble(Console.ReadLine());

            if (!listContas.Any(x => x.ObterNome().Equals(nome)))
                listContas.Add(new Conta(tipoConta: (TipoConta)tipoConta, saldo: saldo, credito: credito, nome: nome));
        }
        private static void ListarContas()
        {
            ValidarConta();

            Console.WriteLine("Listar contas");

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];

                Console.Write("#{0} --- ", i);
                Console.WriteLine(conta.ToString());
            }
        }
        private static void ValidarConta()
        {
            if (!listContas.Any())
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu dispor!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar contas");
            Console.WriteLine("2- Inserir nova conta");
            Console.WriteLine("3- Transferir");
            Console.WriteLine("4- Sacar");
            Console.WriteLine("5- Depositar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
