using Microsoft.Extensions.Options;
using OpenAI;
using OpenAI.Responses;
using Pararin.CareerAgent.Application.AI;

namespace Pararin.CareerAgent.Infrastructure.AI.OpenAI;

public sealed class OpenAILLMService : ILLMService
{
    private readonly OpenAIOptions _options;

#pragma warning disable OPENAI001
    private readonly ResponsesClient _client;
#pragma warning restore OPENAI001

    public OpenAILLMService(IOptions<OpenAIOptions> options)
    {
        _options = options.Value;

        OpenAIClient client = new(_options.ApiKey);

#pragma warning disable OPENAI001
        _client = client.GetResponsesClient();
#pragma warning restore OPENAI001
    }

    public async Task<LLMResponse> CompleteAsync(LLMRequest request, CancellationToken cancellationToken = default)
    {
        try
        {
#pragma warning disable OPENAI001

            CreateResponseOptions options = new()
            {
                Model = _options.Model
            };

            options.InputItems.Add(ResponseItem.CreateUserMessageItem($"{request.SystemPrompt}\n\n{request.UserPrompt}"));

            ResponseResult response = await _client.CreateResponseAsync(options, cancellationToken);

#pragma warning restore OPENAI001

            return new LLMResponse(response.GetOutputText());
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException("Failed to communicate with the configured LLM provider.", ex);
        }
    }
}