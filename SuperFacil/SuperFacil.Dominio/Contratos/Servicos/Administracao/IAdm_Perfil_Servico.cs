using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Administracao
{
    public interface IAdm_Perfil_Servico : IDisposable
    {
        Task<Adm_Perfil> GetByID(int Empresa, int value);
        Task<Adm_Perfil> GetByParent(int Empresa, int value);
        Task<Adm_Perfil> GetByHorarioAcesso(int Empresa, int value);
        Task<Adm_Perfil> GetByDesiginacao(int Empresa, string value);

        void Create(Adm_Perfil perfil);
        void Update(Adm_Perfil perfil);
        void Deleted(Adm_Perfil perfil);
    }
}
