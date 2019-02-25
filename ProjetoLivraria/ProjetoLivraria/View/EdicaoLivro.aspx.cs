using ProjetoLivraria.Controller;
using ProjetoLivraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLivraria.View
{
    public partial class NovoLivro : System.Web.UI.Page
    {
        Negocio Negocio;
        Usuario UsuarioLogado;

        Livro LivroSelecionado;

        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio = Session["Negocio"] as Negocio;
            UsuarioLogado = Session["UsuarioLogado"] as Usuario;
            LivroSelecionado = Session["LivroSelecionado"] as Livro;

            if (!IsPostBack && !IsCallback)
            {
                if (Session["LivroSelecionado"] != null)
                {
                    ObtemDadosLivroSelecionado();
                    edtTitulo.Text = "Editar Livro";
                }
            }
        }

        private void ObtemDadosLivroSelecionado()
        {
            edtISBN.Text = LivroSelecionado.Isbn.ToString();
            edtAutor.Text = LivroSelecionado.Autor;
            edtNome.Text = LivroSelecionado.Nome;
            edtPreco.Text = LivroSelecionado.Preco.ToString();
            edtDataPublicacao.Text = LivroSelecionado.DataPublicacao.ToString();

            edtISBN.Enabled = false;
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (LivroSelecionado == null) // Novo Item 
                {
                    Livro livro = new Livro();
                    livro.Isbn = Convert.ToInt32(edtISBN.Text);
                    livro.Autor = edtAutor.Text;
                    livro.Nome = edtNome.Text;
                    livro.Preco = Convert.ToDecimal(edtPreco.Text);
                    livro.DataPublicacao = Convert.ToDateTime(edtDataPublicacao.Text);

                    Negocio.AdicionarLivro(livro, UsuarioLogado);
                    Response.Redirect("Livros.aspx");
                }
                else //Edição livro
                {
                    LivroSelecionado.Isbn = Convert.ToInt32(edtISBN.Text);
                    LivroSelecionado.Autor = edtAutor.Text;
                    LivroSelecionado.Nome = edtNome.Text;
                    LivroSelecionado.Preco = Convert.ToDecimal(edtPreco.Text);
                    LivroSelecionado.DataPublicacao = Convert.ToDateTime(edtDataPublicacao.Text);
                    
                    Response.Redirect("Livros.aspx");
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensagem", string.Format("Alerta('{0}');", ex.Message), true);
            }
        }
    }
}