using AutiCare.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace AutiCareWeb.Models.Banco
{
    public class TableDiagnostico
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public SexoEnum Sexo { get; set; }

        public short Idade { get; set; }

      
        public EtniaEnum Etnia { get; set; }

        public bool Ictericia { get; set; }

        public bool FamiliarPDD { get; set; }

        public UsuarioEnum User { get; set; }

        public bool Pergunta_1 { get; set; }
        public bool Pergunta_2 { get; set; }
        public bool Pergunta_3 { get; set; }
        public bool Pergunta_4 { get; set; }
        public bool Pergunta_5 { get; set; }
        public bool Pergunta_6 { get; set; }
        public bool Pergunta_7 { get; set; }
        public bool Pergunta_8 { get; set; }
        public bool Pergunta_9 { get; set; }
        public bool Pergunta_10 { get; set; }
    }
}
