namespace ddd.domain.entities
{
    public class Paciente(string nome)
    {
        public string Guid { get; } = new Guid();
        public string Nome { get; } = nome;
    }   
}