using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura.Base
{
    public class Infra_Base : IDisposable
    {

        #region - Construtor -
        public readonly SuperFacilContexto db ;

        public Infra_Base( )
        {
            db = new SuperFacilContexto();
        }
        #endregion

        #region - Administração -
        public IQueryable<Adm_Empresa> All_Adm_Empresa()
        {
            return db.Adm_Empresa.Where(x => !x.Deleted);
        }
        #endregion

        #region - Destrutor -        
        public void Dispose()
        {
            db.Dispose();
        }

        ~Infra_Base()
        {
            Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #endregion
    }
}
