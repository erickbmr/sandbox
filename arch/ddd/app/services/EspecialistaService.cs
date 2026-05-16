using ddd.domain.factories;

namespace ddd.app.services
{
    public class EspecialistaService(
        IEspecialistaRepository especialistaRepository,
        IPacienteRepository pacienteRepository,
        IAgendaRepository agendaRepository,
        EspecialistaFactory especialistaFactory,
        AgendaFactory agendaFactory
    ) : IEspecialistaService
    {
        private IEspecialistaRepository _especialistaRepository = especialistaRepository;
        private IPacienteRepository _pacienteRepository = pacienteRepository;
        private IAgendaRepository _agendaRepository = agendaRepository;
        private EspecialistaFactory _especialistaFactory = especialistaFactory;
        private AgendaFactory _agendaFactory = agendaFactory;

        public bool CadastrarEspecialista(string nome)
        {
            var agenda = _agendaFactory.Criar();
            _agendaRepository.Salvar(agenda);

            var especialista = _especialistaFactory.Criar(nome, agenda.Id);
            return _especialistaRepository.Salvar(especialista);
        }

        public bool AgendarHorario(Guid especialistaId, DateTime data, Guid pacienteId)
        {
            var paciente = _pacienteRepository.Buscar(pacienteId);
            if (pacienteId == null) return false;

            var especialista = _especialistaRepository.Buscar(especialistaId);
            if (especialista == null) return false;

            var agenda = _agendaRepository.Buscar(especialista.AgendaId);
            if (agenda == null) return false;

            agenda.MarcarConsulta(new(data), pacienteId);
            return _agendaRepository.Salvar(agenda);
        }
    }
}