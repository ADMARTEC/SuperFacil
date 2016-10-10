﻿using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Recursos_Humano
{
    public class Reh_Funcionario
    {
        public int Funcionario_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int Usuario_ID { get; set; }
        public virtual Adm_Usuario Usuario { get; set; }
    }
}
