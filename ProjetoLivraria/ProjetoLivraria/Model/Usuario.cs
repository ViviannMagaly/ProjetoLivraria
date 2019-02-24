using ProjetoLivraria.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLivraria.Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }

        public string Senha { get; private set; }

        public void SetSenha(string senha)
        {
            this.Senha = NegocioSenha.GerarMD5(senha);
        }
    }
}