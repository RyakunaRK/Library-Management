using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
