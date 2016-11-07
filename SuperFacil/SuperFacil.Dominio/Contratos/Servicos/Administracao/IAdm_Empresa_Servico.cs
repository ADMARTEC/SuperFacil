using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Administracao
{
    public interface IAdm_Empresa_Servico : IDisposable
    {
        Adm_Empresa GetDesignacao(string _designacao);
        Adm_Empresa GetDesignacao(string _designacao, string _nif);
        Adm_Empresa GetRecursive(int value);
        Adm_Empresa GetRecursive(string _designacao);
        int GetUsuario( string _Designacao,string _Empresa = null);

        void Create(int? _Parent, string _Designacao, string _NIF, int _Contacto, int _Pais, int _Morada, int? _Imagem, string _CreateUser, bool _Default);
        void Update(int? _Parent, string _Designacao, string _NIF, int _Contacto, int _Pais, int _Morada, int? _Imagem, string _UpdateUser, bool _Activo, bool _Default);
        void Save(int? _Parent, string _Designacao, string _NIF, int _Contacto, int _Pais, int _Morada, int? _Imagem, string _Usuario, bool _Activo, bool _Default);
        void Delete(string _Designacao, string _DeleteUser);
    }
}
