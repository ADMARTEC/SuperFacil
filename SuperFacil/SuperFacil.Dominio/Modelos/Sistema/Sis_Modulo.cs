using SuperFacil.Common.Resource;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Modelos.Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    /* 
   * Propriedades Abstratas a ter em conta:
   * Designacao
   * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
   */
    public class Sis_Modulo : Abs_Base
    {
        public Sis_Modulo()
        {
            this.Menu = new List<Sis_Menu>();
        }

        #region - Propriedade -
        public int Modulo_ID { get; set; }
        public int? Parent { get; set; }
        #endregion

        public virtual ICollection<Sis_Menu> Menu { get; set; }

        public void Set_Modulo(int? _Parent, string _Designacao)
        {
            AssertionConcern.AssertArgumentNotEmpty(_Designacao,Res_Base.TagDesignacaoNull);
            AssertionConcern.AssertArgumentNotNull(_Designacao, Res_Base.TagDesignacaoNull);
            AssertionConcern.AssertArgumentLength(_Designacao,4,50, Res_Base.TagDesignacaoSize);
            
            this.Parent = _Parent;
            this.Designacao = _Designacao;
        }
    }
}
