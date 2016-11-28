using System;

namespace SuperFacil.Dominio.Modelos.Global
{
    public class Glo_Imagem 
    {
        public int Imagem_ID { get; set; }
        public string Designacao { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;       
    }
}
