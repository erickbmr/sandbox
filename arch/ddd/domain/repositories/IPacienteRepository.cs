namespace ddd.domain.repositories
{
    public interface IPacienteRepository
    {
        public Paciente Buscar(Guid pacienteId);
        public bool Salvar(Paciente paciente);
    }
}