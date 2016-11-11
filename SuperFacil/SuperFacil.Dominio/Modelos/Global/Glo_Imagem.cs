using SuperFacil.Dominio.Modelos.Abstracao;
using SuperFacil.Dominio.Modelos.Administracao;

namespace SuperFacil.Dominio.Modelos.Global
{
    /* 
    * Propriedades Abstratas a ter em conta:
    * Designacao
    * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
    */
    public class Glo_Imagem : Abs_Base
    {
        public int Imagem_ID { get; set; }
        public int Empresa_ID { get; set; }

        public virtual Adm_Usuario Usuario { get; set; }
        public virtual Adm_Empresa Empresa { get; set; }

        public void Set_Imagem(int _Empresa, string _Designacao)
        {
            this.Empresa_ID = _Empresa;
            this.Designacao = _Designacao;
        }


    }
}
