using System;

namespace SuperFacil.Presentation._Web.Areas.Inquerito.ViewModel
{
    public class Inq_Questionario_Resposta_ViewModel
    {
        public int Questionario_Resposta_ID { get; set; }
        public int Questionario_ID { get; set; }
        public int Inquerito_Pergunta_ID { get; set; }
        public int Inquerito_Resposta_ID { get; set; }
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
        public virtual Inq_Questionario_ViewModel Questionario { get; set; }
        public virtual Inq_Inquerito_Pergunta_ViewModel Inquerito_Pergunta { get; set; }
        public virtual Inq_Inquerito_Resposta_ViewModel Inquerito_Resposta { get; set; }
        #endregion

        #region - Methods -
        public Inq_Questionario_Resposta_ViewModel Create(Inq_Questionario_Resposta_ViewModel _ViewModel)
        {

            var result = _ViewModel;

            result.Activo = true;
            result.CreateUser = 1;
            result.CreateDate = DateTime.Now;
            result.UpdateUser = 1;
            result.UpdateDate = DateTime.Now;
            result.Deleted = false;
            result.DefaultSystem = false;

            return result;
        }

        public Inq_Questionario_Resposta_ViewModel Edit(Inq_Questionario_Resposta_ViewModel _ViewModel)
        {

            var result = _ViewModel;

            result.UpdateUser = 1;
            result.UpdateDate = DateTime.Now;

            return result;
        }

        public Inq_Questionario_Resposta_ViewModel Delete(Inq_Questionario_Resposta_ViewModel _ViewModel)
        {

            var result = _ViewModel;

            result.UpdateUser = 1;
            result.UpdateDate = DateTime.Now;
            result.Deleted = true;

            return result;
        }
        #endregion
    }
}

