namespace clean.domain.entities
{
    public class Agenda
    {
        public Guid Id { get; } = Guid.NewGuid();
        private readonly List<Consulta> Consultas { get; } = new();

        public bool HorarioDisponivel(Horario horario)
        {
            if (!horario.Valido()) return false;
            return Consultas.FirstOrDefault(_ => _.Horario.data == horario.Data) == null;
        }

        public bool MarcarConsulta(DateTime data, Guid pacienteId, Guid especialistaId)
        {
            var horario = new(data);
            if (!HorarioDisponivel(horario)) return false;
            Consultas.Add(new (horario, pacienteId, especialistaId));
            return true;
        }
    }

    internal class Consulta(Horario horario, Guid pacienteId, Guid especialistaId)
    {
        public Guid Id { get; } = new Guid();
        public Guid EspecialistaId = especialistaId;
        public Guid PacienteId { get; } = pacienteId;
        public Horario Horario { get; } = horario;

        public bool Reagendar(Horario novoHorario)
        {
            if (!horario.Valido()) return false;

            Horario = novoHorario;
            return true;
        }
    }   
}