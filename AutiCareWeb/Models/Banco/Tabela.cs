namespace AutiCareWeb.Models.Banco
{
    public class Tabela
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public SexoEnum Sexo { get; set; }
    }
}
