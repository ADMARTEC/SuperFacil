using System;

namespace SuperFacil.Domain.Entities.GestEmpresa.Comercial.Cliente
{
    public class Com_Cliente_Evento
    {
        public int Evento_ID { get; set; }
        public int Cliente_ID { get; set; }
        public int Evento_Tipo_ID { get; set; }
        public string Designacao { get; set; }
        public string Anfitriao { get; set; } // Nome do aniversariante ou noivos
        public string Morada { get; set; }
        public string Localidade { get; set; }
        public string Tema { get; set; }
        public string Cor { get; set; }
        public DateTime? Data_Anfitriao { get; set; } // Pode ser data de aniversario ou casamento
        public DateTime Data_Evento { get; set; } // Data que será realizado o evento    
        public bool Activo { get; set; } = true;
        public int CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool DefaultSystem { get; set; } = false;

    }
}
