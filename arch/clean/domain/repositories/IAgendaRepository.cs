namespace clean.domain.repositories
{
    public interface IAgendaRepository
    {
        Agenda Salvar(Agenda agenda);
        Agenda BuscaPorId(Guid agendaId);
    }
}