namespace ddd.infra.repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private Paciente[] Pacientes = new();
        
        public bool Salvar(Paciente paciente)
        {
            var lista = Pacientes.Where(_ => _.Guid != paciente.Guid);
            Pacientes = lista.Append(paciente);
            return true;
        }

        public Paciente Buscar(Guid pacienteId)
        {
            return Pacientes.FirstOrDefault(_ => _.Guid == pacienteId);
        }
    }
}