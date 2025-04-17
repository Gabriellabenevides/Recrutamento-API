using Recrutamento.Domain.Entities;

namespace Recrutamento.Domain.ViewModel;

public class ProcessoSeletivoViewModel
{
    public ProcessoSeletivo ProcessoSeletivo { get; set; }
    public ProcessoSeletivoViewModel(ProcessoSeletivo processoSeletivo)
    {
        this.ProcessoSeletivo = processoSeletivo;
    }
}
