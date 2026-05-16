namespace mvc.models
{
    public class Especialista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public Agendamento[] Agenda { get; set;}

        public Especialista(int id, string nome, string especialidade)
        {
            Id = id;
            Nome = nome;
            Especialidade = especialidade;
        }

        public bool Disponivel(DateTime date)
        {
            return !(Agenda.FirstOrDefault(_ => _.Data == date) != null);
        }

        public void Agendar(Agendamento agendamento)
        {
            _ = Agenda.Append(agendamento);
        }
    }
}