namespace ddd.infra.repositories
{
    public class AgendaRepository : IAgendaRepository
    {
        //in-memory db for study purposes
        private Agenda[] Agendas = new();

        public bool Salvar(Agenda agenda)
        {
            var lista = Agendas.Where(_ => _.Guid != agendaId);
            Agendas = lista.Append(agenda);
            return true;
        }

        public Agenda Buscar(Guid agendaId)
        {
            return Consultas.FirstOrDefault(_ => _.Guid == agendaId);
        }
    }
}