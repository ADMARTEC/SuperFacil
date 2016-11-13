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
     * Notas
     * * Create,Update e Deleted * --- Nunca deve faltar em nenhuma classe
     */
    public class Mul_Biografia : Abs_Base
    {
        #region Construtor
        protected Mul_Biografia() { }
        #endregion

        #region - Propriedade -
        public int Biografia_ID { get; set; }
        public int Empresa_ID { get; set; }
        #endregion

        #region Relacionamento
        public virtual Mul_Autor Autor { get; set; }
        #endregion

        #region Metodos
        public void Set_Biografia(int _Empresa_ID,string _Notas)
        {
            AssertionConcern.AssertArgumentLength(_Notas, 500, Res_Base.TagNotaSize);

            this.Designacao = _Notas;
            this.Empresa_ID = _Empresa_ID;
        }
        #endregion

    }

}
