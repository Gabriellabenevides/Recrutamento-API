using MediatR;
using Microsoft.AspNetCore.Mvc;
using Recrutamento.Domain.Commands;

namespace RecrutamentoAPI.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class ProcessoSeletivoController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProcessoSeletivoController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> IncluirProcessoSeletivo([FromBody] IncluirProcessoSeletivoCommand command, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(command, cancellationToken);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
