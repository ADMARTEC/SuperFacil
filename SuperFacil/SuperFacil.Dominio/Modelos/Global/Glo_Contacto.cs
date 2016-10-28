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
     * Class_ID, Class_Nome, Master,
     * Create,Update e Deleted  ---Nunca deve faltar em nenhuma classe
     */
    public class Glo_Contacto : Abs_Base
    {
        public Glo_Contacto()
        {
            this.Empresa = new List<Adm_Empresa>();
        }
      
        #region - Propriedade -  
        public int Contacto_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Responsavel { get; set; } // Se o contacto pertencer a uma pessoa juridica, deve ser preenchido  com o nome de uma pessoa física
        #endregion

        public virtual ICollection<Adm_Empresa> Empresa { get; set; }
    }

}
