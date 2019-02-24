using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ProjetoLivraria.Model
{
    public class Livro
    {
        public int IdLivro { get; set; }
        public int Isbn { get; set; }
        public string Autor { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataPublicacao { get; set; }
        public Bitmap ImagemCapa { get; set; }

        public int IdUsuario { get; set; }
        public DateTime DataHoraCadastro { get; set; }
    }
}