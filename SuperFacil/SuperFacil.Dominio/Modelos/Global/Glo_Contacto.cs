using SuperFacil.Dominio.Modelos.Abstracao;
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
        #region - Propriedade -  
        public int Contacto_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Responsavel { get; set; } // Se o contacto pertencer a uma pessoa juridica, deve ser preenchido  com o nome de uma pessoa física
        #endregion
    }

}
