using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace StaticTest.Functions
{
    public class TestFunction1
    {
        private readonly ILogger<TestFunction1> _logger;

        public TestFunction1(ILogger<TestFunction1> logger)
        {
            _logger = logger;
        }

        [Function("TestFunction1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Azure Functions!");
        }
    }
}
