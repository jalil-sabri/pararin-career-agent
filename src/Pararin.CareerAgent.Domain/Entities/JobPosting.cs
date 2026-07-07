using Pararin.CareerAgent.Domain.Common;
using Pararin.CareerAgent.Domain.Enums;
using Pararin.CareerAgent.Domain.ValueObjects;

namespace Pararin.CareerAgent.Domain.Entities;

public sealed class JobPosting : AggregateRoot
{
    private JobPosting(Guid id, JobTitle title, CompanyName companyName, JobDescription description, WorkMode workMode)
    : base(id)
    {
        Title = title;
        CompanyName = companyName;
        Description = description;
        WorkMode = workMode;
    }

    public JobTitle Title { get; private set; }
    public CompanyName CompanyName { get; private set; }
    public JobDescription Description { get; private set; }
    public WorkMode WorkMode { get; private set; }
    
    public static JobPosting Create(JobTitle title, CompanyName companyName, JobDescription description,  WorkMode workMode)
    {
        return new JobPosting(Guid.NewGuid(), title, companyName, description,  workMode);
    }

    public void UpdateDescription(JobDescription description)
    {
        Description = description;
    }
}
