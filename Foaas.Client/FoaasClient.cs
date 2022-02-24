// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FoaasClient.cs" company="Alexander Zuev">
//   Copyright (C) Alexander Zuev. All rights reserved.
// </copyright>
// <summary>
//   Implements a Fuck Off as a Service client.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Foaas.Client
{
    using System;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    using Foaas.Client.Configuration;
    using Foaas.Client.Properties;
    using Foaas.Client.Responses;

    using Newtonsoft.Json;

    /// <inheritdoc />
    /// <summary>
    /// Implements a Fuck Off as a Service client.
    /// </summary>
    /// <seealso cref="IFoaasClient" />
    // ReSharper disable once ClassTooBig
    public sealed class FoaasClient : IFoaasClient
    {
        /// <summary>
        /// The HTTP client.
        /// </summary>
        private readonly HttpClient _client;

        /// <summary>
        /// The client configuration.
        /// </summary>
        private readonly FoaasClientConfiguration _clientConfiguration;

        /// <summary>
        /// Initializes a new instance of the <see cref="FoaasClient"/> class.
        /// </summary>
        public FoaasClient()
            : this(
                new HttpClient(),
                new FoaasClientConfiguration
                {
                    BaseUrl = Resources.FoaasBaseUrl,
                    I18N = string.Empty,
                    ShoutCloud = false
                })
        {
            // Intentionally empty.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FoaasClient"/> class.
        /// </summary>
        /// <param name="client">The HTTP client.</param>
        /// <param name="clientConfiguration">The client configuration.</param>
        /// <exception cref="ArgumentNullException"><paramref name="client" /> cannot be
        /// <see langword="null" />.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="clientConfiguration" /> cannot be
        /// <see langword="null" />.</exception>
        public FoaasClient(HttpClient client, FoaasClientConfiguration clientConfiguration)
        {
            this._client = client ?? throw new ArgumentNullException(nameof(client));
            this._clientConfiguration =
                clientConfiguration ?? throw new ArgumentNullException(nameof(clientConfiguration));
            lock (this._client)
            {
                if (this._client.BaseAddress is null)
                {
                    this._client.DefaultRequestHeaders.Add("Accept", "application/json");
                    this._client.BaseAddress = new Uri(this._clientConfiguration.BaseUrl);
                }
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Who the fuck are you anyway, <paramref name="company" />, why are you stirring up so much trouble, and, who
        /// pays you?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> AnywayAsync(string company, string from) =>
            this.SendAsync("/anyway", company, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck you, asshole.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> AssholeAsync(string from) => this.SendAsync("/asshole", from);

        /// <inheritdoc />
        /// <summary>
        /// This is Fucking Awesome.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> AwesomeAsync(string from) => this.SendAsync("/awesome", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, back the fuck off.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> BackAsync(string name, string from) => this.SendAsync("/back", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Eat a bag of fucking dicks.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> BagAsync(string from) => this.SendAsync("/bag", from);

        /// <inheritdoc />
        /// <summary>
        /// Fucking <paramref name="name" /> is a fucking pussy. I'm going to fucking bury that guy, I have done it
        /// before, and I will do it again. I'm going to fucking kill <paramref name="company" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="company">The company.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> BallmerAsync(string name, string company, string from) =>
            this.SendAsync("/ballmer", name, company, from);

        /// <inheritdoc />
        /// <summary>
        /// Happy Fucking Birthday, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> BirthdayAsync(string name, string from) => this.SendAsync("/bday", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Why? Because fuck you, that's why.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> BecauseAsync(string from) => this.SendAsync("/because", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, your head is as empty as a eunuch’s underpants. Fuck off!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> BlackadderAsync(string name, string from) =>
            this.SendAsync("/blackadder", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Please choke on a bucket of cocks.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> BucketAsync(string from) => this.SendAsync("/bucket", from);

        /// <inheritdoc />
        /// <summary>
        /// Bravo mike, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> BmAsync(string name, string from) => this.SendAsync("/bm", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Christ on a bendy-bus, <paramref name="name" />, don't be such a fucking faff-arse.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> BusAsync(string name, string from) => this.SendAsync("/bus", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuckity bye!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ByeAsync(string from) => this.SendAsync("/bye", from);

        /// <inheritdoc />
        /// <summary>
        /// Can you use <paramref name="tool" />? Fuck no!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="tool">The tool.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> CanIUseAsync(string tool, string from) => this.SendAsync("/caniuse", tool, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck me gently with a chainsaw, <paramref name="name" />. Do I look like Mother Teresa?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ChainsawAsync(string name, string from) => this.SendAsync("/chainsaw", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck off <paramref name="name" />, you worthless cocksplat.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> CocksplatAsync(string name, string from) =>
            this.SendAsync("/cocksplat", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Cool story, bro.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> CoolAsync(string from) => this.SendAsync("/cool", from);

        /// <inheritdoc />
        /// <summary>
        /// How about a nice cup of shut the fuck up?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> CupAsync(string from) => this.SendAsync("/cup", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />: A fucking problem solving super-hero.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> DaltonAsync(string name, string from) => this.SendAsync("/dalton", name, from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" /> you are being the usual slimy hypocritical asshole... You may have had value ten
        /// years ago, but people will see that you don't anymore.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> DeraadtAsync(string name, string from) => this.SendAsync("/deraadt", name, from);

        /// <inheritdoc />
        /// <summary>
        /// I'd love to stop and chat to you but I'd rather have type 2 diabetes.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> DiabetesAsync(string from) => this.SendAsync("/diabetes", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, go and take a flying fuck at a rolling donut.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> DonutAsync(string name, string from) => this.SendAsync("/donut", name, from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="do" /> the fucking <paramref name="something" />!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="do">The thing to do.</param>
        /// <param name="something">The thing something is done to.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> DoSomethingAsync(string @do, string something, string from) =>
            this.SendAsync("/dosomething", @do, something, from);

        /// <inheritdoc />
        /// <summary>
        /// Equity only? Long hours? Zero Pay? Well <paramref name="name" />, just sign me right the fuck up.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> EquityAsync(string name, string from) => this.SendAsync("/equity", name, from);

        /// <inheritdoc />
        /// <summary>
        /// I can't fuckin' even.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> EvenAsync(string from) => this.SendAsync("/even", from);

        /// <inheritdoc />
        /// <summary>
        /// Everyone can go and fuck off.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> EveryoneAsync(string from) => this.SendAsync("/everyone", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck everything.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> EverythingAsync(string from) => this.SendAsync("/everything", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck you, your whole family, your pets, and your feces.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> FamilyAsync(string from) => this.SendAsync("/family", from);

        /// <inheritdoc />
        /// <summary>
        /// Fascinating story, in what chapter do you shut the fuck up?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> FascinatingAsync(string from) => this.SendAsync("/fascinating", from);

        /// <inheritdoc />
        /// <summary>
        /// Go fuck yourself <paramref name="name" />, you'll disappoint fewer people.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> FewerAsync(string name, string from) => this.SendAsync("/fewer", name, from);

        /// <inheritdoc />
        /// <summary>
        /// And <paramref name="name" /> said unto <paramref name="from" />, 'Verily, cast thine eyes upon the field in
        /// which I grow my fucks', and <paramref name="from" /> gave witness unto the field, and saw that it was
        /// barren.
        /// - <paramref name="reference" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">Who it is said unto.</param>
        /// <param name="reference">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> FieldAsync(string name, string from, string reference) =>
            this.SendAsync("/field", name, from, reference);

        /// <inheritdoc />
        /// <summary>
        /// I don't give a flying fuck.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> FlyingAsync(string from) => this.SendAsync("/flying", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck That, Fuck You
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> FtfyAsync(string from) => this.SendAsync("/ftfy", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck that shit, <paramref name="name" />.
        /// - <paramref name="from1" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from1">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> FtsAsync(string name, string from1) => this.SendAsync("/fts", name, from1);

        /// <inheritdoc />
        /// <summary>
        /// Golf foxtrot yankee, <paramref name="name" />.
        /// - <paramref name="from1" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from1">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> GfyAsync(string name, string from1) => this.SendAsync("/gfy", name, from1);

        /// <inheritdoc />
        /// <summary>
        /// I give zero fucks.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> GiveAsync(string from) => this.SendAsync("/give", from);

        /// <inheritdoc />
        /// <summary>
        /// The point is, ladies and gentleman, that <paramref name="noun" /> -- for lack of a better word -- is good.
        /// <paramref name="noun" /> is right. <paramref name="noun" /> works. <paramref name="noun" /> clarifies, cuts
        /// through, and captures the essence of the evolutionary spirit. <paramref name="noun" />, in all of its forms
        /// -- <paramref name="noun" /> for life, for money, for love, knowledge -- has marked the upward surge of
        /// mankind.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="noun">The noun.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> GreedAsync(string noun, string from) => this.SendAsync("/greed", noun, from);

        /// <inheritdoc />
        /// <summary>
        /// I don't want to talk to you, no more, you empty-headed animal, food trough wiper. I fart in your general
        /// direction. Your mother was a hamster and your father smelt of elderberries. Now go away or I shall taunt
        /// you a second time.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> HolyGrailAsync(string from) => this.SendAsync("/holygrail", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck you and the horse you rode in on.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> HorseAsync(string from) => this.SendAsync("/horse", from);

        /// <inheritdoc />
        /// <summary>
        /// That sounds like a fucking great idea!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> IdeaAsync(string from) => this.SendAsync("/idea", from);

        /// <inheritdoc />
        /// <summary>
        /// You can not imagine the immensity of the FUCK I do not give.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ImmensityAsync(string from) => this.SendAsync("/immensity", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck you, you fucking fuck.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> FyyffAsync(string from) => this.SendAsync("/fyyff", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck you, fuck me, fuck your family. Fuck your father, fuck your mother, fuck you and me.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> JingleBellsAsync(string from) => this.SendAsync("/jinglebells", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />: Fuck off. And when you get there, fuck off from there too. Then fuck off some
        /// more. Keep fucking off until you get back here. Then fuck off again.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> KeepAsync(string name, string from) => this.SendAsync("/keep", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Keep the fuck calm and <paramref name="reaction" />!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="reaction">The reaction.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> KeepCalmAsync(string reaction, string from) =>
            this.SendAsync("/keepcalm", reaction, from);

        /// <inheritdoc />
        /// <summary>
        /// Oh fuck off, just really fuck off you total dickface. Christ, <paramref name="name" />, you are fucking
        /// thick.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> KingAsync(string name, string from) => this.SendAsync("/king", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fucking fuck off, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> IngAsync(string name, string from) => this.SendAsync("/ing", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck my life.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> LifeAsync(string from) => this.SendAsync("/life", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, there aren't enough swear-words in the English language, so now I'll have to call
        /// you perkeleen vittupää just to express my disgust and frustration with this crap.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> LinusAsync(string name, string from) => this.SendAsync("/linus", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Check your fucking logs!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> LogsAsync(string from) => this.SendAsync("/logs", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, do I look like I give a fuck?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> LookAsync(string name, string from) => this.SendAsync("/look", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Looking for a fuck to give.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> LookingAsync(string from) => this.SendAsync("/looking", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, you're a fucking legend.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> LegendAsync(string name, string from) => this.SendAsync("/legend", name, from);

        /// <inheritdoc />
        /// <summary>
        /// What you've just said is one of the most insanely idiotic things I have ever heard,
        /// <paramref name="name" />. At no point in your rambling, incoherent response were you even close to anything
        /// that could be considered a rational thought. Everyone in this room is now dumber for having listened to it.
        /// I award you no points <paramref name="name" />, and may God have mercy on your soul.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> MadisonAsync(string name, string from) => this.SendAsync("/madison", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Maybe. Maybe not. Maybe fuck yourself.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> MaybeAsync(string from) => this.SendAsync("/maybe", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck me.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> MeAsync(string from) => this.SendAsync("/me", from);

        /// <inheritdoc />
        /// <summary>
        /// Happy fuckin' mornin'!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> MorninAsync(string from) => this.SendAsync("/mornin", from);

        /// <inheritdoc />
        /// <summary>
        /// No fucks given.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> NoAsync(string from) => this.SendAsync("/no", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck off, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> OffAsync(string name, string from) => this.SendAsync("/off", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck off with <paramref name="behavior" />
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="behavior">The behavior.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> OffWithAsync(string behavior, string from) =>
            this.SendAsync("/off-with", behavior, from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, why don't you go outside and play hide-and-go-fuck-yourself?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> OutsideAsync(string name, string from) => this.SendAsync("/outside", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck this <paramref name="thing" /> in particular.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="thing">The thing.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ParticularAsync(string thing, string from) =>
            this.SendAsync("/particular", thing, from);

        /// <inheritdoc />
        /// <summary>
        /// Well, fuck me pink.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> PinkAsync(string from) => this.SendAsync("/pink", from);

        /// <inheritdoc />
        /// <summary>
        /// What the fuck is your problem <paramref name="name" />?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ProblemAsync(string name, string from) => this.SendAsync("/problem", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck you, I'm a programmer, bitch!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ProgrammerAsync(string from) => this.SendAsync("/programmer", from);

        /// <inheritdoc />
        /// <summary>
        /// Well <paramref name="name" />, aren't you a shining example of a rancid fuck-nugget.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> NuggetAsync(string name, string from) => this.SendAsync("/nugget", name, from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="language" />, motherfucker, do you speak it?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="language">The language.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> PulpAsync(string language, string from) => this.SendAsync("/pulp", language, from);

        /// <inheritdoc />
        /// <summary>
        /// Eo fuck off, or to fuck off (that is not a question).
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> QuestionAsync(string from) => this.SendAsync("/question", from);

        /// <inheritdoc />
        /// <summary>
        /// I don't give a rat's arse.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> RatsArseAsync(string from) => this.SendAsync("/ratsarse", from);

        /// <inheritdoc />
        /// <summary>
        /// You Fucktard!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> RetardAsync(string from) => this.SendAsync("/retard", from);

        /// <inheritdoc />
        /// <summary>
        /// That's fucking ridiculous.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> RidiculousAsync(string from) => this.SendAsync("/ridiculous", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, you're a fucking Rock Star!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> RockstarAsync(string name, string from) => this.SendAsync("/rockstar", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Read the fucking manual!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> RtfmAsync(string from) => this.SendAsync("/rtfm", from);

        /// <inheritdoc />
        /// <summary>
        /// For Fuck's sake!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> SakeAsync(string from) => this.SendAsync("/sake", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, Thou clay-brained guts, thou knotty-pated fool, thou whoreson obscene greasy
        /// tallow-catch!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ShakespeareAsync(string name, string from) =>
            this.SendAsync("/shakespeare", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck this shit!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ShitAsync(string from) => this.SendAsync("/shit", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, shut the fuck up.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ShutUpAsync(string name, string from) => this.SendAsync("/shutup", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Not a single fuck was given.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> SingleAsync(string from) => this.SendAsync("/single", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck you very much.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ThanksAsync(string from) => this.SendAsync("/thanks", from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck that.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ThatAsync(string from) => this.SendAsync("/that", from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, you think I give a fuck?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ThinkAsync(string name, string from) => this.SendAsync("/think", name, from);

        /// <inheritdoc />
        /// <summary>
        /// <paramref name="name" />, what the fuck were you actually thinking?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ThinkingAsync(string name, string from) => this.SendAsync("/thinking", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck this.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ThisAsync(string from) => this.SendAsync("/this", from);

        /// <inheritdoc />
        /// <summary>
        /// Who has two thumbs and doesn't give a fuck? <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ThumbsAsync(string name, string from) => this.SendAsync("/thumbs", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Thanks, fuck you too.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> TooAsync(string from) => this.SendAsync("/too", from);

        /// <inheritdoc />
        /// <summary>
        /// Come the fuck in or fuck the fuck off.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> TuckerAsync(string from) => this.SendAsync("/tucker", from);

        /// <inheritdoc />
        /// <summary>
        /// What the fuck‽
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> WhatAsync(string from) => this.SendAsync("/what", from);

        /// <inheritdoc />
        /// <summary>
        /// Merry Fucking Christmas, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> XmasAsync(string name, string from) => this.SendAsync("/xmas", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck off, you must, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> YodaAsync(string name, string from) => this.SendAsync("/yoda", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Fuck you, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> YouAsync(string name, string from) => this.SendAsync("/you", name, from);

        /// <inheritdoc />
        /// <summary>
        /// Ask me if I give a motherfuck ?!!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ZaynAsync(string from) => this.SendAsync("/zayn", from);

        /// <inheritdoc />
        /// <summary>
        /// Zero, that's the number of fucks I give.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> ZeroAsync(string from) => this.SendAsync("/zero", from);

        /// <inheritdoc />
        /// <summary>
        /// I don't waste my fucking time with your bullshit <paramref name="name" />!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> WasteAsync(string name, string from) => this.SendAsync("/waste", name, from);

        /// <inheritdoc />
        /// <summary>
        /// FOAAS - Version 2.3.1 FOAAS.
        /// </summary>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasResponse" />.
        /// </returns>
        public Task<FoaasResponse> VersionAsync() => this.SendAsync("/version");

        /// <inheritdoc />
        /// <summary>
        /// Gets a list of available operations.
        /// </summary>
        /// <returns>
        /// Asynchronous <see cref="Task{T}" /> with <see cref="FoaasOperationsResponse" />.
        /// </returns>
        public async Task<FoaasOperationsResponse> OperationsAsync() => new FoaasOperationsResponse
        {
            Operations = JsonConvert.DeserializeObject<FoaasOperationsResponse.Operation[]>(
                await this._client.GetStringAsync("/operations").ConfigureAwait(false))
        };

        /// <summary>
        /// Sends the request to FOAAS with the specified parameters and returns the response.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>An asynchronous <see cref="Task{T}" /> containing a <see cref="FoaasResponse" />.</returns>
        private async Task<FoaasResponse> SendAsync(string path, params string[] parameters)
        {
            StringBuilder requestString = new StringBuilder(path);

            requestString.Append("/");
            requestString.Append(string.Join("/", parameters));
            if (this._clientConfiguration.ShoutCloud)
            {
                requestString.Append("?shoutcloud");
            }

            if (!string.IsNullOrWhiteSpace(this._clientConfiguration.I18N))
            {
                requestString.Append(this._clientConfiguration.ShoutCloud
                    ? $"&i8n={this._clientConfiguration.I18N}"
                    : "?i8n={_clientConfiguration.I18n}");
            }

            return JsonConvert.DeserializeObject<FoaasResponse>(
                await this._client.GetStringAsync(requestString.ToString()).ConfigureAwait(false));
        }
    }
}
