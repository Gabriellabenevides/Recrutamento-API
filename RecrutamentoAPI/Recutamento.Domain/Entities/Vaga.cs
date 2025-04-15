namespace Recrutamento.Domain.Entities
{
    public class Vaga
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Localizacao { get; set; }

        public ICollection<ProcessoSeletivo> ProcessosSeletivos { get; set; }
    }
}
