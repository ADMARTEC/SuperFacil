using SuperFacil.Presentation._Web.ViewModels.Sistema.Generico;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperFacil.Presentation._Web.Areas.Inquerito.ViewModel
{
    public class Inq_Questionario_ViewModel
    {
        public Inq_Questionario_ViewModel()
        {
            Inquerito = new Inq_Inquerito_ViewModel();
            Pais = new Sis_Gen_Pais_ViewModel();
            Questionario_Resposta = new List<Inq_Questionario_Resposta_ViewModel>();
        }
        public int Questionario_ID { get; set; }

        [Required]
        public int Inquerito_ID { get; set; }

        [Required]
        [Display(Name = "Provincia")]
        public int Pais_ID { get; set; }

        [Required]
        [Display(Name = "Municipio")]
        public int Municipio_ID { get; set; }

        [Display(Name = "Observação")]
        [StringLength(200)]
        public string Designacao { get; set; }

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
        public virtual Inq_Inquerito_ViewModel Inquerito { get; set; }
        public virtual Sis_Gen_Pais_ViewModel Pais { get; set; }
        public virtual ICollection<Inq_Questionario_Resposta_ViewModel> Questionario_Resposta { get; set; }
        #endregion

        #region - Methods -
        public Inq_Questionario_ViewModel Create(Inq_Questionario_ViewModel _ViewModel)
        {
            _ViewModel.Pais_ID = _ViewModel.Municipio_ID;
            _ViewModel.Activo = true;
            _ViewModel.CreateUser = 1;
            _ViewModel.CreateDate = DateTime.Now;
            _ViewModel.UpdateUser = 1;
            _ViewModel.UpdateDate = DateTime.Now;
            _ViewModel.Deleted = false;
            _ViewModel.DefaultSystem = false;

            return _ViewModel;
        }

        public Inq_Questionario_ViewModel Edit(Inq_Questionario_ViewModel _ViewModel)
        {

            _ViewModel.Pais_ID = _ViewModel.Municipio_ID;
            _ViewModel.UpdateUser = 1;
            _ViewModel.UpdateDate = DateTime.Now;

            return _ViewModel;
        }

        public Inq_Questionario_ViewModel Delete(Inq_Questionario_ViewModel _ViewModel)
        {
            _ViewModel.Pais_ID = _ViewModel.Municipio_ID;
            _ViewModel.UpdateUser = 1;
            _ViewModel.UpdateDate = DateTime.Now;
            _ViewModel.Deleted = true;

            return _ViewModel;
        }
        #endregion
    }
}
