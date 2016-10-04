using SuperFacil.Common.Resource.Administracao;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Modelos.Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Administracao
{
    public class Adm_Usuario : Abs_Base
    {

        #region - Propriedade -
        public int Usuario_ID { get; set; }
        public int Empresa_ID { get; set; } // Referencia a tabela de Empresa
        public int Perfil_ID { get; set; } // Referencia a tabela de Perfil
        public string Usuario_login { get; set; }
        public string Senha { get; private set; }
        public DateTime Data_Limite { get; set; }
        #endregion

        /// <summary>
        /// Atribuição do Nome e usuario
        /// </summary>
        /// <param name="_Empresa"></param>
        /// <param name="_Nome"></param>
        /// <param name="_Usuario"></param>
        public void Set_Usuario(int _Empresa, string _Nome, string _Usuario)
        {
            this.Nome = _Nome;
            this.Usuario_login = _Usuario;
        }

        /// <summary>
        /// Atribuição completa dos dados do usuario
        /// </summary>
        /// <param name="_Empresa"></param>
        /// <param name="_Perfil"></param>
        /// <param name="_Nome"></param>
        /// <param name="_Usuario"></param>
        /// <param name="_Data_Limite"></param>
        public void Set_Usuario(int _Empresa, int _Perfil, string _Nome, string _Usuario, DateTime _Data_Limite)
        {
            this.Empresa_ID = _Empresa;
            this.Perfil_ID = _Perfil;
            this.Nome = _Nome;
            this.Usuario_login = _Usuario;
            this.Data_Limite = _Data_Limite;
        }

        /// <summary>
        /// Atribuição da senha usando confirmação
        /// </summary>
        /// <param name="_senha"></param>
        /// <param name="_confirmar"></param>
        public void Set_Senha(string _senha, string _confirmar)
        {
            // Validação da senha
            AssertionConcern.AssertArgumentNotNull(_senha,Adm_Res_Usuario.TagSenhaNull);       
            AssertionConcern.AssertArgumentEquals(_senha, _confirmar, Adm_Res_Usuario.TagSenhaDiferente);
            AssertionConcern.AssertArgumentLength(_senha, 4, 20, Adm_Res_Usuario.TagSenhaTamanho);

            // Esta atribuição será feito somente se as condições a cima forem validas
            this.Senha = _senha;
        }



    }
}
