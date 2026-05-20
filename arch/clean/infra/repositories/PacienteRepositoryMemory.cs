namespace clean.infra.repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private List<Paciente> Pacientes = new();

        public Paciente Salvar(Paciente paciente)
        {
            Pacientes.Add(paciente);
            return paciente;
        }

        public Paciente BuscaPorId(Guid pacienteId)
        {
            return Pacientes.FirstOrDefault(_ => _.Id == pacienteId);
        }
    }
}