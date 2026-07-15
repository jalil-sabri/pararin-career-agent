namespace Pararin.CareerAgent.Application.AI;

public interface ILLMService
{
    Task<LLMResponse> CompleteAsync(LLMRequest request, CancellationToken cancellationToken = default);
}