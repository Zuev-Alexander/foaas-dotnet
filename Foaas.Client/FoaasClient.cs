using System.Net.Http;

namespace Foaas.Client
{
    public class FoaasClient
    {
        private readonly HttpClient _client;
        private readonly FoaasClientConfiguration _clientConfiguration;

        public FoaasClient(HttpClient client, FoaasClientConfiguration clientConfiguration)
        {
            _client = client;
            _clientConfiguration = clientConfiguration; 
        }


    }
}
