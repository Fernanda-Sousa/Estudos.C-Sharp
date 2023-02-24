using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Exercícios.Biblioteca
{
    public class Livro
    {
        public string Isbn { get; private set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoDePuplicacao { get; set; }
        public string EstiloLiterarion { get; set; }
        public int NumeroDePaginas { get; set; }
        public string PaisDePublicacao { get; set; }

        public Livro(string isbn, string titulo)
        {
            this.Isbn = isbn;
            this.Titulo = titulo;
        }
    }
}
