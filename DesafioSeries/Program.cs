using DesafioSeries.Entities;
using System;

namespace DesafioSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie a = new Serie(Enum.Genero.Acao,"Ação", "Bacana",1988,1);
            Console.WriteLine(a);
        }
    }
}
