
namespace Pararin.CareerAgent.Infrastructure.AI.PromptProvider;

public interface IPromptProvider
{
    Task<string> LoadAsync(string promptName, CancellationToken cancellationToken);
}
