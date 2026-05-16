namespace mvvm.models
{
    public class Especialista(int id, string nome, string especialidade)
    {
        public int Id { get; set; } = id;
        public string Nome { get; set; } = nome;
        public string Especialidade { get; set; } = especialidade;
        public Agendamento[] Agenda { get; set;}

        public bool Disponivel(DateTime date)
        {
            return !(Agenda.FirstOrDefault(_ => _.Data == date) != null);
        }

        public object Agendar(Agendamento agendamento)
        {
            _ = Agenda.Append(agendamento);

            return agendamento;
        }
    }
}