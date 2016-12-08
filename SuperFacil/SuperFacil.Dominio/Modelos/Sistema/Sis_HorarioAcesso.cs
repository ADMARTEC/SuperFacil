using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    public class Sis_HorarioAcesso
    {
        #region - Construtor -       
        public Sis_HorarioAcesso()
        {
            this.Perfil = new HashSet<Adm_Perfil>();
        }
        #endregion

        #region - Propriedade -        
        public int HorarioAcesso_ID { get; set; }
        public int Empresa_ID { get; set; }
        public Int16 Primeiro_Dia { get; set; } // 2 = Segunda
        public Int16 Ultimo_Dia { get; set; } // 7 = Domingo
        public TimeSpan Hora_Inicio { get; set; }
        public TimeSpan Hora_Fim { get; set; }
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Default { get; set; } = false;
        #endregion

        #region - Relacionamento -
        public virtual ICollection<Adm_Perfil> Perfil { get; set; }
        #endregion

    }
}
