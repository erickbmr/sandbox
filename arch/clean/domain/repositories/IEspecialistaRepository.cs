namespace clean.domain.repositories
{
    public interface IEspecialistaRepository
    {
        Especialista Salvar(Especialista especialista);
        Especialista BuscaPorId(Guid especialistaId);
    }
}