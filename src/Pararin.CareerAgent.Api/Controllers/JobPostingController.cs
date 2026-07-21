using MediatR;
using Microsoft.AspNetCore.Mvc;
using Pararin.CareerAgent.Api.Contracts;
using Pararin.CareerAgent.Application.Features.JobPostingAnalysis;

namespace Pararin.CareerAgent.Api.Controllers;

[ApiController]
[Route("api/job-postings")]
public sealed class JobPostingController : ControllerBase
{
    private readonly IMediator _mediator;

    public JobPostingController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("analyze")]
    public async Task<ActionResult<AnalyzeJobPostingResponse>> Analyze(AnalyzeJobPostingRequest request, CancellationToken cancellationToken)
    {
        AnalyzeJobPostingResult result = await _mediator.Send(new AnalyzeJobPostingCommand(request.JobDescription), cancellationToken);

        return Ok(new AnalyzeJobPostingResponse(
            result.Summary,
            result.RequiredSkills,
            result.NiceToHaveSkills,
            result.Seniority,
            result.WorkMode));
    }
}