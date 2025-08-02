using System.Net;
using BlazorApp.Shared;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Api
{
    public class ServerFunc1
    {
        private readonly ILogger _logger;

        public ServerFunc1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<ServerFunc1>();
        }

        [Function(Constant.ServerUrl.ServerFunc1)]
        public async Task<HttpResponseData> RunAsync([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            var result = new ServerFunc1Response()
            {
                ServerInfo = new ServerInfo(
                    ThisAssembly.AssemblyFileVersion,
                    DateTimeOffset.Now.ToString("O")),
            };
            var response = req.CreateResponse(HttpStatusCode.OK);
            await response.WriteAsJsonAsync(result);

            return response;
        }
    }
}
