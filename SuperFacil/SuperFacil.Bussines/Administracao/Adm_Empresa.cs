using SuperFacil.Infraestrutura.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Bussines.Administracao
{
    public class Adm_Empresa : Infra_Base
    {
        public string GetCodigo()
        {
            
            var res = All_Adm_Empresa()
                      .Where(x => x.Designacao != null)
                      .Select(x => new
                      {
                          Designacao = x.Designacao
                      }).FirstOrDefault();      

            return res.Designacao;
        }
    }
}
