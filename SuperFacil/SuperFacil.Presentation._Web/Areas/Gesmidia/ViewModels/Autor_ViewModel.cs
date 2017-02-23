using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Presentation._Web.Areas.Gesmidia.ViewModels
{
    public class Autor_ViewModel
    {

        #region - Proprieties -
        [Key]
        public int Autor_ID { get; set; }
        [Required]
        public string Nome { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        //[DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        //[DataType(DataType.Date)]
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;
        #endregion

        #region - Relations -
        public virtual ICollection<Midia_ViewModel> Midia { get; set; }
        #endregion

        #region - Methods -
        public Autor_ViewModel Create_vm(Autor_ViewModel _autor)
        {

            var result = _autor;
                      
            result.Activo = true;
            result.CreateUser = 1;
            result.CreateDate = DateTime.Now;
            result.UpdateUser = 1;
            result.UpdateDate = DateTime.Now;
            result.Deleted = false;
            result.Default = false;

            return result;
        }

        public Autor_ViewModel Edit_vm(Autor_ViewModel _autor)
        {

            var result = _autor;

            result.UpdateUser = 1;
            result.UpdateDate = DateTime.Now;

            return result;
        }

        public Autor_ViewModel Delete_vm(Autor_ViewModel _autor)
        {

            var result = _autor;

            result.UpdateUser = 1;
            result.UpdateDate = DateTime.Now;
            result.Deleted = true;

            return result;
        }
        #endregion
    }
}