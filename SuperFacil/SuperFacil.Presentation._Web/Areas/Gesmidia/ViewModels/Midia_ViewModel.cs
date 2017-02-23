using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperFacil.Presentation._Web.Areas.Gesmidia.ViewModels
{
    public class Midia_ViewModel
    {
        #region - Proprieties -
        [Key]
        public int Midia_ID { get; set; }
        [ForeignKey("FK_Autor")]
        [Display(Name ="Autor")]
        public int Autor_ID { get; set; }
        [ForeignKey("FK_Localizacao")]
        [Display(Name = "Localização")]
        public int Localizacao_ID { get; set; }
        [Required]
        [Display(Name = "Designação")]
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
        //public virtual  Autor_ViewModel Autor { get; set; }
        public Localizacao_ViewModel Localizacao { get; set; }
        #endregion

        #region - Methods -

        public Midia_ViewModel Create_vm(Midia_ViewModel _midia)
        {
            _midia.Activo = true;
            _midia.CreateUser = 1;
            _midia.CreateDate = DateTime.Now;
            _midia.UpdateUser = 1;
            _midia.UpdateDate = DateTime.Now;
            _midia.Deleted = false;
            _midia.Default = false;

            return _midia;
        }

        public Midia_ViewModel Edit_vm(Midia_ViewModel _midia)
        {
            _midia.UpdateUser = 1;
            _midia.UpdateDate = DateTime.Now;

            return _midia;
        }

        public Midia_ViewModel Delete_vm(Midia_ViewModel _midia)
        {
            _midia.UpdateUser = 1;
            _midia.UpdateDate = DateTime.Now;
            _midia.Deleted = true;

            return _midia;
        }

      
        #endregion
    }
    public enum Gerero
        {
            Masculino,
            Femenino
        }
}