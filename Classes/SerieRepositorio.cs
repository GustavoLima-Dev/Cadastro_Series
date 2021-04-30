using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;
namespace DIO.Series
{
    public class SerieRepositorio : iRepositorio<Series>
    {
        private List<Series> listSeries = new List<Series>();
        public void Atualiza(int id, Series entidade)
        {
            listSeries[id] = entidade;
        }

        public void Exclui(int id)
        {
            listSeries[id].Excluir();
        }

        public void Insere(Series entidade)
        {
            listSeries.Add(entidade);
        }

        public List<Series> Lista()
        {
            return listSeries;
        }

        public int ProximoId()
        {
            return listSeries.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listSeries[id];
        }
    }
}