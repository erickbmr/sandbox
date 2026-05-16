namespace ddd.app.services.interfaces
{
    public interface IEspecialistaService
    {
        public bool CadastrarEspecialista(string nome);
        public bool AgendarHorario(Guid especialistaId, DateTime data, Guid pacienteId);
    }
}