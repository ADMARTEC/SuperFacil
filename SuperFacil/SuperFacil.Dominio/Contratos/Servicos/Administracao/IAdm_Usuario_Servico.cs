using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Administracao
{
    public interface IAdm_Usuario_Servico : IDisposable
    {
        Task<Adm_Usuario> Autenticacao(int _Empresa, string _usuario, string _senha);
        Task<Adm_Usuario> GetUsuarioLogin(int _Empresa, string value);
        void AlterarSenha(int _Empresa, string usuariologin, string _senhaOld, string _senhaNew, string _senhaConfirm);
        void Guardar(Adm_Usuario _usuario);
        void Eliminar(Adm_Usuario _usuario);
    }
}
