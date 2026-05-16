namespace mvvm.views
{
    public class AgendamentoView
    {
        public AgendamentoViewModel agendamentoViewModel;

        public object Agendar(Agendamento agendamento)
        {
            return agendamentoViewModel.Agendar(agendamento);
        }
    }
}