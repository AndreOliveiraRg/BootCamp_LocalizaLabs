using _3_Series.Enum;
using System;

namespace _3_Series
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";

            retorno += $"Gênero: {System.Enum.GetName(typeof(Genero), this.Genero)} {Environment.NewLine}";
            retorno += $"Título: {this.Titulo} {Environment.NewLine}";
            retorno += $"Descrição: {this.Descricao} {Environment.NewLine}";
            retorno += $"Ano de Início: {this.Ano} {Environment.NewLine}";
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
        public int RetornaId()
        {
            return this.Id;
        }
        public Genero RetornaGenero()
        {
            return this.Genero;
        }
        public string RetornaTitulo()
        {
            return this.Titulo;
        }
        public string RetornaDescricao()
        {
            return this.Descricao;
        }
        public int RetornaAno()
        {
            return this.Ano;
        }
        public override void Excluir()
        {
            this.Excluido = true;
        }
        public bool RetornaExcluido()
        {
            return this.Excluido;
        }
    }
}
