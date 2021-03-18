using System;
using System.Collections.Generic;
using System.Text;

namespace _2_AplicacaoTranferenciaBancaria
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo - valorSaque < (this.Credito * .1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            this.Saldo -= valorSaque;

            Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;
            Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");
        }

        public void Transferir(double valorTranferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTranferencia))
                contaDestino.Depositar(valorTranferencia);

            Console.WriteLine($"Saldo atual da conta de {this.Nome} é {this.Saldo}");
        }

        public string ObterNome()
        {
            return this.Nome;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += $"TipoConta {this.TipoConta} | ";
            retorno += $"Nome {this.Nome} | ";
            retorno += $"Saldo {this.Saldo} | ";
            retorno += $"Crédito {this.Credito}";
            return retorno;
        }
    }
}
