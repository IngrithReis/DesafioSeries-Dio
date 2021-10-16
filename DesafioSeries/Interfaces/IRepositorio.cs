using System;
using System.Collections.Generic;


namespace DesafioSeries.Interfaces
{
    interface IRepositorio<T>
    {
        List<T> lista();
        T RetornaPorId(int Id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();

    }
}
