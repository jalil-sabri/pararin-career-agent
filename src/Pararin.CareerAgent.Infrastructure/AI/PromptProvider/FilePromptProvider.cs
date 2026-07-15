using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pararin.CareerAgent.Infrastructure.AI.PromptProvider;

public sealed class FilePromptProvider : IPromptProvider
{
    public async Task<string> LoadAsync(string promptName, CancellationToken cancellationToken)
    {
        var path = Path.Combine(AppContext.BaseDirectory, "AI", "Prompt", promptName);

        return await File.ReadAllTextAsync(path,cancellationToken);
    }
}
