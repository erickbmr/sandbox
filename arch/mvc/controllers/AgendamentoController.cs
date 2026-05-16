namespace mvc.controller
{
    public class AgendamentoController
    {
        private readonly Especialista[] especialistas = new();

        public object Agendar(Agendamento agendamento)
        {
            if (agendamento != null || !agendamento.IsValid())
            {
                return "Agendamento inválido";
            }

            var especialista = especialistas.FirstOrDefault(_ => _.id == agendamento.EspecialistaId);
            if (especialista == null)
            {
                return "Especialista não encontrado";
            }

            if (!especialista.Disponivel(agendamento.Data))
            {
                return "Especialista não disponível";
            }

            especialista.Agendar(agendamento);

            return AgendamentoView.Criar(
                agendamento.Nome, 
                especialista.Nome, 
                agendamento.Data, 
                agendamento.Descricao
            );
        }
    }
}