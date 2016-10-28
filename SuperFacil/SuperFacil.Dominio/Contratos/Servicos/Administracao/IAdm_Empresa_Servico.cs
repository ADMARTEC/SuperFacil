using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Administracao
{
    public interface IAdm_Empresa_Servico : IDisposable
    {
        Adm_Empresa GetDesignacao(string _designacao);
        Adm_Empresa GetDesignacao(string _designacao, string _pais);
        Adm_Empresa GetDesignacao(string _designacao, string _pais, string _morada);
        Adm_Empresa GetDesigncao(string _designacao, string _nif);
        Adm_Empresa GetDesigncao(string _designacao, string _nif, int _telefone);
        Adm_Empresa GetRecursive(int value);
        Adm_Empresa GetRecursive(string _designacao);

        void Guardar(Adm_Empresa empresa);
        void Eliminar(Adm_Empresa empresa);

    }
}
