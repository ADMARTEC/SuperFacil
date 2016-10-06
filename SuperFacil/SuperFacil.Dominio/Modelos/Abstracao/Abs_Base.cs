namespace SuperFacil.Dominio.Modelos.Abstracao
{
    public abstract class Abs_Base : Abs_Cud
    {
        public string Codigo { get; set; } // O Paulo deve dar melhor explicação
        public string Designacao { get; set; }       
        public string NIF { get; set; }

        /// <summary>
        /// Propriedades Abstractas para a Midia: Musica, Album, Filme, Livro
        /// Todo Objecto tem uma Classificação (Excelente, Bom, Bastante Bom)
        /// </summary>
        public string Classificacao { get; set; }
        //Todo Objecto tem um Genero (Kizomba, Zouk, Etc...)
        public string Genero { get; set; }

        /// <summary>
        /// Indica uma Observação ou textos livres
        /// </summary>
        public string Notas { get; set; } 

        /// <summary>
        /// Indicar se a informação é principal. Ex. Morada: Rua Conego Manuel; Master: True
        /// </summary>                                        
        public bool Master { get; set; } 
    }
}
