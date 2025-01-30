namespace Library_Management.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get ; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoDePublicacao { get; set; }

        public Livro(int id, string titulo, string autor, string isbn, int ano)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.ISBN = isbn;
            this.AnoDePublicacao = ano;
        }

        public Livro()
        {
        }

        public List<Livro> DeletarLivro(List<Livro> livros, int id)
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
                return livros;
            }
            else
            {
                livros.Remove(removerLivro);
                Console.WriteLine("Livro removido com SUCESSO! \n\nPRESSIONE ENTER PARA VOLTAR PARA O MENU INICIAL");
                Console.ReadLine();
                return livros;
            }
        }

        public void ProcurarLivro(List<Livro> livros, int id)
        {
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
        }

        public void VerLivros(List<Livro> livros) 
        {
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
        }
    }
}
