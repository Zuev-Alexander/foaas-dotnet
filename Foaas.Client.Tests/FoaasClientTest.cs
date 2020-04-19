using System;
using System.Threading.Tasks;
using Bogus;
using Xunit;

namespace Foaas.Client.Tests
{
    public class FoaasClientTest
    {
        private readonly IFoaasClient _client;

        private readonly TestData testData;

        private class TestData
        {
            public string Company { get; set; }
            public string From { get; set; }
            public string Name { get; set; }
            public string Reference { get; set; }
            public string Language { get; set; }
            public string Behavior { get; set; }
            public string Tool { get; set; }
            public string Do { get; set; }
            public string Something { get; set; }
            public string Noun { get; set; }
            public string Reaction { get; set; }
            public string Thing { get; set; }
        }

        public FoaasClientTest()
        {
            _client = new FoaasClient();

            //TODO generate data according to properties
            var faker = new Faker<TestData>()
                .RuleFor(u => u.Company, f => f.Name.FirstName())
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

            testData = faker.Generate();
        }

        [Fact]
        public async Task FuckingVersionWorks()
        {
            var response = await _client.Version();

            Assert.NotNull(response);
            Assert.Equal("FOAAS", response.Subtitle);
        }

        [Fact]
        public async Task FuckingOperationsWorks()
        {
            var response = await _client.Operations();

            Assert.NotNull(response);
        }

        [Fact]
        public async Task FuckingAnywayWorks()
        {
            var response = await _client.Anyway(testData.Company, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Who the fuck are you anyway, {testData.Company}, why are you stirring up so much trouble, and, who pays you?"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingAssholeWorks()
        {
            var response = await _client.Asshole(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck you, asshole."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingAwesomeWorks()
        {
            var response = await _client.Awesome(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"This is Fucking Awesome."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingBackWorks()
        {
            var response = await _client.Back(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, back the fuck off."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingBagWorks()
        {
            var response = await _client.Bag(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Eat a bag of fucking dicks."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingBallmerWorks()
        {
            var response = await _client.Ballmer(testData.Name, testData.Company, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fucking {testData.Name} is a fucking pussy. I'm going to fucking bury that guy, I have done it before, and I will do it again. I'm going to fucking kill {testData.Company}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingBirthdayWorks()
        {
            var response = await _client.Birthday(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Happy Fucking Birthday, {testData.Name}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingBecauseWorks()
        {
            var response = await _client.Because(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Why? Because fuck you, that's why."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingBlackadderWorks()
        {
            var response = await _client.Blackadder(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, your head is as empty as a eunuch’s underpants. Fuck off!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingBucketWorks()
        {
            var response = await _client.Bucket(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Please choke on a bucket of cocks."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingBMWorks()
        {
            var response = await _client.Bm(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Bravo mike, {testData.Name}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingBusWorks()
        {
            var response = await _client.Bus(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Christ on a bendy-bus, {testData.Name}, don't be such a fucking faff-arse."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingByeBye()
        {
            var response = await _client.Bye(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuckity bye!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingCanIUseWorks()
        {
            var response = await _client.CanIUse(testData.Tool, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Can you use {testData.Tool}? Fuck no!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingChainsawWorks()
        {
            var response = await _client.Chainsaw(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck me gently with a chainsaw, {testData.Name}. Do I look like Mother Teresa?"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }


        [Fact]
        public async Task FuckingCocksplatWorks()
        {
            var response = await _client.Cocksplat(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck off {testData.Name}, you worthless cocksplat"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingCoolWorks()
        {
            var response = await _client.Cool(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Cool story, bro."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingCupWorks()
        {
            var response = await _client.Cup(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"How about a nice cup of shut the fuck up?"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingDaltonWorks()
        {
            var response = await _client.Dalton(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}: A fucking problem solving super-hero."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingDeraadtWorks()
        {
            var response = await _client.Deraadt(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name} you are being the usual slimy hypocritical asshole... You may have had value ten years ago, but people will see that you don't anymore."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingDiabetesMan()
        {
            var response = await _client.Diabetes(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"I'd love to stop and chat to you but I'd rather have type 2 diabetes."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingDonutWorks()
        {
            var response = await _client.Donut(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, go and take a flying fuck at a rolling donut."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingDoSomething()
        {
            var response = await _client.DoSomething(testData.Do, testData.Something, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Do} the fucking {testData.Something}!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingEquityWorks()
        {
            var response = await _client.Equity(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Equity only? Long hours? Zero Pay? Well {testData.Name}, just sign me right the fuck up."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingEvenWorks()
        {
            var response = await _client.Even(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"I can't fuckin' even."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingEveryoneWorks()
        {
            var response = await _client.Everyone(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Everyone can go and fuck off."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingEverythingWorks()
        {
            var response = await _client.Everything(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck everything."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingFamilyAndPetsWorks()
        {
            var response = await _client.Family(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck you, your whole family, your pets, and your feces."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingFascinating()
        {
            var response = await _client.Fascinating(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fascinating story, in what chapter do you shut the fuck up?"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingFewerWorks()
        {
            var response = await _client.Fewer(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Go fuck yourself {testData.Name}, you'll disappoint fewer people."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingFieldWorks()
        {
            var response = await _client.Field(testData.Name, testData.From, testData.Reference);

            Assert.NotNull(response);
            Assert.Equal($@"And {testData.Name} said unto {testData.From}, 'Verily, cast thine eyes upon the field in which I grow my fucks', and {testData.From} gave witness unto the field, and saw that it was barren."
                , response.Message);
            Assert.Equal($@"- {testData.Reference}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingFlyingWorks()
        {
            var response = await _client.Flying(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"I don't give a flying fuck."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingFTFYWorks()
        {
            var response = await _client.FTFY(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck That, Fuck You"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingFTSWorks()
        {
            var response = await _client.FTS(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck that shit, {testData.Name}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingGFYWorks()
        {
            var response = await _client.GFY(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Golf foxtrot yankee, {testData.Name}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingGiveWorks()
        {
            var response = await _client.Give(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"I give zero fucks."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingGreedWorks()
        {
            var response = await _client.Greed(testData.Noun, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"The point is, ladies and gentleman, that {testData.Noun.ToLower()} -- for lack of a better word -- is good. {testData.Noun} is right. {testData.Noun} works. {testData.Noun} clarifies, cuts through, and captures the essence of the evolutionary spirit. {testData.Noun}, in all of its forms -- {testData.Noun} for life, for money, for love, knowledge -- has marked the upward surge of mankind."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingHolyGrailWorks()
        {
            var response = await _client.HolyGrail(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"I don't want to talk to you, no more, you empty-headed animal, food trough wiper. I fart in your general direction. Your mother was a hamster and your father smelt of elderberries. Now go away or I shall taunt you a second time."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingHorseWorks()
        {
            var response = await _client.Horse(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck you and the horse you rode in on."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingIdeaWorks()
        {
            var response = await _client.Idea(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"That sounds like a fucking great idea!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingImmensityWorks()
        {
            var response = await _client.Immensity(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"You can not imagine the immensity of the FUCK I do not give."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingFYYFFWorks()
        {
            var response = await _client.FYYFF(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck you, you fucking fuck."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingJingleBellsWorks()
        {
            var response = await _client.JingleBells(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck you, fuck me, fuck your family. Fuck your father, fuck your mother, fuck you and me."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingKeepWorks()
        {
            var response = await _client.Keep(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}: Fuck off. And when you get there, fuck off from there too. Then fuck off some more. Keep fucking off until you get back here. Then fuck off again."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingKeepCalm()
        {
            var response = await _client.KeepCalm(testData.Reaction, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Keep the fuck calm and {testData.Reaction}!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingAllHailTheKing()
        {
            var response = await _client.King(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Oh fuck off, just really fuck off you total dickface. Christ, {testData.Name}, you are fucking thick."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingIngWorks()
        {
            var response = await _client.Ing(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fucking fuck off, {testData.Name}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingLifeWorks()
        {
            var response = await _client.Life(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck my life."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingLinusWorks()
        {
            var response = await _client.Linus(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, there aren't enough swear-words in the English language, so now I'll have to call you perkeleen vittupää just to express my disgust and frustration with this crap."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingLogging()
        {
            var response = await _client.Logs(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Check your fucking logs!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingJustLook()
        {
            var response = await _client.Look(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, do I look like I give a fuck?"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingLookingWorks()
        {
            var response = await _client.Looking(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Looking for a fuck to give."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingLegendary()
        {
            var response = await _client.Legend(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, you're a fucking legend."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingMadisonWorks()
        {
            var response = await _client.Madison(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"What you've just said is one of the most insanely idiotic things I have ever heard, {testData.Name}. At no point in your rambling, incoherent response were you even close to anything that could be considered a rational thought. Everyone in this room is now dumber for having listened to it. I award you no points {testData.Name}, and may God have mercy on your soul."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingCallMeMaybe()
        {
            var response = await _client.Maybe(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Maybe. Maybe not. Maybe fuck yourself."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingFuckMe()
        {
            var response = await _client.Me(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck me."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingMorningWorks()
        {
            var response = await _client.Mornin(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Happy fuckin' mornin'!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingNoooo()
        {
            var response = await _client.No(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"No fucks given."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingOff()
        {
            var response = await _client.Off(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck off, {testData.Name}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingOffWithWorks()
        {
            var response = await _client.OffWith(testData.Behavior, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck off with {testData.Behavior}"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingOutsideWorks()
        {
            var response = await _client.Outside(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, why don't you go outside and play hide-and-go-fuck-yourself?"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingParticularWorks()
        {
            var response = await _client.Particular(testData.Thing, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck this {testData.Thing} in particular."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingPinkWorks()
        {
            var response = await _client.Pink(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Well, fuck me pink."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingProblemWorks()
        {
            var response = await _client.Problem(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"What the fuck is your problem {testData.Name}?"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingProgrammerWorks()
        {
            var response = await _client.Programmer(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck you, I'm a programmer, bitch!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingNuggetWorks()
        {
            var response = await _client.Nugget(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Well {testData.Name}, aren't you a shining example of a rancid fuck-nugget."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingPulpWorks()
        {
            var response = await _client.Pulp(testData.Language, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Language}, motherfucker, do you speak it?"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingQuestionWorks()
        {
            var response = await _client.Question(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"To fuck off, or to fuck off (that is not a question)"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingRatsarseWorks()
        {
            var response = await _client.Ratsarse(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"I don't give a rat's arse."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingRetard()
        {
            var response = await _client.Retard(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"You Fucktard!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingRidiculous()
        {
            var response = await _client.Ridiculous(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"That's fucking ridiculous"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingRockstarWorks()
        {
            var response = await _client.Rockstar(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, you're a fucking Rock Star!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingRTFMWorks()
        {
            var response = await _client.RTFM(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Read the fucking manual!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingSakeWorks()
        {
            var response = await _client.Sake(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"For Fuck's sake!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingShakespeareWorks()
        {
            var response = await _client.Shakespeare(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, Thou clay-brained guts, thou knotty-pated fool, thou whoreson obscene greasy tallow-catch!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingShitWorks()
        {
            var response = await _client.Shit(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck this shit!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingShutup()
        {
            var response = await _client.ShutUp(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, shut the fuck up."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingSingleWorks()
        {
            var response = await _client.Single(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Not a single fuck was given."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingThanksWorks()
        {
            var response = await _client.Thanks(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck you very much."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingThatWorks()
        {
            var response = await _client.That(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck that."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingThink()
        {
            var response = await _client.Think(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, you think I give a fuck?"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingThinkingWorks()
        {
            var response = await _client.Thinking(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"{testData.Name}, what the fuck were you actually thinking?"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingThisWorks()
        {
            var response = await _client.This(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck this."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingThumbsWorks()
        {
            var response = await _client.Thumbs(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Who has two thumbs and doesn't give a fuck? {testData.Name}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingTooMuch()
        {
            var response = await _client.Too(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Thanks, fuck you too."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingTuckerWorks()
        {
            var response = await _client.Tucker(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Come the fuck in or fuck the fuck off."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingWhatMate()
        {
            var response = await _client.What(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"What the fuck‽"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingXmasWorks()
        {
            var response = await _client.Xmas(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Merry Fucking Christmas, {testData.Name}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task YodaFucking()
        {
            var response = await _client.Yoda(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck off, you must, {testData.Name}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingYou()
        {
            var response = await _client.You(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Fuck you, {testData.Name}."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingZaynWorks()
        {
            var response = await _client.Zayn(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Ask me if I give a motherfuck ?!!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingZeroFucksGiven()
        {
            var response = await _client.Zero(testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"Zero, that's the number of fucks I give."
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

        [Fact]
        public async Task FuckingWasteOfTime()
        {
            var response = await _client.Waste(testData.Name, testData.From);

            Assert.NotNull(response);
            Assert.Equal($@"I don't waste my fucking time with your bullshit {testData.Name}!"
                , response.Message);
            Assert.Equal($@"- {testData.From}"
                , response.Subtitle);
        }

    }
}
