using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;

namespace SuperFacil.Dominio.Modelos.Multimidia
{
    public class Mul_Autor
    {
        #region - Construtor -
        public Mul_Autor()
        {
            this.Midia = new List<Mul_Midia>();
        }
        #endregion

        #region - Propriedade -
        public int Autor_ID { get; set; }
        public int Empresa_ID { get; set; }
        public string Nome { get; set; }
        public int? Nota_ID { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;
        #endregion

        #region Relacionamento
        public virtual ICollection<Mul_Midia> Midia { get; set; }
        public virtual Glo_Nota Nota { get; set; }

        #endregion

    }
}
