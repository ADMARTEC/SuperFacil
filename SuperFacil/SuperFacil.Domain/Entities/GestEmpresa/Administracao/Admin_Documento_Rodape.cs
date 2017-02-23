using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Administracao
{
    public class Admin_Documento_Rodape
    {
        public int Documento_Rodape_ID { get; set; }
        public int Documento_ID { get; set; }
        public string Designacao { get; set; }
        public int Numero_Linha { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool DefaultSystem { get; set; } = false;

    }
}
