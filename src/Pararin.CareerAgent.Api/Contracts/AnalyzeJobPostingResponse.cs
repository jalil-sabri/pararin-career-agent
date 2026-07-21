namespace Pararin.CareerAgent.Api.Contracts;

public sealed record AnalyzeJobPostingResponse(
    string Summary,
    IReadOnlyList<string> RequiredSkills,
    IReadOnlyList<string> NiceToHaveSkills,
    string Seniority,
    string WorkMode);