using System;

namespace SuperFacil.Dominio.Modelos.Abstracao
{
    /// <summary>
    /// Campos obrigatorios em todas as classes, de modo a termos o
    /// registo de quem executou cada operação.
    /// </summary>
    public abstract class Abs_Cud : Abs_Pessoa
    {
        #region - Propriedade -
        public bool Activo { get; set; }
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
        #endregion

        #region - Metodos -
        public void Set_Cud(bool _Activo, int _CreateUser, DateTime _CreateDate, int _UpdateUser, DateTime _UpdateDate, bool _Deleted, bool _Default)
        {
            this.Activo = _Activo;
            this.CreateUser = _CreateUser;
            this.CreateDate = _CreateDate;
            this.UpdateUser = _UpdateUser;
            this.UpdateDate = _UpdateDate;
            this.Deleted = _Deleted;
            this.Default = _Default;
        }

        public void Set_Cud_Update(bool _Activo, int _UpdateUser, DateTime _UpdateDate, bool _Default)
        {
            this.Activo = _Activo;
            this.UpdateUser = _UpdateUser;
            this.UpdateDate = _UpdateDate;
            this.Default = _Default;
        }

        public void Set_Cud_Update(bool _Activo, int _UpdateUser, DateTime _UpdateDate)
        {
            this.Activo = _Activo;
            this.UpdateUser = _UpdateUser;
            this.UpdateDate = _UpdateDate;      
        }

        public void Set_Cud_Create(int _Usuario, DateTime _CreateDate, bool _Default)
        {
            this.Activo = true;
            this.CreateUser = _Usuario;
            this.CreateDate = _CreateDate;
            this.UpdateUser = _Usuario;
            this.UpdateDate = _CreateDate;
            this.Deleted = false;
            this.Default = _Default;
        }

        public void Set_Cud_Delete(int _Usuario, DateTime _CreateDate, bool _Delete = true)
        {
            this.UpdateUser = _Usuario;
            this.UpdateDate = _CreateDate;
            this.Deleted = _Delete;
        }

        #endregion
    }
}
