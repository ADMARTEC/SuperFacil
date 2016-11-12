using SuperFacil.Dominio.Modelos.Abstracao;
using SuperFacil.Dominio.Modelos.Administracao;
using System.Collections.Generic;

namespace SuperFacil.Dominio.Modelos.Global
{
    /*
     * Propriedades Abstratas a ter em conta:
     * Designacao, Master
     * Create,Update e Deleted --- Nunca deve faltar em nenhuma classe
     */
    public class Glo_Morada : Abs_Base
    {
        #region - Construtor -      
        public Glo_Morada()
        {
            this.Empresa = new List<Adm_Empresa>();
            this.Pais = new List<Glo_Pais>();
        }
        #endregion

        #region - Propriedade -
        public int Morada_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int Pais_ID { get; set; }
        #endregion

        #region - Relacionamento -        
        public virtual ICollection<Adm_Empresa> Empresa { get; set; }
        public virtual ICollection<Glo_Pais> Pais { get; set; }
        #endregion

        #region - Methods
        public void Set_Morada(int _Empresa, int _Pais, string _Designacao)
        {
            this.Empresa_ID = _Empresa;
            this.Pais_ID = _Pais;
            this.Designacao = _Designacao;
        }
        #endregion
    }
}
