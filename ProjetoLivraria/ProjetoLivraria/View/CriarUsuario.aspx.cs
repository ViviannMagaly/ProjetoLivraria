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
    public partial class CriarUsuario : System.Web.UI.Page
    {
        Negocio Negocio;

        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio = Session["Negocio"] as Negocio;
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            string senha = NegocioSenha.GerarMD5(edtSenha.Text);

            if (NegocioSenha.ComparaMd5Hash(edtConfirmarSenha.Text, senha))
            {
                Usuario usuario = new Usuario();
                usuario.NomeUsuario = edtNome.Text;
                usuario.Email = edtEmail.Text;
                usuario.SetSenha(edtSenha.Text);

                Negocio.AdicionaUsuario(usuario);
                Session["UsuarioLogado"] = usuario;
            }
            else
            {
                // Erro senha
            }
        }

        protected void edtEmail_TextChanged(object sender, EventArgs e)
        {
            //Validação email
        }
    }
}