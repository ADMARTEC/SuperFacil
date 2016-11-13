using SuperFacil.Dominio.Modelos.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Sistema
{
    public interface ISis_Menu_Servico :IDisposable
    {
        Sis_Menu GetID(int value);
        Sis_Menu GetDesignacao(string _Parent, string _Modulo, string _Designacao);
        int GetParent(string _Parent);
        int GetModulo(string value);    
        int GetUsuario(string _Empresa, string value);

        void Create(string _Parent,string Modulo, string _Designacao, string _CreateUser, bool _Default = false);
        void Update(string _Parent, string Modulo, string _Designacao, string _CreateUser, bool _Activo, bool _Default = false);
        void Save(string _Parent, string Modulo, string _Designacao, string _UpdateUser, bool _Activo, bool _Default = false);
        void Delete(string _Parent, string Modulo, string _Designacao, string _User);
        
    }
}
