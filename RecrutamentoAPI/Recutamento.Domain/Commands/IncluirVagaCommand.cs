using MediatR;
using Recrutamento.Domain.Entities;
using Recrutamento.Domain.Shareds.Notifications;
using Recrutamento.Domain.ViewModel;

namespace Recrutamento.Domain.Commands;

public record class IncluirVagaCommand(Vaga Vaga) : IRequest<Response<VagaViewModel>>;
