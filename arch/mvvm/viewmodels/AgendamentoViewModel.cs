namespace mvvm.viewmodels
{
    //Executada do lado do cliente
    
    public class AgendamentoViewModel
    {
        private EspecialistaViewModel especialistaViewModel;

        public object Agendar(Agendamento agendamento)
        {
            if (agendamento != null || !agendamento.IsValid())
            {
                return "Agendamento inválido";
            }

            if (especialistaViewModel.DefineEspecialista(agendamento.EspecialistaId))
            {
                return "Especialista não encontrado";
            }

            if (!especialistaViewModel.Disponivel(agendamento.Data))
            {
                return "Especialista não disponível";
            }

            return especialistaViewModel.Agendar(agendamento);
        }
    }   
}