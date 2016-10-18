using SuperFacil.Common.Resource;
using SuperFacil.Common.Resource.Administracao;
using SuperFacil.Common.Validacao;
using SuperFacil.Dominio.Modelos.Abstracao;
using SuperFacil.Dominio.Modelos.Global;
using SuperFacil.Dominio.Modelos.Recursos_Humano;
using System;

namespace SuperFacil.Dominio.Modelos.Administracao
{
    /* 
    * Propriedades Abstratas a ter em conta:
    * Nome,
    * Create,Update e Deleted  --- Nunca deve faltar em nenhuma classe
    */
    public class Adm_Usuario : Abs_Base
    {
        #region - Propriedade -
        public int Usuario_ID { get; set; }
        public int Empresa_ID { get; set; } // Referencia a tabela de Empresa
        public int Perfil_ID { get; set; } // Referencia a tabela de Perfil
        public int? Funcionario_ID { get; set; } // Caso o usuario seja funcionario
        public int? Imagem_ID { get; set; }
        public string Usuario_login { get; private set; }
        public string Senha { get; private set; }
        public DateTime Data_Limite { get; set; }
        #endregion

        #region - Relacionamento -
        public virtual Adm_Empresa Empresa { get; set; }
        public virtual Adm_Perfil Perfil { get; set; }
        public virtual Reh_Funcionario Funcionario { get; set; }
        public virtual Glo_Imagem Imagem { get; set; }

        #endregion

        #region - Metodos -
        /// <summary>
        /// Atribuição do Nome e usuario
        /// </summary>
        /// <param name="_Empresa"></param>
        /// <param name="_Nome"></param>
        /// <param name="_Usuario"></param>
        public void Set_Usuario(int _Empresa, string _Nome, string _Usuario)
        {
            this.Nome = _Nome;
            this.Usuario_login = _Usuario;
        }

        /// <summary>
        /// Atribuição completa dos dados do usuario
        /// </summary>
        /// <param name="_Empresa"></param>
        /// <param name="_Perfil"></param>
        /// <param name="_Nome"></param>
        /// <param name="_Usuario"></param>
        /// <param name="_Data_Limite"></param>
        public void Set_Usuario(int _Empresa, int _Perfil, string _Nome, string _Usuario, DateTime _Data_Limite,
                                int? _Funcionario = null)
        {
            this.Empresa_ID = _Empresa;
            this.Perfil_ID = _Perfil;
            this.Funcionario_ID = _Funcionario;
            this.Nome = _Nome;
            this.Usuario_login = _Usuario;
            this.Data_Limite = _Data_Limite;
        }

        /// <summary>
        /// Atribuição da senha usando confirmação
        /// </summary>
        /// <param name="_senha"></param>
        /// <param name="_confirmar"></param>
        public void Set_Senha(string _senha, string _confirmar)
        {
            // Validação da senha
            AssertionConcern.AssertArgumentNotNull(_senha, Res_Adm_Usuario.TagSenhaNull);
            AssertionConcern.AssertArgumentEquals(_senha, _confirmar, Res_Adm_Usuario.TagSenhaDiferente);
            AssertionConcern.AssertArgumentLength(_senha, 4, 20, Res_Adm_Usuario.TagSenhaTamanho);

            // Esta atribuição será feito somente se as condições a cima forem validas
            this.Senha = _senha;
        }

        public void Auto_Validar()
        {
            AssertionConcern.AssertArgumentNotNull(this.Nome, Res_Base.TagNomeNull);
            AssertionConcern.AssertArgumentNotEmpty(this.Nome, Res_Base.TagNomeNull);
            AssertionConcern.AssertArgumentLength(this.Nome, 8, 250, Res_Base.TagNomeSize);

            AssertionConcern.AssertArgumentNotNull(this.Usuario_login, Res_Adm_Usuario.TagUsuarioNull);
            AssertionConcern.AssertArgumentNotEmpty(this.Usuario_login, Res_Adm_Usuario.TagUsuarioNull);
            AssertionConcern.AssertArgumentLength(this.Usuario_login, 4, 20, Res_Base.TagNomeSize);
        }
        #endregion
    }
}
