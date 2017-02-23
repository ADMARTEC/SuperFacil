using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Financas.Bancos
{
    public class Fin_Banco_Conta
    {
        public int Banco_Conta_ID { get; set; }
        public int Banco_ID { get; set; }
        public string Conta { get; set; }
        public string IBAN { get; set; }
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
