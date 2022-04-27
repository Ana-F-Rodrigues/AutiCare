using System.Collections.Generic;

namespace AutiCare.Modelos
{
    public class RespostasUsuarios
    {
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
        
        public bool Diagnostico()
        {
            short verdadeiras = 0;

            if (Pergunta_1)
                verdadeiras++;
            if (Resposta_2)
                verdadeiras++;
            if (Resposta_3)
                verdadeiras++;
            if (Resposta_4)
                verdadeiras++;
            if (Resposta_5)
                verdadeiras++;
            if (Resposta_6)
                verdadeiras++;
            if (Resposta_7)
                verdadeiras++;
            if (Resposta_8)
                verdadeiras++;
            if (Resposta_9)
                verdadeiras++;
            if (Resposta_10)
                verdadeiras++;

            return verdadeiras >= 7 ? true : false;
        }


    }
}
