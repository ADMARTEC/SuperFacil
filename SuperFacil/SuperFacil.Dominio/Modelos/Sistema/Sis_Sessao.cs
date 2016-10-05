using SuperFacil.Dominio.Modelos.Abstracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    /* 
     * Propriedades Abstratas a ter em conta:
     * Designação
     * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
     */
    public class Sis_Sessao : Abs_Base
    {
        #region - Propriedade -
        public int Sessao_ID { get; set; }
        public int Usuario_ID { get; set; }
        public string Dispositivo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        #endregion
    }
}
