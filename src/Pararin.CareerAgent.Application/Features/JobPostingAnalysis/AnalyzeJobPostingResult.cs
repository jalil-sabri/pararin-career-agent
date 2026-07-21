namespace Pararin.CareerAgent.Application.Features.JobPostingAnalysis;

public sealed record AnalyzeJobPostingResult(
    string Summary,
    IReadOnlyList<string> RequiredSkills,
    IReadOnlyList<string> NiceToHaveSkills,
    string Seniority,
    string WorkMode);