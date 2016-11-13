using SuperFacil.Dominio.Modelos.Abstracao;
using SuperFacil.Dominio.Modelos.Administracao;
using System;

namespace SuperFacil.Dominio.Modelos.Sistema
{
    /* 
     * Propriedades Abstratas a ter em conta:
     * 
     * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
     */
    public class Sis_Sessao : Abs_Base
    {
        #region - Propriedade -
        public int Sessao_ID { get; set; }
        public int Empresa_ID { get; set; }
        public string Dispositivo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fim { get; set; }
        #endregion

        public virtual Adm_Empresa Empresa { get; set; }

        #region - Methods -       
        public void Set_Inicio(int _Empresa, int _Usuario, string _Dispositivo, DateTime _Inicio)
        {
            this.Empresa_ID = _Empresa;
            this.Dispositivo = _Dispositivo;
            this.Inicio = _Inicio;
        }

        public void Set_Fim(DateTime? _Fim)
        {
            this.Fim = Fim;
        }
        #endregion
    }
}
