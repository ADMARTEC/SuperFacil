using SuperFacil.Domain.Entities.Inquerito;
using System;
using System.Collections.Generic;

namespace SuperFacil.Domain.Entities.Sistema.Generico
{
    public class Sis_Gen_Pais
    {
        public int Pais_ID { get; set; }
        public int? Provincia_ID { get; set; }
        public int? Municipio_ID { get; set; }
        public string ISO { get; set; }
        public string Codigo { get; set; }
        public string Designacao { get; set; }
        public string Gps_Latitude { get; set; }
        public string Gps_Longitude { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool DefaultSystem { get; set; } = false;

        #region - Relacionamento -
        public virtual ICollection<Inq_Questionario> Questionario { get; set; }
        #endregion
    }
}
