namespace ddd.domain.entities
{
    public class Paciente(string nome, Endereco endereco)
    {
        public Guid Guid { get; } = new Guid();
        public string Nome { get; } = nome;
        public Endereco Endereco { get; } = endereco;
    }   
}