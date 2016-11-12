using SuperFacil.Bussines.Servicos.Administracao;
using SuperFacil.Common.Resource.Multimidia;
using SuperFacil.Dominio.Contratos.Repositorios.Multimidia;
using SuperFacil.Dominio.Contratos.Servicos.Multimidia;
using SuperFacil.Dominio.Modelos.Multimidia;
using System;

namespace SuperFacil.Bussines.Servicos.Multimidia
{
    public class Mul_Midia_Servico : IMul_Midia_Servico
    {
        private readonly IMul_Midia_Repositorio _repositorio;

        public Mul_Midia_Servico() { }

        public Mul_Midia_Servico(IMul_Midia_Repositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Mul_Midia GetID(string _Empresa, int value)
        {
            var result = _repositorio.GetByID(GetEmpresa(_Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Midia.TagInvalido);

            return result;
        }

        public Mul_Midia GetParent(string Empresa, int value)
        {
            var result = _repositorio.GetByParent(GetEmpresa(Empresa), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Midia.TagParentIinvalido);

            return result;
        }

        public Mul_Midia GetDesignacao(string Empresa, string _Parent, string value)
        {
            var result = _repositorio.GetByDesiginacao(GetEmpresa(Empresa), GetParent(Empresa, _Parent), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Midia.TagInvalido);

            return result;
        }

        public Mul_Midia GetClassificacao(string Empresa, string _Parent, string value)
        {
            var result = _repositorio.GetByClassificacao(GetEmpresa(Empresa), GetParent(Empresa, _Parent), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Midia.TagClassificacaoInvalida);

            return result;
        }

        public Mul_Midia GetGenero(string Empresa, string _Parent, string value)
        {
            var result = _repositorio.GetByGenero(GetEmpresa(Empresa), GetParent(Empresa, _Parent), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Midia.TagGeneroInvalido);

            return result;
        }

        public Mul_Midia GetDataLancamento(string Empresa, string _Parent, DateTime value)
        {
            var result = _repositorio.GetByAno_Lancamento(GetEmpresa(Empresa), GetParent(Empresa, _Parent), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Midia.TagDataLancaInvalido);

            return result;
        }

        public Mul_Midia GetEditora(string Empresa, string _Parent, string value)
        {
            var result = _repositorio.GetByEditora(GetEmpresa(Empresa), GetParent(Empresa, _Parent), value).Result;

            if (result == null)
                throw new Exception(Res_Mul_Midia.TagEditoraInvalida);

            return result;
        }

        public int GetParent(string _Empresa, string _Parent)
        {
            return _repositorio.GetByDesiginacao(GetEmpresa(_Empresa), null, _Parent).Result.Midia_ID;
        }

        public int GetAutor(string Empresa, string value)
        {
            return new Mul_Autor_Servico().GetNome(Empresa, value).Empresa_ID;
        }

        public int GetLocalizacao(string Empresa, string value)
        {
            throw new NotImplementedException();
        }

        public int GetEmpresa(string _Empresa)
        {
            return new Adm_Empresa_Servico().GetDesignacao(_Empresa).Empresa_ID;
        }

        public int GetUsuario(string _Empresa, string _Usuario)
        {
            return new Adm_Usuario_Servico().GetUsuario(_Empresa, _Usuario).Usuario_ID;
        }

        public void Create(string _Empresa, string _Parent, string _Designacao, string _Classificacao, string _Genero, string _Localizacao, string _Autor, DateTime _DataLancamento, string _Editora, int? _Faixa, TimeSpan _Duracao, string _Tag, bool Estado, string _CreateUser, bool _Default = false)
        {
            var result = _repositorio.GetByDesiginacao(GetEmpresa(_Empresa), GetParent(_Empresa, _Parent), _Designacao).Result;

            if (result != null)
                throw new Exception(Res_Mul_Midia.TagDuplicado);

            result.Set_Midia(_Designacao, GetEmpresa(_Empresa), GetLocalizacao(_Empresa, _Localizacao), GetParent(_Empresa, _Parent), GetAutor(_Empresa, _Autor), _DataLancamento, _Editora, _Faixa, _Tag, Estado, _Genero, _Classificacao);
            result.Set_Cud_Create(GetUsuario(_Empresa, _CreateUser), DateTime.Now, _Default);

            _repositorio.Create(result);
        }

        public void Update(string _Empresa, string _Parent, string _Designacao, string _Classificacao, string _Genero, string _Localizacao, string _Autor, DateTime _DataLancamento, string _Editora, int? _Faixa, TimeSpan _Duracao, string _Tag, bool Estado, string _UpdateUser, bool _Activo, bool _Default = false)
        {
            var result = GetDesignacao(_Empresa, _Parent, _Designacao);

            result.Set_Midia(_Designacao, GetEmpresa(_Empresa), GetLocalizacao(_Empresa, _Localizacao), GetParent(_Empresa, _Parent), GetAutor(_Empresa, _Autor), _DataLancamento, _Editora, _Faixa, _Tag, Estado, _Genero, _Classificacao);
            result.Set_Cud_Update(_Activo, GetUsuario(_Empresa, _UpdateUser), DateTime.Now, _Default);

            _repositorio.Update(result);
        }

        public void Save(string _Empresa, string _Parent, string _Designacao, string _Classificacao, string _Genero, string _Localizacao, string _Autor, DateTime _DataLancamento, string _Editora, int? _Faixa, TimeSpan _Duracao, string _Tag, bool Estado, string _User, bool _Activo, bool _Default = false)
        {
            var result = GetDesignacao(_Empresa, _Parent, _Designacao);

            if (result != null)
            {
                Update(_Empresa, _Parent, _Designacao, _Classificacao, _Genero, _Localizacao, _Autor, _DataLancamento, _Editora, _Faixa, _Duracao, _Tag, Estado, _User, _Activo, _Default);
            }
            else
            {
                Create(_Empresa, _Parent, _Designacao, _Classificacao, _Genero, _Localizacao, _Autor, _DataLancamento, _Editora, _Faixa, _Duracao, _Tag, Estado, _User, _Default);
            }

        }

        public void Delete(string _Empresa, string _Parent, string _Designacao, string _DeletedUser)
        {
            var result = GetDesignacao(_Empresa, _Parent, _Designacao);

            result.Set_Cud_Delete(GetUsuario(_Empresa, _DeletedUser), DateTime.Now);

            _repositorio.Deleted(result);
        }

        public void Dispose()
        {
            _repositorio.Dispose();
            GC.Collect();
        }
    }
}
