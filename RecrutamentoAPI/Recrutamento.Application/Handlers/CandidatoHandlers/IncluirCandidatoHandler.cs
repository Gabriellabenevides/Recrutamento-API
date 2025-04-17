using MediatR;
using Recrutamento.Domain.Commands;
using Recrutamento.Domain.Entities;
using Recrutamento.Domain.Interface;
using Recrutamento.Domain.Shareds.Notifications;
using Recrutamento.Domain.ViewModel;

namespace Recrutamento.Application.Handlers.CandidatoHandlers;

public class IncluirCandidatoHandler : IRequestHandler<IncluirCandidatoCommand, Response<CandidatoViewModel>>
{
    private readonly ICandidatoRepository _candidatoRepository;

    public IncluirCandidatoHandler(ICandidatoRepository candidatoRepository)
    {
        _candidatoRepository = candidatoRepository;
    }
    public async Task<Response<CandidatoViewModel>> Handle(IncluirCandidatoCommand request, CancellationToken cancellationToken)
    {
        var candidato = new Candidato(request.Candidato.Nome, request.Candidato.Email, request.Candidato.Telefone, request.Candidato.CurriculoUrl);
        await _candidatoRepository.AddAsync(candidato);

        var candidatoViewModel = new CandidatoViewModel(candidato);
        return new(candidatoViewModel);
    }
}
