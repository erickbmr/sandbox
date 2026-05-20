namespace clean.infra.repositories
{
    public class AgendaRepository : IAgendaRepository
    {
        private List<Agenda> Agendas = new();

        public Agenda Salvar(Agenda agenda)
        {
            Agendas.Add(agenda);
            return agenda;
        }

        public Agenda BuscaPorId(Guid agendaId)
        {
            return Agendas.FirstOrDefault(_ => _.Id == agendaId);
        }
    }
}