using ProjetoLivraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLivraria.Controller
{
    public class Negocio
    {
        private List<Livro> Livros = new List<Livro>();
        private List<Usuario> Usuarios = new List<Usuario>();

        #region Obtenção Livros

        public List<Livro> ObtemLivrosDoUsuario(Usuario usuario)
        {
            return Livros.Where(l => l.IdUsuario == usuario.IdUsuario).ToList();
        }

        public List<Livro> ObtemLivros()
        {
            return Livros;
        }

        #endregion Obtenção Livros

        #region CRUD Livro

        public void AdicionarLivro(Livro livro, Usuario usuario)
        {
            List<Livro> livrosDoUsuario = ObtemLivrosDoUsuario(usuario);
       
            if(livrosDoUsuario.Where(l => l.Isbn == livro.Isbn).Count() > 0)            
                throw new Exception("Não é possível adicionar outro livro com o mesmo ISBN.");
            else            
                Livros.Add(livro);  
        }

        public void ApagarLivro(Livro livro)
        {
            Livros.Remove(livro);
        }

        #endregion CRUD Livro

        #region CRUD Usuario

        public void AdicionaUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void ExcluirUsuario(Usuario usuario)
        {
            Usuarios.Remove(usuario);
        }

        #endregion CRUD Usuario
    }
}