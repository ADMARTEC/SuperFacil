using SuperFacil.Dominio.Modelos.Comercial;
using System;

namespace SuperFacil.Dominio.Modelos.Multimidia
{
    public class Mul_Midia
    {
        #region - Propriedade -
        public int Midia_ID { get; set; }
        public int Empresa_ID { get; set; }
        public int? Parent_ID { get; set; }
        public string Designacao { get; set; }
        public string Genero { get; set; }
        public int Autor_ID { get; set; }
        public int Localizacao_ID { get; set; }
        public DateTime Ano_Lancamento { get; set; }
        public string Editora { get; set; }
        public TimeSpan Duracao { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;
        #endregion

        #region Relacionamento
        public virtual Mul_Autor Autor { get; set; }
        public virtual Com_Localizacao Localizacao { get; set; }
        #endregion        
    }
}
