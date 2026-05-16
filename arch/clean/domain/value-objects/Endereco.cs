namespace clean.domain.valueobjects
{
    public class Endereco(string rua, int numero)
    {
        public string Rua { get; } = rua;
        public int Numero { get; } = numero;

        public bool Equals(Endereco value)
        {
            return value.Numero == Numero && value.Rua == Rua;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Rua.GetHashCode();
                hashCode = (hashCode * 397) ^ Numero.GetHashCode();
                return hashCode;
            }
        }
    }
}