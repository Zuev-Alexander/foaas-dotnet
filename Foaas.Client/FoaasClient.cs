using System;
using System.Net.Http;
using System.Threading.Tasks;
using Foaas.Client.Responses;
using Newtonsoft.Json;

namespace Foaas.Client
{
    public class FoaasClient : IFoaasClient
    {
        private readonly HttpClient _client;
        private readonly FoaasClientConfiguration _clientConfiguration;

        public FoaasClient()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://foaas.com")
            };
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
            _clientConfiguration = new FoaasClientConfiguration
            {
                BaseUrl = "http://foaas.com",
                I18n = "",
                Shoutcloud = false
            };
        }

        public FoaasClient(HttpClient client, FoaasClientConfiguration clientConfiguration)
        {
            _client = client;
            _clientConfiguration = clientConfiguration;

            _client.DefaultRequestHeaders.Add("Accept", "application/json");
            _client.BaseAddress = new Uri(_clientConfiguration.BaseUrl);
        }

        private async Task<FoaasResponse> Send(string path, params string[] parameters)
        {
            var requestString = path + "/" + string.Join("/", parameters);
            
            if (_clientConfiguration.Shoutcloud)
            {
                requestString += "?shoutcloud";
            }

            if (!string.IsNullOrWhiteSpace(_clientConfiguration.I18n))
            {
                var i8nPath = _clientConfiguration.Shoutcloud
                    ? $"&i8n={_clientConfiguration.I18n}"
                    : "?i8n={_clientConfiguration.I18n}";
                requestString += i8nPath;
            }

            var response = await _client.GetStringAsync(requestString);
            return JsonConvert.DeserializeObject<FoaasResponse>(response);
        }

        public async Task<FoaasResponse> Asshole(string from)
        {
            return await Send("/asshole", from);
        }

        public async Task<FoaasResponse> Version()
        {
            return await Send("/version");
        }

        public async Task<FoaasOperationsResponse> Operations()
        {
            var response = await _client.GetStringAsync("/operations");

            var operations = JsonConvert.DeserializeObject<FoaasOperationsResponse.Operation[]>(response);

            return new FoaasOperationsResponse
            {
                Operations = operations
            };
        }

    }
}
