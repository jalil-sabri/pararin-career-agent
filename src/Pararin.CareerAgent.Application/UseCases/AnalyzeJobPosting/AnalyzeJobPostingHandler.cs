using Pararin.CareerAgent.Application.Abstractions;
using Pararin.CareerAgent.Domain.Entities;
using Pararin.CareerAgent.Domain.Enums;
using Pararin.CareerAgent.Domain.ValueObjects;

namespace Pararin.CareerAgent.Application.UseCases.AnalyzeJobPosting;

public sealed class AnalyzeJobPostingHandler
{
    private readonly IJobAnalysisService _jobAnalysisService;

    public AnalyzeJobPostingHandler(IJobAnalysisService jobAnalysisService)
    {
        _jobAnalysisService = jobAnalysisService;
    }

    public async Task<AnalyzeJobPostingResult> HandleAsync(AnalyzeJobPostingCommand command, CancellationToken cancellationToken = default)
    {
        var jobPosting = JobPosting.Create(new JobTitle(command.Title), new CompanyName(command.CompanyName),
                                           new JobDescription(command.Description), (WorkMode)command.WorkMode);

        return await _jobAnalysisService.AnalyzeAsync(jobPosting, cancellationToken);
    }
}