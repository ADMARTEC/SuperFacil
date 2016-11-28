using SuperFacil.Bussines.Administracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.UI._Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Adm_Empresa();
            string r = emp.GetCodigo();

            Console.WriteLine("{0}", r);

        }
    }
}
