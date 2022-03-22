using System;

namespace AutiCare.Modelos
{
    public class Usuario
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public enum Sexo
        {
              masculino,
              feminino,
              
        
        }

    }
}
