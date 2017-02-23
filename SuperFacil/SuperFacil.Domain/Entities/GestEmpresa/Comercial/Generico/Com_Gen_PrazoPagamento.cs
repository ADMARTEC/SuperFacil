using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Comercial.Generico
{
    public class Com_Gen_PrazoPagamento
    {
        public int PrazoPagamento_ID { get; set; }
        public int Tempo_Dias { get; set; }
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
