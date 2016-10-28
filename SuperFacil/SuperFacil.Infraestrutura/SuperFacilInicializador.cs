using SuperFacil.Dominio.Modelos.Administracao;
using SuperFacil.Dominio.Modelos.Global;
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
        protected override void Seed(SuperFacilContexto context)
        {
            var emp = new List<Adm_Empresa>();

            emp.Add(new Adm_Empresa()
            {
                Designacao = "ADMARTEC,LDA",
                NIF = "5417315923",
                Morada = new Glo_Morada()
                {
                    Empresa_ID = 1,
                    Designacao = "Rua Conego Manuel das Neves",
                    Master = true,
                    Pais_ID = 1,
                    Activo = true,
                    CreateUser = 1,
                    CreateDate = Convert.ToDateTime("2014-12-01 11:00:52"),
                    UpdateUser = 1,
                    UpdateDate = DateTime.Now,
                    Deleted = false,
                    Default = true
                },
                Pais = new Glo_Pais()
                {
                    Designacao = "Angola",
                    Activo = true,
                    CreateUser = 1,
                    CreateDate = Convert.ToDateTime("2014-12-01 11:00:52"),
                    UpdateUser = 1,
                    UpdateDate = DateTime.Now,
                    Deleted = false,
                    Default = true
                },
                Contacto = new Glo_Contacto()
                {
                    Empresa_ID = 1,
                    Telefone = 913107759,
                    Email = "info@admartec.net",
                    Responsavel = "Adilson Pedro"
                },
                Activo = true,
                CreateUser = 1,
                CreateDate = Convert.ToDateTime("2014-12-01 11:00:52"),
                UpdateUser = 1,
                UpdateDate = DateTime.Now,
                Deleted = false,
                Default = true
            });

            foreach (Adm_Empresa Emp in emp)
                context.Adm_Empresa.Add(Emp);

            base.Seed(context);
        }
    }
}
