namespace ddd.domain.factories
{
    public class EspecialistaFactory
    {
        public Especialista Criar(string nome, Guid agendaId)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do especialista é obrigatório.", nameof(nome));

            if (agendaId == Guid.Empty)
                throw new ArgumentException("AgendaId é obrigatório.", nameof(agendaId));

            return new Especialista(nome, agendaId);
        }
    }
}
