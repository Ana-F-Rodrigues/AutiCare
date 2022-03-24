namespace AutiCare.Modelos
{
    public class FormularioPaciente
    {
        public short  Idade { get; set; }

        public SexoEnum Sexo { get; set; }

        public EtniaEnum Etnia { get; set; }

        public bool Ictericia { get; set; }

        public bool FamiliarPDD { get; set; }

        public UsuarioEnum User { get; set; }

        public EstadosEnum Estados { get; set; }

        public bool UsouTriagem { get; set; }



    }
}
