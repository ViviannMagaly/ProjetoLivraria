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
        Usuario UsuarioLogado;

        protected void Page_Load(object sender, EventArgs e)
        {
            Negocio = Session["Negocio"] as Negocio;
            UsuarioLogado = Session["UsuarioLogado"] as Usuario;

            if (!IsPostBack && !IsCallback)
            {
                if (UsuarioLogado != null)
                {
                    edtEmail.Enabled = false;
                    edtNome.Enabled = false;
                    edtSenha.Enabled = false;
                    edtConfirmarSenha.Enabled = false;

                    btnConfirmar.Visible = false;
                    CarregarMeusDados();
                }
                else
                {
                    edtEmail.Text = null;
                    edtNome.Text = null;
                    edtSenha.Text = null;
                    edtConfirmarSenha.Text = null;

                    edtEmail.Enabled = true;
                    edtNome.Enabled = true;
                    edtSenha.Enabled = true;
                    edtConfirmarSenha.Enabled = true;

                    btnConfirmar.Visible = true;
                }
            }
        }

        private void CarregarMeusDados()
        {
            edtEmail.Text = UsuarioLogado.Email;
            edtNome.Text = UsuarioLogado.NomeUsuario;
            edtSenha.Text = UsuarioLogado.Senha;
            edtConfirmarSenha.Text = UsuarioLogado.Senha;
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (UsuarioLogado == null) //novo usuario
            {
                string senha = NegocioSenha.GerarMD5(edtSenha.Text);

                if (NegocioSenha.ComparaMd5Hash(edtConfirmarSenha.Text, senha))
                {
                    try
                    {
                        Usuario usuario = new Usuario();
                        usuario.NomeUsuario = edtNome.Text;
                        usuario.Email = edtEmail.Text;
                        usuario.SetSenha(edtSenha.Text);

                        Negocio.AdicionaUsuario(usuario);
                        Session["UsuarioLogado"] = usuario;
                        this.Response.Redirect("Livros.aspx");
                    }
                    catch (Exception ex)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "mensagem", string.Format("Alerta('{0}');", ex.Message), true);
                    }
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "mensagem", string.Format("Alerta('{0}');", "A senha e a confirmação de senha precisam ser iguais."), true);
                }
            }
        }
    }
}