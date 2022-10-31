using DemoApiProject.Domain.Commands;
using DemoApiProject.Domain.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoApiProject.Controllers;

[ApiController]
[Route("[controller]")]
public class ProfileController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProfileController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet("{profileId}")]
    public async Task<IActionResult> GetProfile([FromRoute] int profileId)
    {
        var command = new GetProfileCommand(profileId);
        var response = await _mediator.Send(command);
        if (response.Profile is not null)
        {
            return Ok(new HttpClientEnvelope<GetProfileResponse>().WithStatusCode(200).WithMessage("Success").WithData(response));
        }

        return NotFound();
    }
}