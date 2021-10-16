using DesafioSeries.Entities;
using DesafioSeries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DesafioSeries
{
    class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> _series = new List<Serie>(); 
        public void Atualiza(int id, Serie objeto)
        {
            _series[id] = objeto;
            
        }

        public void Exclui(int id)
        {   // no caso de uso do ".Removeat(id), iria haver realocação dos outros indíces e os índices da lista iriam ser alterada"
            // soft delete

            _series[id].Exclui();
        }

        public void Insere(Serie objeto)
        {
            _series.Add(objeto);
        }

        public List<Serie> lista()
        {
            return _series;
        }

        public int ProximoId()
        {
            return _series.Count;
        }

        public Serie RetornaPorId(int Id)
        {
            return _series[Id];
        }
        public List<Serie> RetornaExcluido()
        {
            return _series.Where(x => x.Excluido == true).ToList();
        }
        
    }
}
