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

        public async Task<FoaasResponse> Anyway(string company, string from)
        {
            return await Send("/anyway", company, from);
        }

        public async Task<FoaasResponse> Asshole(string from)
        {
            return await Send("/asshole", from);
        }

        public async Task<FoaasResponse> Awesome(string from)
        {
            return await Send("/awesome", from);
        }

        public async Task<FoaasResponse> Back(string name, string from)
        {
            return await Send("/back", name, from);
        }

        public async Task<FoaasResponse> Ballmer(string name, string company, string from)
        {
            return await Send("/ballmer", name, company, from);
        }

        public async Task<FoaasResponse> Birthday(string name, string from)
        {
            return await Send("/bday", name, from);
        }

        public async Task<FoaasResponse> Because(string from)
        {
            return await Send("/anyway", from);
        }

        public async Task<FoaasResponse> Blackadder(string name, string from)
        {
            return await Send("/blackadder", name, from);
        }

        public async Task<FoaasResponse> Bucket(string from)
        {
            return await Send("/bucket", from);
        }

        public async Task<FoaasResponse> Bm(string name, string from)
        {
            return await Send("/bm", name, from);
        }

        public async Task<FoaasResponse> Bus(string name, string from)
        {
            return await Send("/bus", name, from);
        }

        public async Task<FoaasResponse> Bye(string from)
        {
            return await Send("/bye", from);
        }

        public async Task<FoaasResponse> CanIUse(string tool, string from)
        {
            return await Send("/caniuse", tool, from);
        }

        public async Task<FoaasResponse> Chainsaw(string name, string from)
        {
            return await Send("/chainsaw", name, from);
        }

        public async Task<FoaasResponse> Cocksplat(string name, string from)
        {
            return await Send("/cocksplat", name, from);
        }

        public async Task<FoaasResponse> Cool(string from)
        {
            return await Send("/cool", from);
        }

        public async Task<FoaasResponse> Cup(string from)
        {
            return await Send("/cup", from);
        }

        public async Task<FoaasResponse> Dalton(string name, string from)
        {
            return await Send("/dalton", name, from);
        }

        public async Task<FoaasResponse> Deraadt(string name, string from)
        {
            return await Send("/deraadt", name, from);
        }

        public async Task<FoaasResponse> Diabetes(string from)
        {
            return await Send("/diabetes", from);
        }

        public async Task<FoaasResponse> Donut(string name, string from)
        {
            return await Send("/donut", name, from);
        }

        public async Task<FoaasResponse> DoSomething(string @do, string something, string from)
        {
            return await Send("/dosomething", @do, something, from);
        }

        public async Task<FoaasResponse> Equity(string name, string from)
        {
            return await Send("/equity", name, from);
        }

        public async Task<FoaasResponse> Even(string from)
        {
            return await Send("/even", from);
        }

        public async Task<FoaasResponse> Everyone(string from)
        {
            return await Send("/everyone", from);
        }

        public async Task<FoaasResponse> Everything(string from)
        {
            return await Send("/everything", from);
        }

        public async Task<FoaasResponse> Family(string from)
        {
            return await Send("/family", from);
        }

        public async Task<FoaasResponse> Fascinating(string from)
        {
            return await Send("/fascinating", from);
        }

        public async Task<FoaasResponse> Fewer(string name, string from)
        {
            return await Send("/fewer", name, from);
        }

        public async Task<FoaasResponse> Field(string name, string from, string reference)
        {
            return await Send("/field", name, from);
        }

        public async Task<FoaasResponse> Flying(string from)
        {
            return await Send("/flying", from);
        }

        public async Task<FoaasResponse> FTFY(string from)
        {
            return await Send("/ftfy", from);
        }

        public async Task<FoaasResponse> FTS(string name, string from1)
        {
            return await Send("/fts", name);
        }

        public async Task<FoaasResponse> GFY(string name, string from1)
        {
            return await Send("/gfy", name, name);
        }

        public async Task<FoaasResponse> Give(string from)
        {
            return await Send("/give", from);
        }

        public async Task<FoaasResponse> Greed(string noun, string from)
        {
            return await Send("/greed", noun, from);
        }

        public async Task<FoaasResponse> HolyGrail(string from)
        {
            return await Send("/holygrail", from);
        }

        public async Task<FoaasResponse> Horse(string from)
        {
            return await Send("/horse", from);
        }

        public async Task<FoaasResponse> Idea(string from)
        {
            return await Send("/idea", from);
        }

        public async Task<FoaasResponse> Immensity(string from)
        {
            return await Send("/immensity", from);
        }

        public async Task<FoaasResponse> FYYFF(string from)
        {
            return await Send("/fyyff", from);
        }

        public async Task<FoaasResponse> JingleBells(string from)
        {
            return await Send("/jinglebells", from);
        }

        public async Task<FoaasResponse> Keep(string name, string from)
        {
            return await Send("/keep", name, from);
        }

        public async Task<FoaasResponse> KeepCalm(string reaction, string from)
        {
            return await Send("/keepcalm", reaction, from);
        }

        public async Task<FoaasResponse> King(string name, string from)
        {
            return await Send("/king", name, from);
        }

        public async Task<FoaasResponse> Ing(string name, string from)
        {
            return await Send("/ing", name, from);
        }

        public async Task<FoaasResponse> Life(string from)
        {
            return await Send("/life", from);
        }

        public async Task<FoaasResponse> Linus(string name, string from)
        {
            return await Send("/linus", name, from);
        }

        public async Task<FoaasResponse> Logs(string from)
        {
            return await Send("/logs", from);
        }

        public async Task<FoaasResponse> Look(string name, string from)
        {
            return await Send("/look", name, from);
        }

        public async Task<FoaasResponse> Looking(string from)
        {
            return await Send("/looking", from);
        }

        public async Task<FoaasResponse> Legend(string name, string from)
        {
            return await Send("/legend", name, from);
        }

        public async Task<FoaasResponse> Madison(string name, string from)
        {
            return await Send("/madison", name, from);
        }

        public async Task<FoaasResponse> Maybe(string from)
        {
            return await Send("/maybe", from);
        }

        public async Task<FoaasResponse> Me(string from)
        {
            return await Send("/me", from);
        }

        public async Task<FoaasResponse> Mornin(string from)
        {
            return await Send("/mornin", from);
        }

        public async Task<FoaasResponse> No(string from)
        {
            return await Send("/no", from);
        }

        public async Task<FoaasResponse> Off(string name, string from)
        {
            return await Send("/off", name, from);
        }

        public async Task<FoaasResponse> OffWith(string behaviour, string from)
        {
            return await Send("/off-with", behaviour, from);
        }

        public async Task<FoaasResponse> Outside(string name, string from)
        {
            return await Send("/outside", name, from);
        }

        public async Task<FoaasResponse> Particular(string thing, string from)
        {
            return await Send("/particular", thing, from);
        }

        public async Task<FoaasResponse> Pink(string from)
        {
            return await Send("/pink", from);
        }

        public async Task<FoaasResponse> Problem(string name, string from)
        {
            return await Send("/problem", name, from);
        }

        public async Task<FoaasResponse> Programmer(string from)
        {
            return await Send("/programmer", from);
        }

        public async Task<FoaasResponse> Nugget(string name, string from)
        {
            return await Send("/nugget", name, from);
        }

        public async Task<FoaasResponse> Pulp(string language, string from)
        {
            return await Send("/pulp", language, from);
        }

        public async Task<FoaasResponse> Question(string from)
        {
            return await Send("/question", from);
        }

        public async Task<FoaasResponse> Ratsarse(string from)
        {
            return await Send("/ratsarse", from);
        }

        public async Task<FoaasResponse> Retard(string from)
        {
            return await Send("/retard", from);
        }

        public async Task<FoaasResponse> Ridiculous(string from)
        {
            return await Send("/ridiculous", from);
        }

        public async Task<FoaasResponse> Rockstar(string name, string from)
        {
            return await Send("/rockstar", name, from);
        }

        public async Task<FoaasResponse> RTFM(string from)
        {
            return await Send("/rtfm", from);
        }

        public async Task<FoaasResponse> Sake(string from)
        {
            return await Send("/sake", from);
        }

        public async Task<FoaasResponse> Shakespeare(string name, string from)
        {
            return await Send("/shakespeare", name, from);
        }

        public async Task<FoaasResponse> Shit(string from)
        {
            return await Send("/shit", from);
        }

        public async Task<FoaasResponse> ShutUp(string name, string from)
        {
            return await Send("/shutup", name, from);
        }

        public async Task<FoaasResponse> Single(string from)
        {
            return await Send("/single", from);
        }

        public async Task<FoaasResponse> Thanks(string from)
        {
            return await Send("/thanks", from);
        }

        public async Task<FoaasResponse> That(string from)
        {
            return await Send("/that", from);
        }

        public async Task<FoaasResponse> Think(string name, string from)
        {
            return await Send("/think", name, from);
        }

        public async Task<FoaasResponse> Thinking(string name, string from)
        {
            return await Send("/thinking", name, from);
        }

        public async Task<FoaasResponse> This(string from)
        {
            return await Send("/this", from);
        }

        public async Task<FoaasResponse> Thumbs(string name, string from)
        {
            return await Send("/thumbs", name, from);
        }

        public async Task<FoaasResponse> Too(string from)
        {
            return await Send("/too", from);
        }

        public async Task<FoaasResponse> Tucker(string from)
        {
            return await Send("/tucker", from);
        }

        public async Task<FoaasResponse> What(string from)
        {
            return await Send("/what", from);
        }

        public async Task<FoaasResponse> Xmas(string name, string from)
        {
            return await Send("/xmas", name, from);
        }

        public async Task<FoaasResponse> Yoda(string name, string from)
        {
            return await Send("/yoda", name, from);
        }

        public async Task<FoaasResponse> You(string name, string from)
        {
            return await Send("/you", name, from);
        }

        public async Task<FoaasResponse> Zayn(string from)
        {
            return await Send("/zayn", from);
        }

        public async Task<FoaasResponse> Zero(string from)
        {
            return await Send("/zero", from);
        }

        public async Task<FoaasResponse> Waste(string name, string from)
        {
            return await Send("/waste", name, from);
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
