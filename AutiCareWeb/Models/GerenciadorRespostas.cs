using AutiCare.Models;
using AutiCareWeb.Models.Banco;

namespace AutiCareWeb.Models
{
    public static class GerenciadorRespostas
    {
        private static TableDiagnostico TableDiagnostico = new();

        public static void AdicionarRespostasUsuario(Usuario usuario)
        {
            TableDiagnostico.ID = null;
            TableDiagnostico.Nome = usuario.Nome;
            TableDiagnostico.Sexo = (short)usuario.Sexo;
            TableDiagnostico.DataNascimento = usuario.DataNascimento;
        }

        public static void AdicionarRespostasDiagnostico(Diagnostico diagnostico)
        {
            TableDiagnostico.Etnia = (short)diagnostico.Etnia;
            TableDiagnostico.Idade = diagnostico.Idade;
            TableDiagnostico.Sexo = (short)diagnostico.Sexo;
            TableDiagnostico.Ictericia = diagnostico.Ictericia;
            TableDiagnostico.FamiliarPDD = diagnostico.FamiliarPDD;
            TableDiagnostico.TipoUser = (short)diagnostico.TipoUser;
            TableDiagnostico.Pergunta_1 = diagnostico.Pergunta_1;
            TableDiagnostico.Pergunta_2 = diagnostico.Pergunta_2;
            TableDiagnostico.Pergunta_3 =diagnostico.Pergunta_3;
            TableDiagnostico.Pergunta_4 = diagnostico.Pergunta_4;
            TableDiagnostico.Pergunta_5 = diagnostico.Pergunta_5;
            TableDiagnostico.Pergunta_6 = diagnostico.Pergunta_6;
            TableDiagnostico.Pergunta_7 = diagnostico.Pergunta_7;
            TableDiagnostico.Pergunta_8 = diagnostico.Pergunta_8;
            TableDiagnostico.Pergunta_9 = diagnostico.Pergunta_9;
            TableDiagnostico.Pergunta_10 = diagnostico.Pergunta_10;

        }

        public static TableDiagnostico DevolverTabelaDiagnosticoPreenchido()
            => TableDiagnostico;
    }
}
