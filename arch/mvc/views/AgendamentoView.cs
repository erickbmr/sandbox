namespace mvc.views
{
    public class AgendamentoView(string nome, string NomeEspecialista, DateTime data, string descricao)
    {
        public string Nome { get; set; }
        public string NomeEspecialista { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public object Criar (string nome, string nomeEspecialista, string data, string descricao)
        {
            return "nome: " + nome + " | especialista: " + nomeEspecialista + " | data: " + data + " | descricao: " + descricao;
        }
    }
}