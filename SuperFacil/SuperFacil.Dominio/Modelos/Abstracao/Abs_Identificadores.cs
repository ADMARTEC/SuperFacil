using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Abstracao
{
    public abstract class Abs_Identificadores
    {
        /// <summary>
        /// O ID de quem pretende guardar contacto
        /// </summary>
        public int Class_ID { get; set; }

        /// <summary>
        /// O nome da classe que pretende guardar o contacto Ex: Autor, Usuario, Cliente etc.
        /// </summary>
        public string Class_Nome { get; set; }
    }
}
