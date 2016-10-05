using System;

namespace SuperFacil.Dominio.Modelos.Abstracao
{
    public class Abs_Pessoa: Abs_Identificadores
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Alcunha { get; set; } // Nome vulgar ou que prefere ser chamado
        public DateTime DataNascimento { get; set; }
    }
}
