using MediatR;
using Recrutamento.Domain.Entities;
using Recrutamento.Domain.Shareds.Notifications;
using Recrutamento.Domain.ViewModel;

namespace Recrutamento.Domain.Commands;

public record class IncluirProcessoSeletivoCommand(DateOnly DataInicio, DateOnly DataFim, string Status, int VagaId) : IRequest<Response<ProcessoSeletivoViewModel>>;
