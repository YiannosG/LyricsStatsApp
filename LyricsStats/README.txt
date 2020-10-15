INSTALLATION - Running Instructions
------------
If he project has been unzipped, place the contents to any local file. From there, Run Visual Studio and direct it to the project folder.
Technologies used is Visual Studio Community 2019, .NET Core 3.1 and Blazor. NuGet packages used: Newtonsoft.Json, CodeDom, and System.Net.Http.Json. Their usefulness is further discussed in the Developer Notes.

The project runs by building it and running it on IIS Express.
First thing you will see is the Home page, which presents you with a searchbox.
You have to enter an artist's name - either capitals or lowercase - and Enter, or click the Search button.

The API returns more than one name since it stores tribute bands etc. Country of origin and disambiguation text can help the user decide which one is the artist he intended. Usually the most popular artist will come up
top of the list. Additionally, you are presented with the Musicbrainz ID of the artist, if one feels to validate it directly on the API. Clicking the Fetch button, begins the process of grabing the lyrics data and their parsing.

After about a minute, you will be navigated to a third page where you will see the results.

Tests
-----

Are in the project LyricsStatsTests.

Developer Notes
---------------

This is more of as-I-go diary of the construction process

(1) => Startup.cs => ConfigureServices()
.NET Core is using Dependency Injection for the configuration of its services in the Startup.cs file, and in particular, the ConfigureServices method.
I will be adding the HttpClient service there, which now uses HttpClientFactory, so it can be called at any time without worries. 

The LyricsData Razor component is going to be getting the data from our API.

Going to add a new model to contain that data.
I name the model "ArtistModel" and paste the resulting JSON from the below query, as classes, using VS's Paste Special command (very nice)

		http://musicbrainz.org/ws/2/artist/?query=artist:"Skid Row"&fmt=json
The above musicbrainz API is fetching us all artists, whose name includes the string "Skid Row" in the json format. That last "fmt" bit had to be included as the API returns XML by default.
I chose to deal with JSON since it makes for cleaner classes after deserialisation, in C#
Now, I chose the name "Skid Row" on purpose, because I knew that back in the day, the US band Skid Row, upon foundation, ran into some trouble with that name, because there had been another band
in Ireland, named also Skid Row, in the seventies, that included guitarist Gary Moore. Therefore I would need to take into account perhaps any special classes that would appear in the result,
due to the need for disambiguation. This information seems to be standard in the "artist" query results for musicbrainz, so that is ok. I will disambiguate by giving the user a choice which
artist he meant, by presenting him with the disambiguation text.

Renamed RootModel to ArtistModel

The whole idea of this part is to get the MBID of the artist, to later use to extract further information, as searching by Artist's name only, can be ambiguous, as we already mentioned.

Right now I am thinking that the extraction of all the lyrics for an artist, would be a 1-2-3 step process, where we have the above MBID extraction process, resolve name ambiguity, then
get the discography of the artist and finally all the tracks in those releases. That would then be the statistical sample we'd have in place, for the moment the user selects that Artist.
This strategy will be re-visited if needed.

Added the new Lyrics Data razor page to our main navigation page, NavMenu

Still at the razor page, we use Dependency Injection to inject the httpClientFactory. After this is done, we initialize async.
We then create a new client using our factory. This is important as the factory uses a pool of clients from which it pulls from based on some internal rules. It might close an existing one
before pulling a new one, etc, in other words it avoids port exhaustion that could result from having too many clients open, as well as simple machine overhead. The factory will take care 
closing the clients after creating them, and managing them so we don't have to worry about their disposal and other things.

Momentarily jumping over to our_Imports.razor file, to include the "using" for our Models domain. Then we can have our ArtistModel available to our Razor page without including the domain
prefix. Adding another "using" to include my NuGet json extension package, in order to read from the response.

(2) => LyricsData.razor => OnInitializedAsync()
The method in question is GetFromJsonAsync, which will read the response's JSON and put it into our strong-typed model.

Inserted some standard error notification to our razor page, in case our error string contains something. Also, if the artist model is still null, it means we're waiting...

Note to self: Don't forget to set a user agent, or you might get Forbidden message from API ;)

At this stage I take a break to make a little refactoring, specifically use a try catch block in the main loop (to sub in for an if statement) and use the config file to store the base
API URL as a prefix. Also, going to add another client, this time with a named configuration, that will have that user agent set, as well as the base URL address.

(2) at this stage of course holds parameters for a specific, hard coded string. Eventually it will pick those parameters from the user.

We now have 2 clients, an uncofigured and a configured one, and we can use either accordingly.

To grab user's input for Artist, I actually create an input model, in case we'd want to expand input at this stage. SearchModel

Trying to fetch results for AC/DC, realized that slashes break the app, so added a decoration to the input model, with a RegEx that stop them at the gate. Entering AC DC or AC-DC fetches the right results

Unfortunately, the "clever" JSON extensions I installed, do not always work, as I found, working on my Fetch method, which uses a lookup rather than a query on the musicbrainz URL.
I tested the exact same URL I was sending across, and it worked fine on the browser, but did not want to cooperate with the extentsions, this time. GetFromJsonAsync, to be precise.
The solution, was to revert to the traditional deserialisation method I was familiar with (and fetch, sorry) but this time, I took the opportunity to use streams. A stream will skip the parsing of the API data
and once the content has arrived, it will skip straight to deserializing to the model, without the need to create the in-between string. This makes things faster, and lessens memory usage. To illustrate, I am leaving
the initial method as well as the stream method. Also, I thought those extensions were cool :) I want to test their performance, and how they compare with streams.

Another bump on the road was the class. As I mentioned, the artist class was generated with VS Paste Special command. Unfortunately, that didnt work either, when I tried to get the releases. I substituted it for the
Newtonsoft.Json class format, with its decorators, and that worked fine. I used an online JSON2C# nconverter to get the classes and just renamed Root to my own class.

At this point the app works, as it delivers the average number of words for a required artist.

Optional Work
-------------

Blazor is new to me, so going to try to keep artist results for comparison, using Blazor's in-memory container service.

1. Adding a class StateContainer.cs
2. Using dependency injection, and using assembles  Microsoft.AspNetCore.Components.WebAssembly.Hosting and Microsoft.Extensions.DependencyInjection, I inject StateContainer singleton into the Main method of 
Program.cs : builder.Services.AddSingleton<StateContainer>();
3. Starting the service in Startup.cs : services.AddSingleton<StateContainer>();
4. Implementing changes to Results page, after injecting the StateContainer there.


Technologies used
-----------------

1) Blazor - I envisaged a web app, and Blazor is made to do that, and more. I haven't done Blazor before, so it is an opportunity for me to familiarise.
2) A single nuget package called System.Net.Http.Json - It is extension methods that provide automatic serialisation and deserialisation for HttpClient and HttpContent, when using System.Text.Json
	It will make my life a bit easier.
3) Razor - Blazor consists of Razor components. Razor page is server side only, so I will add a Razor component (called LyricsData.razor)


