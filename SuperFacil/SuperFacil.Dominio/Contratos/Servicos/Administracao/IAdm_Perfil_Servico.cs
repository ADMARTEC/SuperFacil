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
        Task<Adm_Perfil> GetRecursividade(int Empresa, int value);      
        Task<Adm_Perfil> GetDesiginacao(int Empresa, string value);

        void Guardar(Adm_Perfil perfil);    
        void Eliminar(Adm_Perfil perfil);
    }
}
