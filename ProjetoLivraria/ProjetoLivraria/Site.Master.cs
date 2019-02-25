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
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptInclude(this, this.GetType(), "Livraria", @"\Scripts\Livraria.js");
            ScriptManager.RegisterClientScriptInclude(this, this.GetType(), "jquery-1.10.2", @"https://code.jquery.com/jquery-1.10.2.js");
            ScriptManager.RegisterClientScriptInclude(this, this.GetType(), "jquery-3.3.1.slim.min", @"https://code.jquery.com/jquery-3.3.1.slim.min.js");
            ScriptManager.RegisterClientScriptInclude(this, this.GetType(), "bootstrap.min", @"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js");
            ScriptManager.RegisterClientScriptInclude(this, this.GetType(), "popper", @"https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js");
            ScriptManager.RegisterClientScriptInclude(this, this.GetType(), "Ajax Jquery", @"https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js");

            if (!this.Page.AppRelativeVirtualPath.Contains("Default") && Session["UsuarioLogado"] == null)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "mensagem", string.Format("Alerta('{0}');", "Por favor, realize o login."), true);
                Response.Redirect("Default.aspx");
            }
        }
    }
}