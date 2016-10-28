using SuperFacil.Dominio.Modelos.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Contratos.Servicos.Global
{
    public interface IGlo_Contacto_Servico : IDisposable
    {
        Glo_Contacto GetByID(int _Empresa, int value);
        Glo_Contacto GetByTelefone(int _Empresa, int value);
        Glo_Contacto GetByClass(int _Empresa, int _Class_ID, string _ClasseNome);

        void Create(Glo_Contacto contacto);
        void Update(Glo_Contacto contacto);
        void Deleted(Glo_Contacto contacto);
    }
}
