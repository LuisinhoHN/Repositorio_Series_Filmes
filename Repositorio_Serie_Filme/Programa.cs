using Repositorio_Serie_Filme.Classes;
using Repositorio_Serie_Filme.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio_Serie_Filme
{
    class Programa
    {
        static SerieRepositorio repositorioSerie = new SerieRepositorio();
        static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Listar();
                        break;
                    case "2":
                        Inserir();
                        break;
                    case "3":
                        Atualizar();
                        break;
                    case "4":
                        Excluir();
                        break;
                    case "5":
                        Visualizar();
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

        private static void Visualizar()
        {
            Console.WriteLine("Informe o que deseja visualizar:");
            foreach (int i in System.Enum.GetValues(typeof(OpcaoVisu)))
            {
                if(i < 3)
                {
                    Console.WriteLine("{0}-{1}", i, OpcaoVisu.GetName(typeof(OpcaoVisu), i));
                }            
            }
            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.WriteLine();
                VisualizarSerie();
            }
            else if (choise == 2)
            {
                Console.WriteLine();
                VisualizarFilme();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção invalida");
            }
        }

        private static void Excluir()
        {
            Console.WriteLine("Informe o que deseja excluir:");
            foreach (int i in System.Enum.GetValues(typeof(OpcaoVisu)))
            {
                if (i < 3)
                {
                    Console.WriteLine("{0}-{1}", i, OpcaoVisu.GetName(typeof(OpcaoVisu), i));
                }
            }
            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.WriteLine();
                ExcluirSerie();
            }
            else if (choise == 2)
            {
                Console.WriteLine();
                ExcluirFilme();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção invalida");
            }
        }

        private static void Atualizar()
        {
            Console.WriteLine("Informe o que deseja atualizar:");
            foreach (int i in System.Enum.GetValues(typeof(OpcaoVisu)))
            {
                if (i < 3)
                {
                    Console.WriteLine("{0}-{1}", i, OpcaoVisu.GetName(typeof(OpcaoVisu), i));
                }
            }
            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.WriteLine();
                AtualizarSerie();
            }
            else if (choise == 2)
            {
                Console.WriteLine();
                AtualizarFilme();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção invalida");
            }
        }

        private static void Inserir()
        {
            Console.WriteLine("Informe o que deseja inserir:");
            foreach (int i in System.Enum.GetValues(typeof(OpcaoVisu)))
            {
                if (i < 3)
                {
                    Console.WriteLine("{0}-{1}", i, OpcaoVisu.GetName(typeof(OpcaoVisu), i));
                }
            }
            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.WriteLine();
                InserirSerie();
            }
            else if (choise == 2)
            {
                Console.WriteLine();
                InserirFilme();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção invalida");
            }
        }

        private static void Listar()
        {
            Console.WriteLine("Informe o que deseja visualizar:");
            foreach (int i in System.Enum.GetValues(typeof(OpcaoVisu)))
            {
                Console.WriteLine("{0}-{1}", i, OpcaoVisu.GetName(typeof(OpcaoVisu), i));
            }
            int choise = int.Parse(Console.ReadLine());

            if (choise == 1)
            {
                Console.WriteLine();
                ListarSeries();
            }
            else if (choise == 2)
            {
                Console.WriteLine();
                ListarFilmes();
            }
            else if (choise == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Séries: ");
                ListarSeries();
                Console.WriteLine();
                Console.WriteLine("Filmes: ");
                ListarFilmes();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Opção invalida");
            }
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorioSerie.Exclui(indiceSerie);
        }

        private static void ExcluirFilme()
        {
            Console.Write("Digite o id da série: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            repositorioFilme.Exclui(indiceFilme);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorioSerie.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static void VisualizarFilme()
        {
            Console.Write("Digite o id da série: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            var filme = repositorioFilme.RetornaPorId(indiceFilme);

            Console.WriteLine(filme);
        }

        private static void AtualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Genero.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioSerie.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void AtualizarFilme()
        {
            Console.Write("Digite o id da série: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Genero.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme atualizaFilme = new Filme(id: indiceFilme,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioFilme.Atualiza(indiceFilme, atualizaFilme);
        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");

            var lista = repositorioSerie.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        private static void ListarFilmes()
        {
            Console.WriteLine("Listar filmes");

            var lista = repositorioFilme.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrada.");
                return;
            }

            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");


            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Genero.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioSerie.Insere(novaSerie);
        }

        private static void InserirFilme()
        {
            Console.WriteLine("Inserir novo filme");


            foreach (int i in System.Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Genero.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme novoFilme = new Filme(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorioFilme.Insere(novoFilme);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Séries & Filmes a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar");
            Console.WriteLine("2- Inserir");
            Console.WriteLine("3- Atualizar");
            Console.WriteLine("4- Excluir");
            Console.WriteLine("5- Visualizar");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}