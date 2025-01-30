using Library_Management.Entities;
using System;
using System.Collections.Generic;

namespace Library_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Livro> livros = new List<Livro>();
            Menu(livros);

        }

        public static void Menu(List<Livro> livros) 
        {
            Console.Clear();
            Console.WriteLine("-----   MENU   -----\n");
            Console.WriteLine("1. Cadastrar Livro");
            Console.WriteLine("2. Ver Livros");
            Console.WriteLine("3. Consultar Livro");
            Console.WriteLine("4. Excluir Livro");
            Console.WriteLine("5. Sair");
            Console.WriteLine("\n--------------------");

            int resposta = int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case 1:
                    CadastrarLivro(livros);
                    break;
                case 2:
                    VerLivrosMenu(livros);
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Id do livro a ser procurado: ");
                    int id = int.Parse(Console.ReadLine());
                    ProcurarLivroMenu(livros,id);
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Id do livro a ser excluído: ");
                    id = int.Parse(Console.ReadLine());
                    DeletarLivroMenu(livros,id);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        public static void CadastrarLivro(List<Livro> livros)
        {
            Console.Clear();
            Console.WriteLine("-----   CADASTRO DE LIVRO   -----\n");
            Console.Write("Informe o Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Informe o título: ");
            string titulo = Console.ReadLine();

            Console.Write("Informe o autor: ");
            string autor = Console.ReadLine();

            Console.Write("Informe o ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Informe o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("\n---------------------------------\n");

            Livro livro = new Livro(id,titulo,autor,isbn,ano);
            livros.Add(livro);

            Console.WriteLine("Livro cadastrado com SUCESSO!");

            Console.WriteLine("\n\nPRESSIONE ENTER PARA VOLTAR PARA O MENU INICIAL");
            Console.ReadLine();
            Menu(livros);

        }

        public static void VerLivrosMenu(List<Livro> livros)
        {
            Console.Clear();
            Livro livro = new Livro();
            livro.VerLivros(livros);
            Menu(livros);
        }

        public static void ProcurarLivroMenu(List<Livro> livros,int id)
        {
            Console.Clear();
            Livro livro = new Livro();
            livro.ProcurarLivro(livros, id);
            Menu(livros);
        }

        public static void DeletarLivroMenu(List<Livro> livros, int id) 
        {
            Console.Clear();
            Livro livro = new Livro();
            livros = livro.DeletarLivro(livros,id);
            Menu(livros);
        }
    }
}
