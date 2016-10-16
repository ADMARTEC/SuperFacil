using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Infraestrutura
{
    public class SuperFacilInicializador: CreateDatabaseIfNotExists <SuperFacilContexto>
    {
        public SuperFacilInicializador()
        {           

        }

        protected override void Seed(SuperFacilContexto context)
        {
            base.Seed(context);
        }
    }
}
