namespace clean.infra.repositories
{
    public class EspecialistaRepository : IEspecialistaRepository
    {
        private List<Especialista> Especialistas = new();

        public Especialista Salvar(Especialista especialista)
        {
            Especialistas.Add(especialista);
            return especialista;
        }

        public Especialista BuscaPorId(Guid especialistaId)
        {
            return Especialistas.FirstOrDefault(_ => _.Id == especialistaId);
        }
    }
}