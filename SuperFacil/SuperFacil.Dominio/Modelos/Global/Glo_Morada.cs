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
    * Class_ID, Class_Nome, Designacao, Master
    * Create,Update e Deleted --- Nunca deve faltar em nenhuma classe
    */
    public class Glo_Morada : Abs_Base
    {
        public Glo_Morada()
        {
            this.Empresa = new List<Adm_Empresa>();
        }
        #region - Propriedade -
        public int Morada_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int Pais_ID { get; set; }
        #endregion

        public virtual ICollection<Adm_Empresa> Empresa { get; set; }
    }
}
