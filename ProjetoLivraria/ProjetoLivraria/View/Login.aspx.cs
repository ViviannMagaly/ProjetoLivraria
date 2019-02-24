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
    public partial class Login : System.Web.UI.Page
    {
        Negocio Negocio;

        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio = Session["Negocio"] as Negocio;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = Negocio.Login(edtEmail.Text, edtSenha.Text);
                Session["UsuarioLogado"] = usuario;
                Response.Redirect("Livros.aspx");
            }
            catch (Exception ex)
            {
                //erro
            }
        }
    }
}