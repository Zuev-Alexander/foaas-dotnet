// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFoaasClient.cs" company="Alexander Zuev">
//   Copyright (C) Alexander Zuev. All rights reserved.
// </copyright>
// <summary>
//   Defines Fuck Off as a Service client operations.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Foaas.Client
{
    using System.Threading.Tasks;

    using Foaas.Client.Responses;

    /// <summary>
    /// Defines Fuck Off as a Service client operations.
    /// </summary>
    public interface IFoaasClient
    {
        /// <summary>
        /// FOAAS - Version 2.3.1 FOAAS.
        /// </summary>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> VersionAsync();

        /// <summary>
        /// Gets a list of available operations.
        /// </summary>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasOperationsResponse"/>.</returns>
        Task<FoaasOperationsResponse> OperationsAsync();

        /// <summary>
        /// Who the fuck are you anyway, <paramref name="company" />, why are you stirring up so much trouble, and, who
        /// pays you?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> AnywayAsync(string company, string from);

        /// <summary>
        /// Fuck you, asshole.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> AssholeAsync(string from);

        /// <summary>
        /// This is Fucking Awesome.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> AwesomeAsync(string from);

        /// <summary>
        /// <paramref name="name" />, back the fuck off.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> BackAsync(string name, string from);

        /// <summary>
        /// Eat a bag of fucking dicks.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> BagAsync(string from);

        /// <summary>
        /// Fucking <paramref name="name" /> is a fucking pussy. I'm going to fucking bury that guy, I have done it
        /// before, and I will do it again. I'm going to fucking kill <paramref name="company" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="company">The company.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> BallmerAsync(string name, string company, string from);

        /// <summary>
        /// Happy Fucking Birthday, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> BirthdayAsync(string name, string from);

        /// <summary>
        /// Why? Because fuck you, that's why.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> BecauseAsync(string from);

        /// <summary>
        /// <paramref name="name" />, your head is as empty as a eunuch’s underpants. Fuck off!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> BlackadderAsync(string name, string from);

        /// <summary>
        /// Please choke on a bucket of cocks.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> BucketAsync(string from);

        /// <summary>
        /// Bravo mike, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> BmAsync(string name, string from);

        /// <summary>
        /// Christ on a bendy-bus, <paramref name="name" />, don't be such a fucking faff-arse.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> BusAsync(string name, string from);

        /// <summary>
        /// Fuckity bye!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ByeAsync(string from);

        /// <summary>
        /// Can you use <paramref name="tool" />? Fuck no!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="tool">The tool.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> CanIUseAsync(string tool, string from);

        /// <summary>
        /// Fuck me gently with a chainsaw, <paramref name="name" />. Do I look like Mother Teresa?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ChainsawAsync(string name, string from);

        /// <summary>
        /// Fuck off <paramref name="name" />, you worthless cocksplat.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> CocksplatAsync(string name, string from);

        /// <summary>
        /// Cool story, bro.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> CoolAsync(string from);

        /// <summary>
        /// How about a nice cup of shut the fuck up?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> CupAsync(string from);

        /// <summary>
        /// <paramref name="name" />: A fucking problem solving super-hero.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> DaltonAsync(string name, string from);

        /// <summary>
        /// <paramref name="name" /> you are being the usual slimy hypocritical asshole... You may have had value ten
        /// years ago, but people will see that you don't anymore.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> DeraadtAsync(string name, string from);

        /// <summary>
        /// I'd love to stop and chat to you but I'd rather have type 2 diabetes.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> DiabetesAsync(string from);

        /// <summary>
        /// <paramref name="name" />, go and take a flying fuck at a rolling donut.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> DonutAsync(string name, string from);

        /// <summary>
        /// <paramref name="do" /> the fucking <paramref name="something" />!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="do">The thing to do.</param>
        /// <param name="something">The thing something is done to.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> DoSomethingAsync(string @do, string something, string from);

        /// <summary>
        /// Equity only? Long hours? Zero Pay? Well <paramref name="name" />, just sign me right the fuck up.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> EquityAsync(string name, string from);

        /// <summary>
        /// I can't fuckin' even.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> EvenAsync(string from);

        /// <summary>
        /// Everyone can go and fuck off.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> EveryoneAsync(string from);

        /// <summary>
        /// Fuck everything.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> EverythingAsync(string from);

        /// <summary>
        /// Fuck you, your whole family, your pets, and your feces.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> FamilyAsync(string from);

        /// <summary>
        /// Fascinating story, in what chapter do you shut the fuck up?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> FascinatingAsync(string from);

        /// <summary>
        /// Go fuck yourself <paramref name="name" />, you'll disappoint fewer people.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> FewerAsync(string name, string from);

        /// <summary>
        /// And <paramref name="name" /> said unto <paramref name="from" />, 'Verily, cast thine eyes upon the field in
        /// which I grow my fucks', and <paramref name="from" /> gave witness unto the field, and saw that it was
        /// barren.
        /// - <paramref name="reference" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">Who it is said unto.</param>
        /// <param name="reference">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> FieldAsync(string name, string from, string reference);

        /// <summary>
        /// I don't give a flying fuck.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> FlyingAsync(string from);

        /// <summary>
        /// Fuck That, Fuck You
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> FtfyAsync(string from);

        /// <summary>
        /// Fuck that shit, <paramref name="name" />.
        /// - <paramref name="from1" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from1">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> FtsAsync(string name, string from1);

        /// <summary>
        /// Golf foxtrot yankee, <paramref name="name" />.
        /// - <paramref name="from1" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from1">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> GfyAsync(string name, string from1);

        /// <summary>
        /// I give zero fucks.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> GiveAsync(string from);

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
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> GreedAsync(string noun, string from);

        /// <summary>
        /// I don't want to talk to you, no more, you empty-headed animal, food trough wiper. I fart in your general
        /// direction. Your mother was a hamster and your father smelt of elderberries. Now go away or I shall taunt
        /// you a second time.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> HolyGrailAsync(string from);

        /// <summary>
        /// Fuck you and the horse you rode in on.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> HorseAsync(string from);

        /// <summary>
        /// That sounds like a fucking great idea!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> IdeaAsync(string from);

        /// <summary>
        /// You can not imagine the immensity of the FUCK I do not give.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ImmensityAsync(string from);

        /// <summary>
        /// Fuck you, you fucking fuck.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> FyyffAsync(string from);

        /// <summary>
        /// Fuck you, fuck me, fuck your family. Fuck your father, fuck your mother, fuck you and me.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> JingleBellsAsync(string from);

        /// <summary>
        /// <paramref name="name" />: Fuck off. And when you get there, fuck off from there too. Then fuck off some
        /// more. Keep fucking off until you get back here. Then fuck off again.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> KeepAsync(string name, string from);

        /// <summary>
        /// Keep the fuck calm and <paramref name="reaction" />!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="reaction">The reaction.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> KeepCalmAsync(string reaction, string from);

        /// <summary>
        /// Oh fuck off, just really fuck off you total dickface. Christ, <paramref name="name" />, you are fucking
        /// thick.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> KingAsync(string name, string from);

        /// <summary>
        /// Fucking fuck off, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> IngAsync(string name, string from);

        /// <summary>
        /// Fuck my life.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> LifeAsync(string from);

        /// <summary>
        /// <paramref name="name" />, there aren't enough swear-words in the English language, so now I'll have to call
        /// you perkeleen vittupää just to express my disgust and frustration with this crap.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> LinusAsync(string name, string from);

        /// <summary>
        /// Check your fucking logs!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> LogsAsync(string from);

        /// <summary>
        /// <paramref name="name" />, do I look like I give a fuck?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> LookAsync(string name, string from);

        /// <summary>
        /// Looking for a fuck to give.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> LookingAsync(string from);

        /// <summary>
        /// <paramref name="name" />, you're a fucking legend.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> LegendAsync(string name, string from);

        /// <summary>
        /// What you've just said is one of the most insanely idiotic things I have ever heard,
        /// <paramref name="name" />. At no point in your rambling, incoherent response were you even close to anything
        /// that could be considered a rational thought. Everyone in this room is now dumber for having listened to it.
        /// I award you no points <paramref name="name" />, and may God have mercy on your soul.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> MadisonAsync(string name, string from);

        /// <summary>
        /// Maybe. Maybe not. Maybe fuck yourself.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> MaybeAsync(string from);

        /// <summary>
        /// Fuck me.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> MeAsync(string from);

        /// <summary>
        /// Happy fuckin' mornin'!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> MorninAsync(string from);

        /// <summary>
        /// No fucks given.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> NoAsync(string from);

        /// <summary>
        /// Fuck off, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> OffAsync(string name, string from);

        /// <summary>
        /// Fuck off with <paramref name="behavior" />
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="behavior">The behavior.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> OffWithAsync(string behavior, string from);

        /// <summary>
        /// <paramref name="name" />, why don't you go outside and play hide-and-go-fuck-yourself?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> OutsideAsync(string name, string from);

        /// <summary>
        /// Fuck this <paramref name="thing" /> in particular.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="thing">The thing.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ParticularAsync(string thing, string from);

        /// <summary>
        /// Well, fuck me pink.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> PinkAsync(string from);

        /// <summary>
        /// What the fuck is your problem <paramref name="name" />?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ProblemAsync(string name, string from);

        /// <summary>
        /// Fuck you, I'm a programmer, bitch!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ProgrammerAsync(string from);

        /// <summary>
        /// Well <paramref name="name" />, aren't you a shining example of a rancid fuck-nugget.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> NuggetAsync(string name, string from);

        /// <summary>
        /// <paramref name="language" />, motherfucker, do you speak it?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="language">The language.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> PulpAsync(string language, string from);

        /// <summary>
        /// Eo fuck off, or to fuck off (that is not a question).
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> QuestionAsync(string from);

        /// <summary>
        /// I don't give a rat's arse.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> RatsArseAsync(string from);

        /// <summary>
        /// You Fucktard!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> RetardAsync(string from);

        /// <summary>
        /// That's fucking ridiculous.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> RidiculousAsync(string from);

        /// <summary>
        /// <paramref name="name" />, you're a fucking Rock Star!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> RockstarAsync(string name, string from);

        /// <summary>
        /// Read the fucking manual!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> RtfmAsync(string from);

        /// <summary>
        /// For Fuck's sake!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> SakeAsync(string from);

        /// <summary>
        /// <paramref name="name" />, Thou clay-brained guts, thou knotty-pated fool, thou whoreson obscene greasy
        /// tallow-catch!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ShakespeareAsync(string name, string from);

        /// <summary>
        /// Fuck this shit!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ShitAsync(string from);

        /// <summary>
        /// <paramref name="name" />, shut the fuck up.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ShutUpAsync(string name, string from);

        /// <summary>
        /// Not a single fuck was given.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> SingleAsync(string from);

        /// <summary>
        /// Fuck you very much.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ThanksAsync(string from);

        /// <summary>
        /// Fuck that.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ThatAsync(string from);

        /// <summary>
        /// <paramref name="name" />, you think I give a fuck?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ThinkAsync(string name, string from);

        /// <summary>
        /// <paramref name="name" />, what the fuck were you actually thinking?
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ThinkingAsync(string name, string from);

        /// <summary>
        /// Fuck this.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ThisAsync(string from);

        /// <summary>
        /// Who has two thumbs and doesn't give a fuck? <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ThumbsAsync(string name, string from);

        /// <summary>
        /// Thanks, fuck you too.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> TooAsync(string from);

        /// <summary>
        /// Come the fuck in or fuck the fuck off.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> TuckerAsync(string from);

        /// <summary>
        /// What the fuck‽
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> WhatAsync(string from);

        /// <summary>
        /// Merry Fucking Christmas, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> XmasAsync(string name, string from);

        /// <summary>
        /// Fuck off, you must, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> YodaAsync(string name, string from);

        /// <summary>
        /// Fuck you, <paramref name="name" />.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> YouAsync(string name, string from);

        /// <summary>
        /// Ask me if I give a motherfuck ?!!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ZaynAsync(string from);

        /// <summary>
        /// Zero, that's the number of fucks I give.
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> ZeroAsync(string from);

        /// <summary>
        /// I don't waste my fucking time with your bullshit <paramref name="name" />!
        /// - <paramref name="from" />
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="from">From whom.</param>
        /// <returns>Asynchronous <see cref="Task{T}"/> with <see cref="FoaasResponse"/>.</returns>
        Task<FoaasResponse> WasteAsync(string name, string from);
    }
}
