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
        }

        public static TableDiagnostico DevolverTabelaDiagnosticoPreenchido()
            => TableDiagnostico;
    }
}
