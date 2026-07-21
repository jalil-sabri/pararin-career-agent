using MediatR;
using Pararin.CareerAgent.Application.AI;

namespace Pararin.CareerAgent.Application.Features.JobPostingAnalysis;

public sealed class AnalyzeJobPostingHandler
    : IRequestHandler<AnalyzeJobPostingCommand, AnalyzeJobPostingResult>
{
    private readonly ILLMService _llmService;

    public AnalyzeJobPostingHandler(ILLMService llmService)
    {
        _llmService = llmService;
    }

    public async Task<AnalyzeJobPostingResult> Handle(AnalyzeJobPostingCommand request, CancellationToken cancellationToken)
    {
        LLMRequest llmRequest = new(
            SystemPrompt:
                """
            You are an expert technical recruiter.

            Analyze the provided job posting and produce a concise summary.

            This is the first implementation.
            Return only a plain text summary.
            """,
            UserPrompt: request.JobDescription);

        LLMResponse response = await _llmService.CompleteAsync(llmRequest, cancellationToken);

        return new AnalyzeJobPostingResult(
            Summary: response.Content,
            RequiredSkills: Array.Empty<string>(),
            NiceToHaveSkills: Array.Empty<string>(),
            Seniority: "Unknown",
            WorkMode: "Unknown");
    }
}