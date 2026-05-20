namespace clean.app.usecases
{
    public class MarcarConsultaOutput(string nomeEspecialista, string nomePaciente)
    {
        public string NomeEspecialista { get; } = nomeEspecialista;
        public string NomePaciente { get; } = nomePaciente;
    }
}