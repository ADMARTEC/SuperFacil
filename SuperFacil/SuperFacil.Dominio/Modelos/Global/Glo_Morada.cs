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
    * Designacao, Master
    * Create,Update e Deleted --- Nunca deve faltar em nenhuma classe
    */
    public class Glo_Morada : Abs_Base
    {
        public Glo_Morada()
        {
            this.Empresa = new List<Adm_Empresa>();
            this.Pais = new List<Glo_Pais>();
        }

        #region - Propriedade -
        public int Morada_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int Pais_ID { get; set; }
        #endregion

        public virtual ICollection<Adm_Empresa> Empresa { get; set; }
        public virtual ICollection<Glo_Pais> Pais { get; set; }

        public void Set_Morada(int _Empresa, int _Pais, string _Designacao)
        {

        }
    }
}
