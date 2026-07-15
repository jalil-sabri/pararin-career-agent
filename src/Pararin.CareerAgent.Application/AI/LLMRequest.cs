namespace Pararin.CareerAgent.Application.AI;

public sealed record LLMRequest(string SystemPrompt, string UserPrompt, float Temperature = 0.2f);
