namespace ddd.domain.repositories
{
    public interface IAgendaRepository
    {
        public Agenda Buscar(Guid agendaId);
        public bool Salvar(Agenda agenda);
    }
}