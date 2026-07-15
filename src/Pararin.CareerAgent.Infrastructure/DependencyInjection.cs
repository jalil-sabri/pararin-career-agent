using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pararin.CareerAgent.Application.AI;
using Pararin.CareerAgent.Infrastructure.AI.OpenAI;
using Pararin.CareerAgent.Infrastructure.AI.PromptProvider;

namespace Pararin.CareerAgent.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<OpenAIOptions>(configuration.GetSection(OpenAIOptions.SectionName));

        services.AddSingleton<IPromptProvider, FilePromptProvider>();

        services.AddSingleton<ILLMService, OpenAILLMService>();

        return services;
    }
}