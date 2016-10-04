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
        public string Usuario { get; set; }
        public string Senha { get; private set; }
        #endregion
        
        /// <summary>
        /// Atribuição de senha usando confirmação
        /// </summary>
        /// <param name="_senha"></param>
        /// <param name="_confirmar"></param>
        public void Set_Senha(string _senha, string _confirmar)
        {
            this.Senha = _senha;
        }

      

    }
}
