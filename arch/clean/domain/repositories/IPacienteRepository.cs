namespace clean.domain.repositories
{
    public interface IPacienteRepository
    {
        Paciente Salvar(Paciente paciente);
        Paciente BuscaPorId(Guid pacienteId);
    }
}