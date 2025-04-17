using MediatR;
using Recrutamento.Domain.Entities;
using Recrutamento.Domain.Shareds.Notifications;
using Recrutamento.Domain.ViewModel;

namespace Recrutamento.Domain.Commands;

public record class IncluirCandidatoCommand(Candidato Candidato) : IRequest<Response<CandidatoViewModel>>;