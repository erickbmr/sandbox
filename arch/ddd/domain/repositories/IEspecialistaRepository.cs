namespace ddd.domain.repositories
{
    public interface IEspecialistaRepository
    {
        public bool Salvar(Especialista especialista);
        public Especialista Buscar(Guid especialistaId);
        public Especialista[] Listar();
    }
}