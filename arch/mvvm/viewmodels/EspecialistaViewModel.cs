namespace mvvm.viewmodels
{
    //Executada do lado do cliente
    
    public class EspecialistaViewModel
    {
        //Repo injetado
        private readonly Especialista[] EspecialistasRepository = new();
        private Especialista Especialista { private get; set; }

        public object Agendar(Agendamento agendamento)
        {
            return Especialista.Agendar(agendamento);
        }

        public bool DefineEspecialista(string id)
        {
            var especialista = EspecialistasRepository.FirstOrDefault(_ => _.Id == id);

            if (especialista == null)
            {
                return false;
            }

            Especialista = especialista;
            return true;
        }

        public bool Disponivel()
        {
            return Especialista.Disponivel();
        }
    }   
}