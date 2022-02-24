// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoaasClientTests.cs" company="Alexander Zuev">
//   Copyright (C) Alexander Zuev. All rights reserved.
// </copyright>
// <summary>
//   Tests the Fuck Off as a Service client operations.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Foaas.Client.Tests
{
    using System.Net.Http;
    using System.Threading.Tasks;

    using Bogus;

    using Foaas.Client.Configuration;
    using Foaas.Client.Tests.Properties;

    using Xunit;

    /// <summary>
    /// Tests the Fuck Off as a Service client operations.
    /// </summary>
    // ReSharper disable once ClassTooBig
    public sealed class FoaasClientTests
    {
        /// <summary>
        /// The HTTP client to use.
        /// </summary>
        private static readonly HttpClient _Client = new HttpClient();

        /// <summary>
        /// The FOAAS configuration to use.
        /// </summary>
        private static readonly FoaasClientConfiguration _Configuration = new FoaasClientConfiguration
        {
            BaseUrl = Resources.FoaasBaseUrl,
            I18N = string.Empty,
            ShoutCloud = false
        };

        /// <summary>
        /// The test data.
        /// </summary>
        private readonly TestData _testData;

        /// <summary>
        /// The Fuck Off as a Service client.
        /// </summary>
        private readonly IFoaasClient _client;

        /// <summary>
        /// Initializes a new instance of the <see cref="FoaasClientTests"/> class.
        /// </summary>
        public FoaasClientTests()
        {
            // TODO: generate data according to properties
            Faker<TestData> faker = new Faker<TestData>()
                .RuleFor(u => u.Company, f => f.Company.CompanyName())
                .RuleFor(u => u.From, f => f.Name.FirstName())
                .RuleFor(u => u.Name, f => f.Name.FirstName())
                .RuleFor(u => u.Reference, f => f.Name.FirstName())
                .RuleFor(u => u.Language, f => f.Name.FirstName())
                .RuleFor(u => u.Behavior, f => f.Name.FirstName())
                .RuleFor(u => u.Tool, f => f.Name.FirstName())
                .RuleFor(u => u.Do, f => f.Name.FirstName())
                .RuleFor(u => u.Something, f => f.Name.FirstName())
                .RuleFor(u => u.Noun, f => f.Name.FirstName())
                .RuleFor(u => u.Reaction, f => f.Name.FirstName())
                .RuleFor(u => u.Thing, f => f.Name.FirstName());

            this._testData = faker.Generate();
            this._client = new FoaasClient(_Client, _Configuration);
        }

        /// <summary>
        /// Tests that the version operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task VersionWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.VersionAsync().ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal("FOAAS", response.Subtitle);
        }

        /// <summary>
        /// Tests that the operations operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task OperationsWorksAsync()
        {
            Responses.FoaasOperationsResponse response = await this._client.OperationsAsync().ConfigureAwait(false);

            Assert.NotNull(response);
        }

        /// <summary>
        /// Tests that the anyway operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task AnywayWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.AnywayAsync(this._testData.Company, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"Who the fuck are you anyway, {this._testData.Company}, why are you stirring up so much trouble, and, who pays you?",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the asshole operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task AssholeWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.AssholeAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck you, asshole.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the awesome operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task AwesomeWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.AwesomeAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"This is Fucking Awesome.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the back operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task BackWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.BackAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Name}, back the fuck off.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the bag operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task BagWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.BagAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Eat a bag of fucking dicks.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the ballmer operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task BallmerWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.BallmerAsync(
                this._testData.Name,
                this._testData.Company,
                this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"Fucking {this._testData.Name} is a fucking pussy. I'm going to fucking bury that guy, I have done it before, and I will do it again. I'm going to fucking kill {this._testData.Company}.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the birthday operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task BirthdayWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.BirthdayAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Happy Fucking Birthday, {this._testData.Name}.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the because operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task BecauseWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.BecauseAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Why? Because fuck you, that's why.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the blackadder operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task BlackadderWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.BlackadderAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"{this._testData.Name}, your head is as empty as a eunuch’s underpants. Fuck off!",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the bucket operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task BucketWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.BucketAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Please choke on a bucket of cocks.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the bm operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task BmWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.BmAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Bravo mike, {this._testData.Name}.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the bus operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task BusWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.BusAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"Christ on a bendy-bus, {this._testData.Name}, don't be such a fucking faff-arse.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the bye operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ByeWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.ByeAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuckity bye!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the caniuse operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task CanIUseWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.CanIUseAsync(this._testData.Tool, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Can you use {this._testData.Tool}? Fuck no!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the chainsaw operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ChainsawWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ChainsawAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"Fuck me gently with a chainsaw, {this._testData.Name}. Do I look like Mother Teresa?",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the X operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task CocksplatWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.CocksplatAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck off {this._testData.Name}, you worthless cocksplat", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the cool operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task CoolWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.CoolAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Cool story, bro.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the cup operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task CupWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.CupAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"How about a nice cup of shut the fuck up?", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the dalton operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task DaltonWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.DaltonAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Name}: A fucking problem solving super-hero.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the deraadt operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task DeraadtWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.DeraadtAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"{this._testData.Name} you are being the usual slimy hypocritical asshole... You may have had value ten years ago, but people will see that you don't anymore.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the diabetes operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task DiabetesWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.DiabetesAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"I'd love to stop and chat to you but I'd rather have type 2 diabetes.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the donut operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task DonutWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.DonutAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Name}, go and take a flying fuck at a rolling donut.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the something operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task DoSomethingAsync()
        {
            Responses.FoaasResponse response = await this._client.DoSomethingAsync(
                this._testData.Do,
                this._testData.Something,
                this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Do} the fucking {this._testData.Something}!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the equity operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task EquityWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.EquityAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"Equity only? Long hours? Zero Pay? Well {this._testData.Name}, just sign me right the fuck up.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the even operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task EvenWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.EvenAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"I can't fuckin' even.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the everyone operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task EveryoneWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.EveryoneAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Everyone can go and fuck off.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the everything operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task EverythingWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.EverythingAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck everything.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the familyandpets operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task FamilyWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.FamilyAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck you, your whole family, your pets, and your feces.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the fascinating operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task FascinatingWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.FascinatingAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fascinating story, in what chapter do you shut the fuck up?", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the fewer operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task FewerWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.FewerAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Go fuck yourself {this._testData.Name}, you'll disappoint fewer people.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the field operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task FieldWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.FieldAsync(
                this._testData.Name,
                this._testData.From,
                this._testData.Reference).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"And {this._testData.Name} said unto {this._testData.From}, 'Verily, cast thine eyes upon the field in which I grow my fucks', and {this._testData.From} gave witness unto the field, and saw that it was barren.",
                response.Message);
            Assert.Equal($@"- {this._testData.Reference}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the flying operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task FlyingWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.FlyingAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"I don't give a flying fuck.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the ftfy operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task FtfyWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.FtfyAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck That, Fuck You", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the fts operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task FtsWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.FtsAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck that shit, {this._testData.Name}.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the gfy operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task GfyWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.GfyAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Golf foxtrot yankee, {this._testData.Name}.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the give operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task GiveWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.GiveAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"I give zero fucks.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the greed operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task GreedWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.GreedAsync(this._testData.Noun, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"The point is, ladies and gentleman, that {this._testData.Noun.ToLower()} -- for lack of a better word -- is good. {this._testData.Noun} is right. {this._testData.Noun} works. {this._testData.Noun} clarifies, cuts through, and captures the essence of the evolutionary spirit. {this._testData.Noun}, in all of its forms -- {this._testData.Noun} for life, for money, for love, knowledge -- has marked the upward surge of mankind.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the holygrail operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task HolyGrailWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.HolyGrailAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                @"I don't want to talk to you, no more, you empty-headed animal, food trough wiper. I fart in your general direction. Your mother was a hamster and your father smelt of elderberries. Now go away or I shall taunt you a second time.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the horse operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task HorseWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.HorseAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck you and the horse you rode in on.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the idea operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task IdeaWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.IdeaAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"That sounds like a fucking great idea!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the immensity operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ImmensityWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ImmensityAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"You can not imagine the immensity of the FUCK I do not give.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the fyyff operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task FyyffWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.FyyffAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck you, you fucking fuck.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the jinglebells operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task JingleBellsWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.JingleBellsAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                @"Fuck you, fuck me, fuck your family. Fuck your father, fuck your mother, fuck you and me.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the keep operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task KeepWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.KeepAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"{this._testData.Name}: Fuck off. And when you get there, fuck off from there too. Then fuck off some more. Keep fucking off until you get back here. Then fuck off again.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the keepcalm operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task KeepCalmWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.KeepCalmAsync(this._testData.Reaction, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Keep the fuck calm and {this._testData.Reaction}!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the king operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task KingWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.KingAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"Oh fuck off, just really fuck off you total dickface. Christ, {this._testData.Name}, you are fucking thick.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the ing operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task IngWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.IngAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Fucking fuck off, {this._testData.Name}.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the life operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task LifeWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.LifeAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck my life.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the linus operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task LinusWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.LinusAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"{this._testData.Name}, there aren't enough swear-words in the English language, so now I'll have to call you perkeleen vittupää just to express my disgust and frustration with this crap.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the logs operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task LogsWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.LogsAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Check your fucking logs!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the look operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task LookWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.LookAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Name}, do I look like I give a fuck?", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the looking operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task LookingWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.LookingAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Looking for a fuck to give.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the legend operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task LegendWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.LegendAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Name}, you're a fucking legend.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the madison operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task MadisonWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.MadisonAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"What you've just said is one of the most insanely idiotic things I have ever heard, {this._testData.Name}. At no point in your rambling, incoherent response were you even close to anything that could be considered a rational thought. Everyone in this room is now dumber for having listened to it. I award you no points {this._testData.Name}, and may God have mercy on your soul.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the maybe operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task MaybeWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.MaybeAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Maybe. Maybe not. Maybe fuck yourself.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the me operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task MeWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.MeAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck me.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the mornin operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task MorninWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.MorninAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Happy fuckin' mornin'!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the no operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task NoWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.NoAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"No fucks given.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the off operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task OffWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.OffAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck off, {this._testData.Name}.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the offwith operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task OffWithWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.OffWithAsync(this._testData.Behavior, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck off with {this._testData.Behavior}", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the outside operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task OutsideWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.OutsideAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"{this._testData.Name}, why don't you go outside and play hide-and-go-fuck-yourself?",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the particular operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ParticularWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ParticularAsync(this._testData.Thing, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck this {this._testData.Thing} in particular.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the pink operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task PinkWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.PinkAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Well, fuck me pink.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the problem operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ProblemWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ProblemAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"What the fuck is your problem {this._testData.Name}?", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the programmer operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ProgrammerWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ProgrammerAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck you, I'm a programmer, bitch!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the nugget operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task NuggetWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.NuggetAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"Well {this._testData.Name}, aren't you a shining example of a rancid fuck-nugget.",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the pulp operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task PulpWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.PulpAsync(this._testData.Language, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Language}, motherfucker, do you speak it?", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the question operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task QuestionWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.QuestionAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"To fuck off, or to fuck off (that is not a question)", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the ratsarse operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task RatsArseWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.RatsArseAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"I don't give a rat's arse.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the retard operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task RetardWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.RetardAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"You Fucktard!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the ridiculous operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task RidiculousWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.RidiculousAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"That's fucking ridiculous", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the rockstar operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task RockstarWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.RockstarAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Name}, you're a fucking Rock Star!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the rtfm operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task RtfmWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.RtfmAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Read the fucking manual!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the sake operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task SakeWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.SakeAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"For Fuck's sake!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the shakespeare operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ShakespeareWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ShakespeareAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"{this._testData.Name}, Thou clay-brained guts, thou knotty-pated fool, thou whoreson obscene greasy tallow-catch!",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the shit operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ShitWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.ShitAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck this shit!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the shutup operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ShutUpWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ShutUpAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Name}, shut the fuck up.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the single operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task SingleWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.SingleAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Not a single fuck was given.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the thanks operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ThanksWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ThanksAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck you very much.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the that operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ThatWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.ThatAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck that.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the think operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ThinkAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ThinkAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Name}, you think I give a fuck?", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the thinking operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ThinkingWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ThinkingAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"{this._testData.Name}, what the fuck were you actually thinking?", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the this operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ThisWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.ThisAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Fuck this.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the thumbs operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ThumbsWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.ThumbsAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Who has two thumbs and doesn't give a fuck? {this._testData.Name}.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the too operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task TooWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.TooAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Thanks, fuck you too.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the tucker operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task TuckerWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.TuckerAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Come the fuck in or fuck the fuck off.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the what operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task WhatWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.WhatAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"What the fuck‽", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the xmas operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task XmasWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.XmasAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Merry Fucking Christmas, {this._testData.Name}.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the yoda operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task YodaWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.YodaAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck off, you must, {this._testData.Name}.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the you operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task YouWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.YouAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck you, {this._testData.Name}.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the zayn operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ZaynWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.ZaynAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Ask me if I give a motherfuck ?!!", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the zero operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task ZeroWorksAsync()
        {
            Responses.FoaasResponse response = await this._client.ZeroAsync(this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(@"Zero, that's the number of fucks I give.", response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// Tests that the waste operation works.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task" />.</returns>
        [Fact]
        public async Task WasteWorksAsync()
        {
            Responses.FoaasResponse response =
                await this._client.WasteAsync(this._testData.Name, this._testData.From).ConfigureAwait(false);

            Assert.NotNull(response);
            Assert.Equal(
                $@"I don't waste my fucking time with your bullshit {this._testData.Name}!",
                response.Message);
            Assert.Equal($@"- {this._testData.From}", response.Subtitle);
        }

        /// <summary>
        /// A test data structure.
        /// </summary>
        // ReSharper disable once ClassNeverInstantiated.Local
        private sealed class TestData
        {
            /// <summary>
            /// Gets or sets the company.
            /// </summary>
            /// <value>
            /// The company.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Company
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets from whom.
            /// </summary>
            /// <value>
            /// From whom.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string From
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            /// <value>
            /// The name.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Name
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets the reference.
            /// </summary>
            /// <value>
            /// The reference.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Reference
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets the language.
            /// </summary>
            /// <value>
            /// The language.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Language
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets the behavior.
            /// </summary>
            /// <value>
            /// The behavior.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Behavior
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets the tool.
            /// </summary>
            /// <value>
            /// The tool.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Tool
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets what to do.
            /// </summary>
            /// <value>
            /// What to do.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Do
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets something.
            /// </summary>
            /// <value>
            /// Something (or another).
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Something
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets the noun.
            /// </summary>
            /// <value>
            /// The noun.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Noun
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets the reaction.
            /// </summary>
            /// <value>
            /// The reaction.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Reaction
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }

            /// <summary>
            /// Gets or sets the thing.
            /// </summary>
            /// <value>
            /// The thing.
            /// </value>
#pragma warning disable S3459 // Unassigned members should be removed
            public string Thing
#pragma warning restore S3459 // Unassigned members should be removed
            {
                get;

#pragma warning disable S1144 // Unused private types or members should be removed
                // ReSharper disable once UnusedAutoPropertyAccessor.Local
                set;
#pragma warning restore S1144 // Unused private types or members should be removed
            }
        }
    }
}
