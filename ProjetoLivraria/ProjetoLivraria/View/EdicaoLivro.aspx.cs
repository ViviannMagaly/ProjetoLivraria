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

            if ((Request.Params["TipoPagina"] == "P"))
            {
                btnConfirmar.Visible = false;
                btnPesquisar.Visible = true;
                edtTitulo.Text = "Pesquisar Livro";
            }
            else
            {
                btnConfirmar.Visible = true;
                btnPesquisar.Visible = false;
            }

            if (!IsPostBack && !IsCallback)
            {
                if (Session["LivroSelecionado"] != null)
                {
                    ObtemDadosLivroSelecionado();
                    edtTitulo.Text = "Editar Livro";
                } else
                {
                    edtISBN.Text = null;
                    edtAutor.Text = null;
                    edtNome.Text = null;
                    edtPreco.Text = null;
                    edtDataPublicacao.Text = null;
                }
            }
        }

        private void ObtemDadosLivroSelecionado()
        {
            edtISBN.Text = LivroSelecionado.Isbn.ToString();
            edtAutor.Text = LivroSelecionado.Autor;
            edtNome.Text = LivroSelecionado.Nome;
            edtPreco.Text = LivroSelecionado.Preco.ToString().Replace(',', '.');
            edtDataPublicacao.Text = LivroSelecionado.DataPublicacao.Date.ToString("yyyy-MM-dd");

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

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Livros.aspx");
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            Livro livroPesquisa = new Livro();

            if (edtISBN.Text != "")
                livroPesquisa.Isbn = Convert.ToInt32(edtISBN.Text);

            if (edtAutor.Text != "")
                livroPesquisa.Autor = edtAutor.Text;

            if (edtNome.Text != "")
                livroPesquisa.Nome = edtNome.Text;

            if (edtPreco.Text != "")
                livroPesquisa.Preco = Convert.ToDecimal(edtPreco.Text);

            if (edtDataPublicacao.Text != "")
                livroPesquisa.DataPublicacao = Convert.ToDateTime(edtDataPublicacao.Text);

            Session["LivroPesquisa"] = livroPesquisa;

            Response.Redirect("Livros.aspx?TipoPagina=P");
        }
    }
}