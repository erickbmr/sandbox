namespace clean.app.usecases
{
    public class MarcarConsulta(
        IAgendaRepository agendaRepository,
        IEspecialistaRepository especialistaRepository,
        IPacienteRepository pacienteRepository
    )
    {
        private readonly IAgendaRepository _agendaRepository = agendaRepository;
        private readonly IEspecialistaRepository _especialistaRepository = especialistaRepository;
        private readonly IPacienteRepository _pacienteRepository = pacienteRepository;
        
        public MarcarConsultaOutput Execute(MarcarConsultaInput input)
        {
            var paciente = _pacienteRepository.BuscarPorId(input.PacienteId);
            if (paciente == null) return null;

            var especialista = _especialistaRepository.BuscarPorId(input.EspecialistaId);
            if (especialista == null) return null;

            var agenda = _agendaRepository.BuscarPorId(input.AgendaId);
            if (agenda == null) return null;

            if (agenda.Id != especialista.AgendaId) return null;

            if (agenda.MarcarConsulta(input.HorarioConsulta, especialista.Id, paciente.Id))
            {
                _agendaRepository.Salvar(agenda);
                return new MarcarConsultaOutput(especialista.Nome, paciente.Nome);
            }

            return null;
        }
    }
}