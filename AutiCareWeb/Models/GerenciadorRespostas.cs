using AutiCare.Models;
using AutiCareWeb.Models.Banco;

namespace AutiCareWeb.Models
{
    public static class GerenciadorRespostas
    {
        private static TableDiagnostico TableDiagnostico = new();

        public static void AdicionarRespostasUsuario(Usuario usuario)
        {
            TableDiagnostico.Nome = usuario.Nome;
            TableDiagnostico.Sexo = (short)usuario.Sexo;
            TableDiagnostico.DataNascimento = usuario.DataNascimento;
        }

        public static void AdicionarRespostasDiagnostico(Diagnostico diagnostico)
        {
            TableDiagnostico.Etnia = (short)diagnostico.Etnia;
            TableDiagnostico.Idade = (short)diagnostico.Idade;
            TableDiagnostico.Sexo = (short)diagnostico.Sexo;
            TableDiagnostico.Ictericia = (bool)diagnostico.Ictericia;
            TableDiagnostico.FamiliarPDD = (bool)diagnostico.FamiliarPDD;
            TableDiagnostico.TipoUser = (short)diagnostico.TipoUser;
            TableDiagnostico.Pergunta_1 = (bool)diagnostico.Pergunta_1;
            TableDiagnostico.Pergunta_2 = (bool)diagnostico.Pergunta_2;
            TableDiagnostico.Pergunta_3 = (bool)diagnostico.Pergunta_3;
            TableDiagnostico.Pergunta_4 = (bool)diagnostico.Pergunta_4;
            TableDiagnostico.Pergunta_5 = (bool)diagnostico.Pergunta_5;
            TableDiagnostico.Pergunta_6 = (bool)diagnostico.Pergunta_6;
            TableDiagnostico.Pergunta_7 = (bool)diagnostico.Pergunta_7;
            TableDiagnostico.Pergunta_8 = (bool)diagnostico.Pergunta_8;
            TableDiagnostico.Pergunta_9 = (bool)diagnostico.Pergunta_9;
            TableDiagnostico.Pergunta_10 = (bool)diagnostico.Pergunta_10;

        }

        public static TableDiagnostico DevolverTabelaDiagnosticoPreenchido()
            => TableDiagnostico;
    }
}
