using MediatR;

namespace Pararin.CareerAgent.Application.Features.JobPostingAnalysis;

public sealed record AnalyzeJobPostingCommand(string JobDescription) : IRequest<AnalyzeJobPostingResult>;