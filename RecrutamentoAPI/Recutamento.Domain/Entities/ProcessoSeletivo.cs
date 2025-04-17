using System.Text.Json.Serialization;

namespace Recrutamento.Domain.Entities;

public class ProcessoSeletivo
{
    [JsonIgnore]
    public int Id { get; set; }
    public DateOnly DataInicio { get; set; }
    public DateOnly DataFim { get; set; }
    public string Status { get; set; }
    public int VagaId { get; set; }
    [JsonIgnore]

    public virtual Vaga Vaga { get; set; }

    public ProcessoSeletivo() { }

    public ProcessoSeletivo(DateOnly dataInicio, DateOnly dataFim, string status, int vagaId)
    {
        DataInicio = dataInicio;
        DataFim = dataFim;
        Status = status;
        VagaId = vagaId;
    }
}
