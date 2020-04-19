using System;
using System.Threading.Tasks;
using Xunit;

namespace Foaas.Client.Tests
{
    public class FoaasClientTest
    {
        private readonly IFoaasClient _client;

        public FoaasClientTest()
        {
            _client = new FoaasClient();
        }

        [Fact]
        public async Task FuckingVersionWorks()
        {
            var response = await _client.Version();

            Assert.NotNull(response);
            Assert.Equal("FOAAS",response.Subtitle);
        }
    }
}
