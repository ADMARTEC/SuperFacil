using System;

namespace SuperFacil.Dominio.Modelos.Global
{
    public class Glo_Contacto 
    {     
        #region - Propriedade -  
        public int Contacto_ID { get; set; }
        public int Telefone { get; set; }
        public int? Telefone_2 { get; set; }
        public string Email { get; set; }
        public string Email_2 { get; set; }
        public string Responsavel { get; set; } // Se o contacto pertencer a uma pessoa juridica, deve ser preenchido  com o nome de uma pessoa física
        public bool Master { get; set; } = false;
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;
        #endregion   
    }
}
