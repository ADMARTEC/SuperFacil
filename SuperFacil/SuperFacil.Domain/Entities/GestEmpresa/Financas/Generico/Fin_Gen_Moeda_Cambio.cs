using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Financas.Generico
{
    public class Fin_Gen_Moeda_Cambio
    {
        public int Cambio_ID { get; set; }
        public int Moeda_ID { get; set; }
        public decimal Valor { get; set; }
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
