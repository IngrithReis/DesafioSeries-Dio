using DesafioSeries.Entities;
using DesafioSeries.Tipos;
using System;

namespace DesafioSeries
{
    class Program
    {
		static SerieRepositorio repositorio = new SerieRepositorio();
		static void Main(string[] args)
        {
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarSeries();
						break;
					case "2":
						InserirSerie();
						break;
					case "3":
						AtualizarSerie();
						break;
					case "4":
						ExcluirSerie();
						break;
					case "5":
						VisualizarSerie();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();


			
		}
		private static void VisualizarSerie()
        {
            Console.Write("Informe o Id da série: ");
			int entradaVisualizaId = int.Parse(Console.ReadLine());

			repositorio.RetornaPorId(entradaVisualizaId);
            Console.WriteLine(entradaVisualizaId);
        }
		private static void ExcluirSerie()
        {
            Console.Write("Digite Id da série a ser excluída: ");
			int entradaSerieExcluir = int.Parse(Console.ReadLine());

			repositorio.Exclui(entradaSerieExcluir);
        }
		private static void AtualizarSerie()
        {
            Console.Write("Digite o id da série: ");
			int entradaId = int.Parse(Console.ReadLine());

			foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }

            Console.Write("Digite o gênero dentro das opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());
			Console.Write("Digite o Título da série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite a descrição da série: ");
			string entradaDescricao = Console.ReadLine();

			Console.Write("Digite ano de início da série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Serie atualizaSerie = new Serie(repositorio.ProximoId(), (Genero)entradaGenero, entradaTitulo, entradaDescricao, entradaAno);

			repositorio.Atualiza(atualizaSerie.Id, atualizaSerie);

		}
		private static void InserirSerie()
        {
            Console.WriteLine("Inserir dados da série: ");
            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            Console.Write("Digite o Gênero dentro das opções acima: ");
			var entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da série: ");
			string entradaTitulo = Console.ReadLine();

			Console.Write("Digite a descrição da série: ");
			string entradaDescricao = Console.ReadLine();

			Console.Write("Digite ano de início da série: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Serie serie = new Serie(repositorio.ProximoId(), (Genero)entradaGenero, entradaTitulo, entradaDescricao, entradaAno);
			repositorio.Insere(serie);

        }
		private static void ListarSeries()
		{
			Console.WriteLine("Listar séries");

			var lista = repositorio.lista();

			if (lista.Count == 0)
			{
				var console = Console.BackgroundColor;
				Console.BackgroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("Nenhuma série cadastrada.");
				Console.BackgroundColor = console;
				

				return;
			}

			foreach (var serie in lista)
			{


				Console.WriteLine($"#ID {serie.Id}: - {serie.Titulo} {(serie.Excluido ? "* Série Excluída*" : " ")}"); // se for excluído irá mostrar mensagem 
			}

			
		} 

		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			var console = Console.BackgroundColor;
			var foreground = Console.ForegroundColor;
			Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("Ingrith Séries a seu dispor!!!");
			Console.ForegroundColor = foreground;
			Console.BackgroundColor = console;
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar séries");
			Console.WriteLine("2- Inserir nova série");
			Console.WriteLine("3- Atualizar série");
			Console.WriteLine("4- Excluir série");
			Console.WriteLine("5- Visualizar série");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}
