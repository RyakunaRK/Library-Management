using Library_Management.Entities;
using System;

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
                    VerLivros(livros);
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Id do livro a ser procurado: ");
                    int id = int.Parse(Console.ReadLine());
                    ProcurarLivro(livros,id);
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Id do livro a ser excluído: ");
                    id = int.Parse(Console.ReadLine());
                    DeletarLivro(livros,id);
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

        public static void VerLivros(List<Livro> livros)
        {
            Console.Clear();
            int num = 1;
            foreach (var livro in livros) 
            {
                Console.Write($"-----   LIVRO {num}   -----\n\n");
                Console.WriteLine($"ID: {livro.Id}");
                Console.WriteLine($"Título: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
                Console.WriteLine($"ISBN: {livro.ISBN}");
                Console.WriteLine($"Ano de publicação: {livro.AnoDePublicacao}");
                Console.Write("\n---------------------------\n");
                num++;
            }

            Console.WriteLine("\n\nPRESSIONE ENTER PARA VOLTAR PARA O MENU INICIAL");
            Console.ReadLine();
            Menu(livros);
        }

        public static void ProcurarLivro(List<Livro> livros,int id)
        {
            Console.Clear();
            int flag = 0;
            foreach (var livro in livros)
            {
                if (livro.Id == id)
                {
                    Console.Write($"-----   LIVRO   -----\n\n");
                    Console.WriteLine($"ID: {livro.Id}");
                    Console.WriteLine($"Título: {livro.Titulo}");
                    Console.WriteLine($"Autor: {livro.Autor}");
                    Console.WriteLine($"ISBN: {livro.ISBN}");
                    Console.WriteLine($"Ano de publicação: {livro.AnoDePublicacao}");
                    Console.Write("\n---------------------------\n");
                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine("Livro não encontrado!");

            Console.WriteLine("\n\nPRESSIONE ENTER PARA VOLTAR PARA O MENU INICIAL");
            Console.ReadLine();
            Menu(livros);
        }

        public static void DeletarLivro(List<Livro> livros, int id) 
        {
            Console.Clear();
            int flag = 0;
            Livro removerLivro = new Livro();

            foreach (var livro in livros)
            {
                if (livro.Id == id)
                {
                    removerLivro = livro;
                    flag = 1;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("Livro não encontrado!\n\nPRESSIONE ENTER PARA VOLTAR PARA O MENU INICIAL");
                Console.ReadLine();
                Menu(livros);
            }
            else
            {
                livros.Remove(removerLivro);
                Console.WriteLine("Livro removido com SUCESSO! \n\nPRESSIONE ENTER PARA VOLTAR PARA O MENU INICIAL");
                Console.ReadLine();
                Menu(livros);
            }

        }
    }
}
