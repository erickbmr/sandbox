namespace ddd.infra.repositories
{
    public class EspecialistaRepository : IEspecialistaRepository
    {
        private Especialista[] Especialistas = new();

        public bool Salvar(Especialista especialista)
        {
            var lista = Especialistas.Where(_ => _.Guid != especialista.Guid);
            Especialistas = lista.Append(especialista);
            return true;
        }

        public Especialista Buscar(Guid especialistaId)
        {
            return Especialistas.FirstOrDefault(_ => _.Guid == especialistaId);
        }

        public Especialista[] Listar()
        {
            return Especialistas;
        }
    }
}