namespace Recrutamento.Domain.Entities
{
    public class ProcessoSeletivo
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public string Status { get; set; }
        public int CandidatoId { get; set; }
        public Candidato Candidato { get; set; }
        public int VagaId { get; set; }
        public Vaga Vaga { get; set; }
    }
}
