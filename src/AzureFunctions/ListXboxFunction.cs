using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctions
{
    public static class ListXboxFunction
    {
        [FunctionName("list-xbox-function")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "v1/xbox")] HttpRequest req,
            ILogger log)
        {
            return new OkObjectResult(new List<string>{"Xbox 360", "Xbox One", "Xbox Series S", "Xbox Series X"});
        }
    }
}
