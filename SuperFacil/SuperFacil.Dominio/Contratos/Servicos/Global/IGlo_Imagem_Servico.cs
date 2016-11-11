using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Global
{
    public interface IGlo_Imagem_Servico : IDisposable
    {
        Glo_Imagem GetID(int value);
        Glo_Imagem GetLastInsert(string Empresa);
        int GetUsuario(string _Empresa, string value);
        int GetEmpresa(string _Empresa);

        void Create(string _Empresa, string _ImagemPath, string _CreateUser, bool _Default = false);
        void Update(string _Empresa, int Imagem_ID, string _ImagemPath, string _UpdateUser, bool _Activo, bool _Default = false);
        void Save(string _Empresa, string _ImagemPath, string _User, bool _Activo, int? Imagem_ID = null, bool _Default = false);
        void Delete(string _Empresa, int value, string _DeleteUser);
    }
}
