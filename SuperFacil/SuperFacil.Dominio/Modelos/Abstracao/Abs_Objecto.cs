using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacil.Dominio.Modelos.Abstracao
{
    public class Abs_Objecto : Abs_Base
    {
        // Todo Objecto (Album, Livro, Filme) tem um Título
        public string Titulo { get; set; }
        //Todo Objecto tem uma Classificação (Excelente, Bom, Bastante Bom)
        public string Classificacao { get; set; }
        //Todo Objecto tem um Genero (Kizomba, Zouk, Etc...)
        public string Genero { get; set; }

    }
}
