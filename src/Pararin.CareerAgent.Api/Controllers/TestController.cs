using Microsoft.AspNetCore.Mvc;
using Pararin.CareerAgent.Application.AI;

namespace Pararin.CareerAgent.Api.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    private readonly ILLMService _llmService;

    public TestController(ILLMService llmService)
    {
        _llmService = llmService;
    }

    [HttpGet("openai")]
    public async Task<IActionResult> Test(CancellationToken cancellationToken)
    {
        var request = new LLMRequest(
            SystemPrompt: "You are a helpful assistant.",
            UserPrompt: "Say hello from Pararin Career Agent.");

        var response = await _llmService.CompleteAsync(request, cancellationToken);

        return Ok(response.Content);
    }
}