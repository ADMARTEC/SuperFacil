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
    * Designacao
    * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
    */
    public class Glo_Imagem : Abs_Base
    {
        public Glo_Imagem()
        {

        }

        public int Imagem_ID { get; set; }
        public int Empresa_ID { get; set; }

        public virtual Adm_Usuario Usuario { get; set; }
        public virtual Adm_Empresa Empresa { get; set; }


    }
}
