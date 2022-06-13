using System.Collections.Generic;

namespace AutiCare.Models
{
    public class Diagnostico
    {
        public short Idade { get; set; }

        public SexoEnum Sexo { get; set; }

        public EtniaEnum Etnia { get; set; }

        public bool Ictericia { get; set; }

        public bool FamiliarPDD { get; set; }

        public UsuarioEnum TipoUser { get; set; }

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

        public bool DiagnosticoFinal()
        {
            short verdadeiras = 0;

            if (Pergunta_1)
                verdadeiras++;
            if (Pergunta_2)
                verdadeiras++;
            if (Pergunta_3)
                verdadeiras++;
            if (Pergunta_4)
                verdadeiras++;
            if (Pergunta_5)
                verdadeiras++;
            if (Pergunta_6)
                verdadeiras++;
            if (Pergunta_7)
                verdadeiras++;
            if (Pergunta_8)
                verdadeiras++;
            if (Pergunta_9)
                verdadeiras++;
            if (Pergunta_10)
                verdadeiras++;

            return verdadeiras >= 7 ? true : false;
        }


    }
}
 