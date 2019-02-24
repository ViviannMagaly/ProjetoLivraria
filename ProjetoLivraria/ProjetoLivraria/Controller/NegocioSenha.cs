using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ProjetoLivraria.Controller
{
    public class NegocioSenha
    {
        public static string GerarMD5(string Senha)
        {
            // criptografia MD5
            MD5 md5Hasher = MD5.Create();

            // Criptografa o valor passado
            byte[] valorCriptografado = md5Hasher.ComputeHash(Encoding.Default.GetBytes(Senha));

            StringBuilder str = new StringBuilder();

            for (int i = 0; i < valorCriptografado.Length; i++)
            {
                str.Append(valorCriptografado[i].ToString("x2"));
            }

            // retorna o valor criptografado como string
            return str.ToString();
        }

        public static bool ComparaMd5Hash(string valor, string valorCriptografado)
        {
            string NovoValorCriptografado = GerarMD5(valor);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (comparer.Compare(NovoValorCriptografado, valorCriptografado) == 0)
                return true;
            else
                return false;
        }
    }
}