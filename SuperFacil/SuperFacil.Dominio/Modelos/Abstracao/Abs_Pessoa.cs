using System;

namespace SuperFacil.Dominio.Modelos.Abstracao
{
    public class Abs_Pessoa: Abs_Identificadores
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Alcunha { get; set; } // Nome vulgar ou que prefere ser chamado
        public DateTime DataNascimento { get; set; }
        public String Biografia { get; set; }
        public String Email { get; set; } 
        public int Pais { get; set; } // País, Coloquei Int na ideia de poder receber o numero ref. do país 
        public String Telefone { get; set; }
        public String Notas { get; set; }
        public String Cidade { get; set; }
        
    }
}
