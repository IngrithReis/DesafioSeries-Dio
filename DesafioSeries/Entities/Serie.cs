using DesafioSeries.Tipos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioSeries.Entities
{
    public class Serie : EntidadeBase
    {
        public Genero Genero { get;  set; }
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public int Ano { get; set; }

        public bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano) 
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }
        
        public override string ToString()
        {
            
            string retorno = "";
            var console = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            retorno += $"Gênero: {Genero}\n";
            retorno += $"Título: {Titulo} \n";
            retorno += $"Descrição: {Descricao} \n";
            retorno += $"Ano de Início: {Ano} \n";
            Console.BackgroundColor = console;
            Console.Clear();

            return retorno; 
        }

        

        public void Exclui()
        {
            Excluido = true;
        }
       
    }
}
