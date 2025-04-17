using Recrutamento.Domain.Entities;

namespace Recrutamento.Domain.ViewModel;

public class CandidatoViewModel
{
    public Candidato Candidato { get; set; }

    public CandidatoViewModel(Candidato candidato)
    {
        this.Candidato = candidato;
    }
}
