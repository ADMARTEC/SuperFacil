using SuperFacil.Common.Resource;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Modelos.Abstracao;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    /* 
    * Propriedades Abstratas a ter em conta:
    * Designação
    * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
    */
    public class Sis_Menu : Abs_Base
    {
        #region - Propriedade -
        public int Menu_ID { get; set; }
        public int? Parent { get; set; }
        public int Modulo_ID { get; set; }
        #endregion

        #region - Relacionamento -
        public virtual Sis_Modulo Modulo { get; set; }
        #endregion

        #region - Methods -    
        public void Set_Menu(int? _Parent, string _Designacao)
        {
            AssertionConcern.AssertArgumentNotEmpty(_Designacao, Res_Base.TagDesignacaoNull);
            AssertionConcern.AssertArgumentNotNull(_Designacao, Res_Base.TagDesignacaoNull);
            AssertionConcern.AssertArgumentLength(_Designacao, 4, 50, Res_Base.TagDesignacaoSize);
            
            this.Parent = _Parent;
            this.Designacao = _Designacao;
        }
        #endregion
    }
}
