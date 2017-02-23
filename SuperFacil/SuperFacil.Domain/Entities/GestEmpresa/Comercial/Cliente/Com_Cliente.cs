using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente
{
    public class Com_Cliente
    {
        public int Cliente_ID { get; set; }
        public string Nome { get; set; }
        public string NIF { get; set; }
        public string Morada { get; set; }
        public string Nota { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
        public decimal Saldo { get { return (Debito - Credito); } private set { Saldo = (Debito - Credito); } }
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
