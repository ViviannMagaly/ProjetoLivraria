using ProjetoLivraria.Controller;
using ProjetoLivraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLivraria
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio negocio = new Negocio();
            Session["Negocio"] = negocio;

            negocio.DadosParaTeste();
            //Usuario usuario = negocio.Login("1234@1234.com", "1234");
            //Session["UsuarioLogado"] = usuario;

            if (Session["UsuarioLogado"] != null)
                Response.Redirect("Livros.aspx");

            if (Request.Params["msg"] != null)
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensagem", string.Format("Alerta('{0}');", "Por favor, realize o login."), true);
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {            
            Response.Redirect("Login.aspx");
        }

        protected void btnCriarConta_Click(object sender, EventArgs e)
        {
            Response.Redirect("CriarUsuario.aspx");
        }
    }
}