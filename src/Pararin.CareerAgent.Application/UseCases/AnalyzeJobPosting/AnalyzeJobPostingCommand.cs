using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pararin.CareerAgent.Application.UseCases.AnalyzeJobPosting;

public sealed record AnalyzeJobPostingCommand(string Title, string CompanyName, string Description, int WorkMode);


