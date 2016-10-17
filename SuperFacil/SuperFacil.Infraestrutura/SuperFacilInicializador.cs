using SuperFacil.Dominio.Modelos.Administracao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura
{
    public class SuperFacilInicializador : CreateDatabaseIfNotExists<SuperFacilContexto>
    {
        public SuperFacilInicializador()
        {

        }

        protected override void Seed(SuperFacilContexto context)
        {
            IList<Adm_Empresa> emp = new List<Adm_Empresa>();

            emp.Add(new Adm_Empresa()
                    {
                        Designacao = "ADMARTEC,LDA",
                        NIF = "54000"
                    });


            base.Seed(context);
        }
    }
}
