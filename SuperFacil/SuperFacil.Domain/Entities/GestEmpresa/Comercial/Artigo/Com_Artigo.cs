using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Comercial.Artigo
{
    public class Com_Artigo
    {
        public int Artigo_ID { get; set; }
        public int Familia_ID { get; set; }
        public string Codigo { get; set; }
        public string Designacao { get; set; }
        public bool Tipo { get; set; } = true; // true = Artigo ; false = Serviço
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
