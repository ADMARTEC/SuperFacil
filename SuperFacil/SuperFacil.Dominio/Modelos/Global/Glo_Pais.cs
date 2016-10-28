using SuperFacil.Common.Resource;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Modelos.Abstracao;
using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Global
{
    /* 
    * Propriedades Abstratas a ter em conta:
    * Designação
    * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
    * Esta tabela não precisa relação com a empresa por que somente o pessoal interno do projecto vai carregar dados
    */
    public class Glo_Pais : Abs_Base
    {
        #region - Propriedade -
        public int Pais_ID { get; set; }
        /// <summary>
        /// Se preencher este campo estará a fazer referencia a uma provincia ou municipio
        /// isso através da recursividade.
        /// </summary>
        public int? Parent_ID { get; set; }    
        #endregion

        #region - Relacionamento -
        public virtual Glo_Morada Morada { get; set; }
        #endregion

        #region - Metodos -
        public void Set_Pais(string _Designacao, int? _Parent = null)
        {
            AssertionConcern.AssertArgumentNotNull(_Designacao, Res_Base.TagDesignacaoNull);
            AssertionConcern.AssertArgumentNotEmpty(_Designacao, Res_Base.TagDesignacaoNull);
        
            this.Parent_ID = _Parent;
            this.Designacao = _Designacao;
        }
        #endregion


    }
}
