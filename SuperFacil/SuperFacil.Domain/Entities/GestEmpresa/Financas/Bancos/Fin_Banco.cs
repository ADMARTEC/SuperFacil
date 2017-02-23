using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Financas.Bancos
{
    public class Fin_Banco
    {
        public int Banco_ID { get; set; }
        public int Parent_ID { get; set; }
        public string Designacao { get; set; }
        public string Morada { get; set; }
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
