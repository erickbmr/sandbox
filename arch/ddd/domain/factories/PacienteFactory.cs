namespace ddd.domain.factories
{
    public class PacienteFactory
    {
        public Paciente Criar(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do paciente é obrigatório.", nameof(nome));

            return new Paciente(nome);
        }
    }
}
