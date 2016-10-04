using System;

namespace SuperFacil.Dominio.Modelos.Abstracao
{
    /// <summary>
    /// Campos obrigatorios em todas as classes, de modo a termos o
    /// registo de quem executou cada operação.
    /// </summary>
    public abstract class Abs_Crud: Abs_Pessoa
    {
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; }

        /// <summary>
        /// Este campo serve para indicar se o dado é padrão caso seja não deve ser eliminado.
        /// Por defeito o valor inicial é false
        /// </summary>
        public bool Default { get; set; } = false;
    }
}
