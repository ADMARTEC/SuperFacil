using SuperFacil.Dominio.Modelos.Multimidia;
using System;

namespace SuperFacil.Dominio.Contratos.Servicos.Multimidia
    {
    public interface IMul_Midia_Servico : IDisposable
        {
        Mul_Midia GetID(string _Empresa, int value);
        Mul_Midia GetDesignacao(string Empresa, string _Parent, string value);
        Mul_Midia GetClassificacao(string Empresa, string _Parent, string value);
        Mul_Midia GetGenero(string Empresa, string _Parent, string value);
        Mul_Midia GetEditora(string Empresa, string _Parent, string value);
        Mul_Midia GetDataLancamento(string Empresa, string _Parent, DateTime value);
        Mul_Midia GetParent(string Empresa, int value);
        Mul_Midia GetTag(string Empresa, string value);
        int GetLocalizacao(string Empresa, string value);
        int GetAutor(string Empresa, string value);
        int GetEmpresa(string _Empresa);
        int GetUsuario(string _Empresa, string _Usuario);

        void Create(string _Empresa, string _Parent, string _Designacao, string _Classificacao, string _Genero, string _Localizacao, string _Autor, DateTime _DataLancamento, string _Editora, int? _Faixa, TimeSpan _Duracao,
                    string _Tag, bool Estado, string _CreateUser, bool _Default = false);
        void Update(string _Empresa, string _Parent, string _Designacao, string _Classificacao, string _Genero, string _Localizacao, string _Autor, DateTime _DataLancamento, string _Editora, int? _Faixa, TimeSpan _Duracao,
                    string _Tag, bool Estado, string _UpdateUser, bool _Activo, bool _Default = false);
        void Save(string _Empresa, string _Parent, string _Designacao, string _Classificacao, string _Genero, string _Localizacao, string _Autor, DateTime _DataLancamento, string _Editora, int? _Faixa, TimeSpan _Duracao,
                    string _Tag, bool Estado, string _User, bool _Activo, bool _Default = false);
        void Save(string _Empresa, string _Parent, string _Designacao, string _Localizacao, string _Autor, int? _Faixa, bool Estado, string _User, bool _Activo, bool _Default = false);
        void Save(string _Empresa, string _Parent, string _Classificacao, string _Genero, string _Autor, DateTime _DataLancamento, string _Editora, int? _Faixa, TimeSpan _Duracao,
                   string _Tag, bool Estado, string _User, bool _Activo, bool _Default = false);
        void Delete(string _Empresa, string _Parent, string _Designacao, string _DeletedUser);
        void Delete(string _Empresa, string _Parent, string _Classificacao, string _Genero, int? _Faixa, TimeSpan _Duracao, string _Editora, string _DeletedUser);

        }
    }
