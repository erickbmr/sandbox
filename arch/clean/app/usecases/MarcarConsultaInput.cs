namespace clean.app.usecases
{
    public class MarcarConsultaInput
    {
        public Guid AgendaId { get; set; }
        public Guid EspecialistaId { get; set; }
        public Guid PacienteId { get; set; }
        public DateTime HorarioConsulta { get; set; }
    }
}