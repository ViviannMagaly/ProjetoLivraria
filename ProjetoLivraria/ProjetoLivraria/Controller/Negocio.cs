using ProjetoLivraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ProjetoLivraria.Controller
{
    public class Negocio
    {
        private List<Livro> Livros = new List<Livro>();
        private List<Usuario> Usuarios = new List<Usuario>();

        #region Obtenção Livros

        public List<Livro> ObtemLivros(Usuario usuario)
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
            if (Livros.Where(l => l.Isbn == livro.Isbn).Count() > 0)
                throw new ArgumentException("Não é possível adicionar outro livro com o mesmo ISBN.");
            else
            {
                livro.IdLivro = (Livros.Count == 0 ? 0 : Livros.Max(m => m.IdLivro)) + 1;
                livro.IdUsuario = usuario.IdUsuario;
                livro.DataHoraCadastro = DateTime.Now;
                Livros.Add(livro);
            }
        }

        public void ApagarLivro(Livro livro)
        {
            if (Livros.Exists(l => l.IdLivro == livro.IdLivro))
                Livros.Remove(livro);
            else
                throw new Exception("O livro selecionado não foi encontrado.");
        }

        #endregion CRUD Livro

        #region CRUD Usuario

        public void AdicionaUsuario(Usuario usuario)
        {
            if (!usuario.Email.Contains("@"))
                throw new ArgumentException("O e-mail precisa ter o caractere @.");
            else if (Usuarios.Where(u => u.Email == usuario.Email).Count() > 0)
                throw new ArgumentException("E-mail já cadastrado.");

            usuario.IdUsuario = (Usuarios.Count == 0 ? 0 : Usuarios.Max(m => m.IdUsuario)) + 1;
            Usuarios.Add(usuario);
        }

        public Usuario Login(string email, string senha)
        {
            string senhaCriptografada = NegocioSenha.GerarMD5(senha);

            try
            {
                Usuario usuario = Usuarios.Where(u => u.Email == email && u.Senha == senhaCriptografada).First();

                if (usuario != null)
                    return usuario;
                else
                    throw new ArgumentException("E-mail / Senha inválidos.");
            }
            catch
            {
                throw new ArgumentException("E-mail / Senha inválidos.");
            }
        }

        #endregion CRUD Usuario

        public void DadosParaTeste()
        {
            Usuario usu = new Usuario();
            usu.NomeUsuario = "ajse";
            usu.SetSenha("1234");
            usu.Email = "1234@1234.com";

            this.AdicionaUsuario(usu);

            Livro livro1 = new Livro();
            livro1.Isbn = 1;
            livro1.Autor = "aa";
            livro1.Preco = Convert.ToDecimal(10.90);
            livro1.DataPublicacao = new DateTime(2019, 1, 20);
            livro1.Nome = "bbb";

            Livro livro2 = new Livro();
            livro2.Isbn = 2;
            livro2.Autor = "ccc";
            livro2.Preco = Convert.ToDecimal(15.00);
            livro2.DataPublicacao = new DateTime(2019, 1, 20);
            livro2.Nome = "eeee";

            Livro livro3 = new Livro();
            livro3.Isbn = 3;
            livro3.Autor = "ddddd";
            livro3.Preco = Convert.ToDecimal(9.90);
            livro3.DataPublicacao = new DateTime(2019, 1, 20);
            livro3.Nome = "saygease";

            Livro livro4 = new Livro();
            livro4.Isbn = 4;
            livro4.Autor = "OAKEA";
            livro4.Preco = Convert.ToDecimal("3,28");
            livro4.DataPublicacao = new DateTime(2019, 1, 20);
            livro4.Nome = "NNN";

            Livro livro5 = new Livro();
            livro5.Isbn = 5;
            livro5.Autor = "OSADA";
            livro5.Preco = Convert.ToDecimal(108.00);
            livro5.DataPublicacao = new DateTime(2019, 1, 20);
            livro5.Nome = "XVCX";

            this.AdicionarLivro(livro1, usu);
            this.AdicionarLivro(livro2, usu);
            this.AdicionarLivro(livro3, usu);
            this.AdicionarLivro(livro4, usu);
            this.AdicionarLivro(livro5, usu);
        }
    }
}