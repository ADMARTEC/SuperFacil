using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente
{
    public class Com_Cliente_Contactos
    {
        public int Contactos_ID { get; set; }
        public int Cliente_ID { get; set; }
        public int Telefone_Primario { get; set; }
        public string Email_Primario { get; set; }
        public int Telefone_Secundario { get; set; }
        public string Email_Secundario { get; set; }
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
