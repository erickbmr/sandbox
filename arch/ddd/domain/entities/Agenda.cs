namespace ddd.domain.entities
{
    public class Agenda
    {
        public Guid Id { get; } = Guid.NewGuid();
        private readonly Consulta[] Consultas { get; } = new();

        public bool HorarioDisponivel(Horario horario)
        {
            if (!horario.Valido()) return false;
            return Consultas.FirstOrDefault(_ => _.Horario.data == horario.Data) == null;
        }

        public bool MarcarConsulta(Horario horario, string pacienteId)
        {
            if (!HorarioDisponivel(horario)) return false;
            _ = Consultas.Append(new (horario, pacienteId));
            return true;
        }
    }

    internal class Consulta(Horario horario, string pacienteId)
    {
        public string Guid { get; } = new Guid();
        public string PacienteId { get; } = pacienteId;
        public Horario Horario { get; } = horario;

        public bool Reagendar(Horario novoHorario)
        {
            if (!horario.Valido()) return false;

            Horario = novoHorario;
            return true;
        }
    }   
}