using System;
using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Presentation._Web.Areas.Gesmidia.ViewModels
{
    public class Localizacao_ViewModel
    {
   
        #region - Prorieties -
        [Key]
        public int Localizacao_ID { get; set; }
        [Required]
        [Display(Name ="Designação")]
        public string Designacao { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;
        #endregion

        #region - Relations -
        // public virtual ICollection<Midia_ViewModel> Midia { get; set; }
        #endregion

        #region - Methods -
        public Localizacao_ViewModel Create_vm(Localizacao_ViewModel _autor)
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

        public Localizacao_ViewModel Edit_vm(Localizacao_ViewModel _autor)
        {

            var result = _autor;

            result.UpdateUser = 1;
            result.UpdateDate = DateTime.Now;

            return result;
        }

        public Localizacao_ViewModel Delete_vm(Localizacao_ViewModel _autor)
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