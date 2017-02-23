using SuperFacil.Domain.Entities.Multimidia;
using SuperFacil.Domain.Interface.Repositories.Multimidia;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace SuperFacil.Infrasctruture.Data.Repositories.Multimidia
{
    public class Mul_Midia_Repository : RepositoryBase<Mul_Midia>, IMul_Midia_Repository
    {
        public async Task<IEnumerable<Mul_Midia>> GetDesignacao(string _value)
        {
            return await db.Mul_Midia.Where(x => x.Designacao == _value).ToListAsync();
        }

        public void GetOrganizarLocal()
        {
            int j = 1;

            for (int i = 0; i < 3050; i = i + 50)
            {
                var result = db.Mul_Midia
                            .Where(x => x.Autor_ID > i)
                            .OrderBy(x => x.Autor.Nome).Take(50).ToList();

                foreach (var item in result)
                {
                    var c = new Mul_Midia();
                    c = result.Where(x => x.Autor_ID == item.Autor_ID).FirstOrDefault();
                    c.Localizacao_ID = j;
                    c.UpdateDate = DateTime.Now;

                    db.Entry<Mul_Midia>(c).State = EntityState.Modified;
                    db.SaveChanges();
                }

                j = j + 1;
            }
        }
    }
}
