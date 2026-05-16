namespace clean.domain.valueobjects
{
    public record Horario(DateTime data)
    {
        public readonly DateTime Data { get; } = data;

        public bool Valido()
        {
            return Data > DateTime.Now;   
        }

        public bool Equals(Horario horario)
        {
            return Data == horario.Data;
        }

        public override int GetHashCode()
        {
            return Data.GetHashCode();
        }
    }
}