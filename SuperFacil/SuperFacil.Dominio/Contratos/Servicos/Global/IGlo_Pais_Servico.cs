using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Global
{
    public interface IGlo_Pais_Servico : IDisposable
    {
        Glo_Pais GetRecursividade(int value);
        Glo_Pais GetDesignacao(string value);
        int GetUsuario(string value);

        void Create(int? _Parent, string _Designacao, string _Usuario, bool _Default = false);
        void Update(int? _Parent, string _Designacao, string _Usuario, bool _Default = false);
        void Guardar(int? _Parent, string _Designacao, string _Usuario, bool _Default = false);

        void Activacao(string _Pais, string _Usuario, bool _Activar);
        void Eliminado(string _Pais, string _Usuario);
    }
}
