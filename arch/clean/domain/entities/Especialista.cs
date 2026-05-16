namespace clean.domain.entities
{
    public class Especialista(string nome, Guid agendaId, EspecialidadeEnum especialidadeEnum)
    {
        public Guid Guid { get; } = new Guid();
        public string Nome { get; } = nome;
        public EspecialidadeEnum Especialidade { get; } = especialidadeEnum;
    }   

    public enum EspecialidadeEnum
    {
        CLINICO = 0,
        ORTOPEDISTA = 1,
        CARDIOLOGISTA = 2
    }
}