using System.Text.Json.Serialization;

namespace Recrutamento.Domain.Entities;

public class Candidato
{
    [JsonIgnore]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public string CurriculoUrl { get; set; }

    public Candidato() { }

    public Candidato(string nome, string email, string telefone, string curriculoUrl)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
        CurriculoUrl = curriculoUrl;
    }
}
