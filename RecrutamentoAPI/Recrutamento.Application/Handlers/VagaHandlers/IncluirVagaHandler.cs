using MediatR;
using Recrutamento.Domain.Commands;
using Recrutamento.Domain.Entities;
using Recrutamento.Domain.Interface;
using Recrutamento.Domain.Shareds.Notifications;
using Recrutamento.Domain.ViewModel;

namespace Recrutamento.Application.Handlers.VagaHandlers;

public class IncluirVagaHandler : IRequestHandler<IncluirVagaCommand, Response<VagaViewModel>>
{
    private readonly IVagaRepository _vagaRepository;
    public IncluirVagaHandler(IVagaRepository vagaRepository)
    {
        _vagaRepository = vagaRepository;
    }
    public async Task<Response<VagaViewModel>> Handle(IncluirVagaCommand request, CancellationToken cancellationToken)
    {
        var vaga = new Vaga(request.Vaga.Titulo, request.Vaga.Descricao, request.Vaga.Status, request.Vaga.Salario);
       
        await _vagaRepository.AddAsync(vaga);

        var vagaViewModel = new VagaViewModel(vaga);
        return new(vagaViewModel);
    }
}
