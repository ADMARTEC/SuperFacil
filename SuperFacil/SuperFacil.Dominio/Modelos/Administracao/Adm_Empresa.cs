using SuperFacil.Dominio.Modelos.Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Administracao
{
    /* 
     * Propriedades Abstratas a ter em conta:
     * Designacao,NIF,Nota
     * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
     */
    public class Adm_Empresa : Abs_Base
    {
        /// <summary>
        /// Este campo deve estar presente em todas as classes, isso por causa do Multiempresa
        /// </summary>
        public int Empresa_ID { get; set; }
        public int Parent_ID { get; set; }
        public int Contacto_ID { get; set; }
        public int Morada_ID { get; set; }
    }
}
