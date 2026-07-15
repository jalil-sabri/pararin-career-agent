using Pararin.CareerAgent.Application.UseCases.AnalyzeJobPosting;
using Pararin.CareerAgent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pararin.CareerAgent.Application.Abstractions;

public interface IJobAnalysisService
{
    Task<AnalyzeJobPostingResult> AnalyzeAsync(JobPosting jobPosting, CancellationToken cancellationToken = default);
}
