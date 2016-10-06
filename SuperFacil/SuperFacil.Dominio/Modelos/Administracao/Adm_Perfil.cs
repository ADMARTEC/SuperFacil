using SuperFacil.Common.Resource;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Modelos.Abstracao;

namespace SuperFacil.Dominio.Modelos.Administracao
{
    /* 
     * Propriedades Abstratas a ter em conta:
     * Designacao
     * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
     */
    public class Adm_Perfil : Abs_Base
    {
        #region - Propriedade -
        public int Perfil_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int? Parent_ID { get; set; }
        public int HorarioAcesso_ID { get; set; }
        #endregion

        #region - Metodos -
        public void Set_Perfil(int _Empresa_ID, int _HorarioAcesso_ID, string _Designacao, int? _Parent_ID = null)
        {
            AssertionConcern.AssertArgumentNotNull(_Designacao, Res_Base.TagDesignacaoNull);
            AssertionConcern.AssertArgumentNotEmpty(_Designacao, Res_Base.TagDesignacaoNull);

            this.Empresa_ID = _Empresa_ID;
            this.Parent_ID = _Parent_ID;
            this.HorarioAcesso_ID = _HorarioAcesso_ID;
            this.Designacao = _Designacao;
        }
        #endregion
    }
}
