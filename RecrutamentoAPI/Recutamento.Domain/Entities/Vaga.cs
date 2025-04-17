using System.Text.Json.Serialization;

namespace Recrutamento.Domain.Entities;

public class Vaga
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Status { get; set; }
    public decimal Salario { get; set; }

    public Vaga() { }

    public Vaga(string titulo, string descricao, string status, decimal salario)
    {
        Titulo = titulo;
        Descricao = descricao;
        Status = status;
        Salario = salario;
    }
}
