using MediatR;
using Microsoft.AspNetCore.Mvc;
using Recrutamento.Domain.Commands;

namespace RecrutamentoAPI.Controllers.v1;

[ApiController]
[Route("api/v1/[controller]")]
public class CandidatoController : ControllerBase
{
    private readonly IMediator _mediator;
    public CandidatoController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> IncluirCandidato([FromBody] IncluirCandidatoCommand command, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(command, cancellationToken);
        return result.IsSuccess ? Ok(result) : BadRequest(result);
    }
}
