using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Administracao
{
    /* 
     * Propriedades Abstratas a ter em conta:
     * Designacao
     * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
     */
    public class Adm_Perfil
    {
        #region - Propriedade -
        public int Perfil_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int HorarioAcesso_ID { get; set; }
        #endregion
    }
}
