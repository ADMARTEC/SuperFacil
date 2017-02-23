using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Comercial.Artigo
{
    public class Com_Artigo_Preco
    {
        public int Artigo_Preco_ID { get; set; }
        public int Artigo_ID { get; set; }
        public int TabelaPreco_ID { get; set; }
        public decimal Preco { get; set; } = 0;
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
