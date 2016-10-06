using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Administracao
{
    public interface IAdm_Usuario_Servico : IDisposable
    {
        Adm_Usuario Autenticacao(int Empresa,string _usuario, string _senha);
        Adm_Usuario GetByUsuarioLogin(int Empresa, string value);
        void Registrar(Adm_Usuario usuario);


    }
}
