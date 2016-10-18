using SuperFacil.Common.Resource;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Modelos.Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Multimidia
{
    /*
     * Propriedades Abstratas a ter em conta:
     * Descrição, Notas
     * * Create,Update e Deleted * --- Nunca deve faltar em nenhuma classe
     */
    public class Mul_Biografia : Abs_Base
    {
        #region - Propriedade -
        public int Biografia_ID { get; set; }
        public int Empresa_ID { get; set; }
        #endregion

        public void Set_Biografia(String _Designacao, int Autor_ID, int _Empresa_ID)
        {
            AssertionConcern.AssertArgumentLength(_Designacao, 500, Res_Base.TagNomeSize);
            this.Designacao = _Designacao;
            this.Empresa_ID = _Empresa_ID;
           
        }

    }

}
