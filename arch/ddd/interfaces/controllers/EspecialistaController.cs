namespace ddd.interfaces.controller
{
    public class EspecialistaController(IEspecialistaService especialistaService)
    {
        private IEspecialistaService _especialistaService = especialistaService;

        //implementações para expor informações a partir do service   
    }
}