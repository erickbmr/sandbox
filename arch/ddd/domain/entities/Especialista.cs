namespace ddd.domain.entities
{
    public class Especialista(string nome, Guid agendaId)
    {
        public string Guid { get; } = new Guid();
        public string Nome { get; } = nome;
        public Guid AgendaId { get; } = agendaId;
    }   
}