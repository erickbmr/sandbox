
namespace mvvm.models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EspecialistaId { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }

        public Agendamento(int id, string nome, string especialistaId, DateTime data, string descricao)
        {
            Id = id;
            Nome = nome;
            EspecialistaId = especialistaId;
            Data = data;
            Descricao = descricao;
        }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Nome) && Data > DateTime.Now && EspecialistaId > 0;
        }
    }
}