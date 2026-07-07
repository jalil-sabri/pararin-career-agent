using Pararin.CareerAgent.Domain.Entities;

namespace Pararin.CareerAgent.Domain.Repositories;

public interface IJobPostingRepository
{
    Task<JobPosting?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task AddAsync(JobPosting jobPosting, CancellationToken cancellationToken = default);

    Task UpdateAsync(JobPosting jobPosting, CancellationToken cancellationToken = default);
}