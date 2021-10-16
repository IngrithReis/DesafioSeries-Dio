using DesafioSeries.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioSeries.Entities
{
    public class Serie : EntidadeBase
    {
        private Genero _genero { get; set; }
        private string _titulo { get; set; }

        private string _descricao { get; set; }

        private int _ano { get; set; }

        private bool _excluido { get; set; }

        public Serie(Genero genero, string titulo, string descricao, int ano, int id) 
        {
            Id = id;
            _genero = genero;
            _titulo = titulo;
            _descricao = descricao;
            _ano = ano;
            _excluido = false;
        }

        public override string ToString()
        {
            
            string retorno = "";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            retorno += $"Gênero: {_genero}\n";
            retorno += $"Título: {_titulo} \n";
            retorno += $"Descrição: {_descricao} \n";
            retorno += $"Ano de Início: {_ano} \n";
            Console.Clear();

            return retorno; 
        }

        public string RetornaTitulo()
        {
            return _titulo;
        }
        public int RetornaId()
        {
            return Id;
        }

        public void Exclui()
        {
            _excluido = true;
        }
    }
}
