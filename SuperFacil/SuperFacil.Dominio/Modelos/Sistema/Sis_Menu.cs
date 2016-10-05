﻿using SuperFacil.Dominio.Modelos.Abstracao;
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
    public class Sis_Menu : Abs_Base
    {
        #region - Propriedade -
        public int Menu_ID { get; set; }
        public int Parent_ID { get; set; }
        #endregion
    }
}
