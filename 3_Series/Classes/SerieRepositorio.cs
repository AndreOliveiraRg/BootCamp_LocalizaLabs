using _3_Series.Interfaces;
using System;
using System.Collections.Generic;

namespace _3_Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualizar(int id, Serie entidade)
        {
            var item = RetornarPorId(id);
            item = entidade;
        }

        public void Excluir(int id)
        {
            var item = RetornarPorId(id);
            item.Excluir();
        }

        public void Inserir(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornarPorId(int id)
        {
            return listaSerie.Find(x => x.Id == id);
        }
    }
}
