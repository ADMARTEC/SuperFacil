namespace SuperFacil.Dominio.Modelos.Abstracao
{
    /// <summary>
    /// Nivel mais baixo da Abstração, esta vinculada com todas outras classes de abstracao.
    /// </summary>
    public abstract class Abs_Base: Abs_Crud
    {
        public string Designacao { get; set; }
        public string Morada { get; set; }
        public string NIF { get; set; }
    }
}
