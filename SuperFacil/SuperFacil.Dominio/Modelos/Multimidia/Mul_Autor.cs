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
        #endregion
    }
}
