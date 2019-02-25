using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoLivraria.Controller;
using ProjetoLivraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria.Controller.Tests
{
    [TestClass()]
    public class NegocioTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Não é possível adicionar outro livro com o mesmo ISBN.")]
        public void AdicionarLivroComMesmoIsbnTest()
        {
            Negocio negocio = new Negocio();

            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Nome Teste";
            usuario.Email = "aaa@aaa.com";
            usuario.SetSenha("123");

            negocio.AdicionaUsuario(usuario);

            Livro livro1 = new Livro();
            livro1.Isbn = 1;
            livro1.Autor = "autor teste";
            livro1.Preco = Convert.ToDecimal(10.90);
            livro1.DataPublicacao = new DateTime(2019, 1, 20);
            livro1.Nome = "Um teste";

            Livro livro2 = new Livro();
            livro2.Isbn = 1;
            livro2.Autor = "autor teste 2";
            livro2.Preco = Convert.ToDecimal(2.80);
            livro2.DataPublicacao = new DateTime(2019, 1, 31);
            livro2.Nome = "Um novo teste";

            negocio.AdicionarLivro(livro1, usuario);
            negocio.AdicionarLivro(livro2, usuario);
        }

        [TestMethod()]
        public void AdicionarLivroComDiferenteIsbnTest()
        {
            Negocio negocio = new Negocio();

            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Nome Teste";
            usuario.Email = "aaa@aaa.com";
            usuario.SetSenha("123");

            negocio.AdicionaUsuario(usuario);

            Livro livro1 = new Livro();
            livro1.Isbn = 1;
            livro1.Autor = "autor teste";
            livro1.Preco = Convert.ToDecimal(10.90);
            livro1.DataPublicacao = new DateTime(2019, 1, 20);
            livro1.Nome = "Um teste";

            Livro livro2 = new Livro();
            livro2.Isbn = 2;
            livro2.Autor = "autor teste 2";
            livro2.Preco = Convert.ToDecimal(2.80);
            livro2.DataPublicacao = new DateTime(2019, 1, 31);
            livro2.Nome = "Um novo teste";

            negocio.AdicionarLivro(livro1, usuario);
            negocio.AdicionarLivro(livro2, usuario);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Não é possível adicionar outro livro com o mesmo ISBN.")]
        public void AdicionarLivroComUsuariosDiferentesMesmoIsbnTest()
        {
            Negocio negocio = new Negocio();

            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Nome Teste";
            usuario.Email = "aaa@aaa.com";
            usuario.SetSenha("123");

            negocio.AdicionaUsuario(usuario);

            Usuario usuario2 = new Usuario();
            usuario2.NomeUsuario = "Nome Teste 2";
            usuario2.Email = "bbbbb@aaa.com";
            usuario2.SetSenha("123");

            negocio.AdicionaUsuario(usuario2);

            Livro livro1 = new Livro();
            livro1.Isbn = 1;
            livro1.Autor = "autor teste";
            livro1.Preco = Convert.ToDecimal(10.90);
            livro1.DataPublicacao = new DateTime(2019, 1, 20);
            livro1.Nome = "Um teste";

            Livro livro2 = new Livro();
            livro2.Isbn = 1;
            livro2.Autor = "autor teste 2";
            livro2.Preco = Convert.ToDecimal(2.80);
            livro2.DataPublicacao = new DateTime(2019, 1, 31);
            livro2.Nome = "Um novo teste";

            negocio.AdicionarLivro(livro1, usuario);
            negocio.AdicionarLivro(livro2, usuario2);
        }

        [TestMethod()]
        public void LoginSucessoTest()
        {
            Negocio negocio = new Negocio();

            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Nome Teste";
            usuario.Email = "aaa@aaa.com";
            usuario.SetSenha("123");

            negocio.AdicionaUsuario(usuario);

            Usuario usuario2 = negocio.Login("aaa@aaa.com", "123");
            Assert.AreEqual(usuario, usuario2);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "E - mail / Senha inválidos.")]
        public void LoginFalhaTest()
        {
            Negocio negocio = new Negocio();

            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Nome Teste";
            usuario.Email = "aaa@aaa.com";
            usuario.SetSenha("123");

            negocio.AdicionaUsuario(usuario);
            negocio.Login("aaa@aaa.com", "133");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "O e-mail precisa ter o caractere @.")]
        public void AdicionarUsuarioEmailSemArrobaTest()
        {
            Negocio negocio = new Negocio();

            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Nome Teste";
            usuario.Email = "abcd";
            usuario.SetSenha("123");

            negocio.AdicionaUsuario(usuario);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "E-mail já cadastrado.")]
        public void AdicionarUsuarioEmailJaCadastradoTest()
        {
            Negocio negocio = new Negocio();

            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Nome Teste";
            usuario.Email = "email@123.com";
            usuario.SetSenha("123");

            negocio.AdicionaUsuario(usuario);

            Usuario usuario2 = new Usuario();
            usuario2.NomeUsuario = "Nome Teste 2";
            usuario2.Email = "email@123.com";
            usuario2.SetSenha("321");

            negocio.AdicionaUsuario(usuario2);
        }

        [TestMethod()]
        public void AdicionarUsuarioSucessoTest()
        {
            Negocio negocio = new Negocio();

            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Nome Teste";
            usuario.Email = "email@123.com";
            usuario.SetSenha("123");

            negocio.AdicionaUsuario(usuario);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), "O livro selecionado não foi encontrado.")]        
        public void ApagarLivroErroTest()
        {
            Negocio negocio = new Negocio();

            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Nome Teste";
            usuario.Email = "email@123.com";
            usuario.SetSenha("123");

            negocio.AdicionaUsuario(usuario);

            Livro livro = new Livro();
            livro.Isbn = 1;
            livro.Autor = "autor teste 2";
            livro.Preco = Convert.ToDecimal(2.80);
            livro.DataPublicacao = new DateTime(2019, 1, 31);
            livro.Nome = "Um novo teste";

            negocio.AdicionarLivro(livro, usuario);

            Livro livro2 = new Livro();
            livro2.Isbn = 2;
            livro2.Autor = "Outro autor";
            livro2.Preco = Convert.ToDecimal(70.21);
            livro2.DataPublicacao = new DateTime(2019, 1, 31);
            livro2.Nome = "Um novo teste";

            negocio.ApagarLivro(livro2);
        }

        [TestMethod()]
        public void ApagarLivroSucessoTest()
        {
            Negocio negocio = new Negocio();

            Usuario usuario = new Usuario();
            usuario.NomeUsuario = "Nome Teste";
            usuario.Email = "email@123.com";
            usuario.SetSenha("123");

            negocio.AdicionaUsuario(usuario);

            Livro livro = new Livro();
            livro.Isbn = 1;
            livro.Autor = "autor teste 2";
            livro.Preco = Convert.ToDecimal(2.80);
            livro.DataPublicacao = new DateTime(2019, 1, 31);
            livro.Nome = "Um novo teste";

            negocio.AdicionarLivro(livro, usuario);            
            negocio.ApagarLivro(livro);
        }
    }
}