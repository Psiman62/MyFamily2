using System.Net;
using BlazorApp.Shared;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Api
{
    public class ServerFunc2
    {
        private readonly ILogger _logger;

        public ServerFunc2(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<ServerFunc2>();
        }

        [Function(Constant.ServerUrl.ServerFunc2)]
        public async Task<HttpResponseData> RunAsync([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var randomNumber = new Random();
            var temp = 0;

            var forecasts = Enumerable.Range(1, 5).Select(index => new SampleRecord
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = temp = randomNumber.Next(-20, 55),
                Summary = GetSummary(temp)
            }).ToArray();
            var result = new ServerFunc2Response()
            {
                Forecasts = forecasts,
            };
            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteAsJsonAsync(result);

            return response;
        }

        private string GetSummary(int temp)
        {
            var summary = "Mild";

            if (temp >= 32)
            {
                summary = "Hot";
            }
            else if (temp <= 16 && temp > 0)
            {
                summary = "Cold";
            }
            else if (temp <= 0)
            {
                summary = "Freezing";
            }

            return summary;
        }
    }
}
