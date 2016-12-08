using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Modelos.Recursos_Humano;
using System;
using System.Collections.Generic;

namespace SuperFacil.Dominio.Modelos.Administracao
{
    public class Adm_Usuario 
    {
        #region - Construtor -
        #endregion

        #region - Propriedade -
        public int Usuario_ID { get; set; }
        public int Empresa_ID { get; set; } // Referencia a tabela de Empresa
        public int Perfil_ID { get; set; } // Referencia a tabela de Perfil
        public int? Funcionario_ID { get; set; } // Caso o usuario seja funcionario
        public string Nome { get; set; }
        public int? Imagem_ID { get; set; }
        public string Usuario_login { get; set; }
        public string Senha { get; set; }
        public DateTime? Data_Limite { get; set; }
        public bool Activo { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; }
        public bool Default { get; set; } = false;
        #endregion

        #region - Relacionamento -
        public virtual Adm_Empresa Empresa { get; set; }
        //public virtual Adm_Perfil Perfil { get; set; }
       // public virtual Reh_Funcionario Funcionario { get; set; }
        public virtual Glo_Imagem Imagem { get; set; }

        #endregion                
    }
}
