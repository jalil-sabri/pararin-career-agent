using Pararin.CareerAgent.Domain.Enums;

namespace Pararin.CareerAgent.Application.UseCases.AnalyzeJobPosting;

public sealed record AnalyzeJobPostingResult(
    int MatchScore,
    string Summary,
    IReadOnlyCollection<string> SkillGaps,
    RecommendationType Recommendation);