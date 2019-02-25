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
    public partial class Livros : System.Web.UI.Page
    {
        Negocio Negocio;
        List<Livro> ListaLivros;

        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio = Session["Negocio"] as Negocio;

            Usuario usuario = Session["UsuarioLogado"] as Usuario;

            ListaLivros = Negocio.ObtemLivros();
            grdLivros.DataSource = ListaLivros;
            grdLivros.DataBind();
        }

        protected void btnAdicionar_Click(object sender, EventArgs e)
        {
            Session["LivroSelecionado"] = null;
            Response.Redirect("EdicaoLivro.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Livro livroSelecionado = ListaLivros[grdLivros.SelectedIndex];

            Session["LivroSelecionado"] = livroSelecionado;
            Response.Redirect("EdicaoLivro.aspx");
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            Livro livroSelecionado = ListaLivros[grdLivros.SelectedIndex];
            Negocio.ApagarLivro(livroSelecionado);
            Response.Redirect("Livros.aspx");
        }
    }
}