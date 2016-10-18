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
     * Nome, Sobrenome, Alcunha
     * Create,Update e Deleted --- Nunca deve faltar em nenhuma classe
     */
    public class Mul_Autor : Abs_Base
    {
        #region - Propriedade -
        public int Autor_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int? Biografia_ID { get; set; }
        #endregion

        #region Relacionamento
        public virtual ICollection<Mul_Midia> Midia { get; set; }
        public virtual ICollection<Mul_Biografia> Biografia { get; set; }

        #endregion

        public void Set_Autor(int _Empresa_ID, string _Nome, string _Sobrenome, string _Alcunha, int? _Biografia_ID = null)
        {
            AssertionConcern.AssertArgumentNotNull(_Nome, Res_Base.TagNomeNull);
            AssertionConcern.AssertArgumentNotEmpty(_Nome, Res_Base.TagNomeNull);
            AssertionConcern.AssertArgumentLength(_Nome, 8, 250, Res_Base.TagNomeSize);
            AssertionConcern.AssertArgumentNotEmpty(_Alcunha, Res_Base.TagSobrenomeNull);
            
            this.Empresa_ID = _Empresa_ID;
            this.Nome = _Nome;
            this.Sobrenome = _Sobrenome;
            this.Alcunha = _Alcunha;
            this.Biografia_ID = _Biografia_ID;
        }

    }
}
