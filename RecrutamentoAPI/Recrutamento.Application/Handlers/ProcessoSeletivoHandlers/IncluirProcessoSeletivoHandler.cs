using MediatR;
using Recrutamento.Domain.Entities;
using Recrutamento.Domain.Interface;
using Recrutamento.Domain.Commands;
using Recrutamento.Domain.ViewModel;
using Recrutamento.Domain.Shareds.Notifications;

namespace Recrutamento.Application.Handlers.ProcessoSeletivoHandlers;

public class IncluirProcessoSeletivoHandler : IRequestHandler<IncluirProcessoSeletivoCommand, Response<ProcessoSeletivoViewModel>>
{
    private readonly IProcessoSeletivoRepository _processoSeletivoRepository;
    private readonly IVagaRepository _vagaRepository;


    public IncluirProcessoSeletivoHandler(IProcessoSeletivoRepository processoSeletivoRepository, IVagaRepository vagaRepository)
    {
        _processoSeletivoRepository = processoSeletivoRepository;
        _vagaRepository = vagaRepository;
    }

    public async Task<Response<ProcessoSeletivoViewModel>> Handle(IncluirProcessoSeletivoCommand request, CancellationToken cancellationToken)
    {
        var vaga = await _vagaRepository.GetByIdAsync(request.VagaId);
        if (vaga == null)
        {
            return new Response<ProcessoSeletivoViewModel>(new List<Notification> { new Notification("Vaga não encontrada") });
        }

        var processoSeletivo = new ProcessoSeletivo(request.DataInicio, request.DataFim, request.Status, request.VagaId);

        await _processoSeletivoRepository.AddAsync(processoSeletivo);

        var processoSeletivoViewModel = new ProcessoSeletivoViewModel(processoSeletivo);
        return new(processoSeletivoViewModel);
    }
}
