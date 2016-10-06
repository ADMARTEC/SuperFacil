using SuperFacil.Common.Resource.Administracao;
using System.Text;

namespace SuperFacil.Common.Validacao
{
    public class PasswordAssertionConcern
    {
        public static void AssertIsValid(string value)
        {
            AssertionConcern.AssertArgumentNotNull(value, Res_Adm_Usuario.TagSenhaInvalida);
        }

        /// <summary>
        /// Encriptar qualquer valor string que for enviado
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Texto encriptado</returns>
        public static string Encrypt(string value)
        {
            // O valor dentro das "" representa uma adicão na password para causar mais dificuldade na complexidade da password
            value += "|2d331cca-f6c0-40c0-bb43-6e32989c2881";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(value));
            System.Text.StringBuilder sbString = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sbString.Append(data[i].ToString("x2"));
            return sbString.ToString();
        }
    }
}
