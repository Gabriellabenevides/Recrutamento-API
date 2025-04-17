using Recrutamento.Domain.Entities;

namespace Recrutamento.Domain.ViewModel;

public class VagaViewModel
{
    public Vaga Vaga { get; set; }
    public VagaViewModel(Vaga vaga)
    {
        this.Vaga = vaga;
    }
}
