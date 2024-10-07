using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFunctionApp
{
    public class MyFunction
    {
        private readonly ILogger<MyFunction> _logger;

        public MyFunction(ILogger<MyFunction> logger)
        {
            _logger = logger;
        }

        [Function("MyFunction")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
