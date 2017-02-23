namespace SuperFacil.Domain.Entities.GestEmpresa.Administracao
{
    public class Admin_Documento_Numero
    {
        public int DocumentoNumero_ID { get; set; }
        public int Documento_ID { get; set; }
        public int Start { get; set; } = 1; // Primeiro numero na sequencia Ex: 100;1000
        public int Last_Used { get; set; } = 0; // Ultimo numero de documento que foi usado
        public int Numero { get { return (Last_Used == 0 ? Start : Last_Used + 1); } private set { Numero = Last_Used; } }

        public void Reset()
        {
            this.Last_Used = 0;
        }
    }
}
