#pragma checksum "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "044008ad5a1b6839c243440481607aa1e30306f7"
// <auto-generated/>
#pragma warning disable 1591
namespace LyricsStats.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using LyricsStats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using LyricsStats.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using LyricsStats.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\MyCode\LyricsStatsApp\LyricsStats\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lyrics/{name}")]
    public partial class LyricsData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lyrics Data</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "You are looking for an artist that sounds like ");
            __builder.AddContent(3, 
#nullable restore
#line 7 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
                                                   Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 9 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
 if (spinner)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 12 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 16 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "h2");
            __builder.AddContent(10, 
#nullable restore
#line 18 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
                     errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 19 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
}
else if (artists is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.AddMarkupContent(13, "<div class=\"h4\">Loading...</div>\r\n");
#nullable restore
#line 23 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "    ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-striped");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.AddMarkupContent(18, @"<thead class=""thead-dark"">
            <tr>
                <th>Name</th>
                <th>Country</th>
                <th>Disambiguation</th>
                <th>MBID</th>
                <th>Fetch lyrics stats</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(19, "tbody");
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 37 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
             foreach (var artist in artists.artists)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "                ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 40 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
                         artist.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 41 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
                         artist.country

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 42 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
                         artist.disambiguation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 43 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
                         artist.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
                                            () => FetchFor(artist)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Fetch");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 46 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 49 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\LyricsData.razor"
       
    ArtistModel artists;
    ReleaseModel artistReleases;
    RecordingModel releaseRecordings;
    LyricsModel songLyrics;
    List<RecordingModel> allRecordings = new List<RecordingModel>();
    string errorString;
    List<string> uniqueSongs;
    bool spinner;

    [Parameter]
    public string Name { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var encoded = Uri.EscapeUriString(@Name);
        var client = _clientFactory.CreateClient("musicbrainz");    // asking for a specific client

        try
        {
            artists = await client.GetFromJsonAsync<ArtistModel>(Constants.ArtistQueryFront + encoded + Constants.ArtistQueryBack);   // (2)
            errorString = null;
        }
        catch (Exception ex)
        {
            errorString = $"Error while getting Artists response: { ex.Message }";
        }
    }

    private async Task FetchFor(Artist artist)
    {
        var encoded = Uri.EscapeUriString(artist.id);
        var client = _clientFactory.CreateClient("musicbrainz");
        var clientSecure = _clientFactory.CreateClient("musicbrainzSecure");
        var clientForLyrics = _clientFactory.CreateClient("Lyrics.ovh");
        string artistName = artist.name;
        int releasesCount = 0;
        decimal average = 0M;
        var jsonSerializer = new Newtonsoft.Json.JsonSerializer();

        spinner = true;

        string releasesUrl = Constants.GetReleasesFront + encoded + Constants.GetReleasesBack;

        var request = new HttpRequestMessage(HttpMethod.Get, releasesUrl);
        request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


        using (var response = await clientSecure.SendAsync(request))
        {
            try
            {

                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw ex;
            }

            var stream = await response.Content.ReadAsStreamAsync();

            using (var streamReader = new System.IO.StreamReader(stream))
            {
                using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                {
                    //var jsonSerializer = new Newtonsoft.Json.JsonSerializer();
                    artistReleases = jsonSerializer.Deserialize<ReleaseModel>(jsonTextReader);

                    releasesCount = artistReleases.ReleaseGroupCount;
                }
            }
        }

        // At this point, we have all the album and ep releases of the artist, now we want to pool all the tracks in those releases together

        // 1. Get all recordings for each release group
        // URL is like: http://musicbrainz.org/ws/2/recording/?query=rgid:0df8ee07-7d17-333c-8338-2ea24aaeac88

        StringBuilder recordingsUrl = new StringBuilder();
        int releaseGroupCounter = 0;

        foreach (var releaseGroup in artistReleases.ReleaseGroups)
        {
            if ((releaseGroup.PrimaryType == "Album") && (!releaseGroup.SecondaryTypes.Contains("Compilation")))                    // Only process the release if it is an Album and not a Compilation. API hangs after too many calls anyway
            {

                await Task.Delay(1000);      // Give some time to the API to 'breathe'


                recordingsUrl.Append(Constants.GetRecordingsFront);     // ---------------------------- //
                recordingsUrl.Append(releaseGroup.id);                  //       Constructing URL       //
                recordingsUrl.Append(Constants.GetRecordingsBack);      // ---------------------------- //

                request = new HttpRequestMessage(HttpMethod.Get, recordingsUrl.ToString());
                request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                using (var response = await clientSecure.SendAsync(request))
                {
                    try
                    {
                        releaseGroupCounter++;
                        response.EnsureSuccessStatusCode();
                    }
                    catch (HttpRequestException ex)
                    {
                        throw ex;
                    }

                    var stream = await response.Content.ReadAsStreamAsync();

                    using (var streamReader = new System.IO.StreamReader(stream))
                    {
                        using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                        {
                            jsonSerializer = new Newtonsoft.Json.JsonSerializer();
                            releaseRecordings = jsonSerializer.Deserialize<RecordingModel>(jsonTextReader);

                            allRecordings.Add(releaseRecordings);

                        }
                    }

                }
                recordingsUrl.Clear();
            }
        }
        releaseGroupCounter = 0;
        Console.WriteLine(allRecordings.Count);

        // 2. Get list of unique song titles from these recordings

        List<string> songList = new List<string>();

        foreach (var recording in allRecordings)
        {
            foreach (var song in recording.Recordings)
            {
                if (song.Title != "")
                {
                    songList.Add(song.Title);
                }
            }
        }

        uniqueSongs = songList.Distinct().ToList();

        // 3. Call lyrics API for each of these titles
        // URL is like https://api.lyrics.ovh/v1/Abba/angel%20eyes

        StringBuilder lyricsUrl = new StringBuilder();
        int songCounter = 0;
        int wordCount = 0;
        int songWithLyricsCounter = 0;

        var rnd = new Random();
        var shuffledSongs = uniqueSongs.OrderBy(item => rnd.Next());            // Shuffling list of songs to get different ones each time, since we will often be dropped by the API before getting to all of them

        foreach (string song in shuffledSongs)
        {
            lyricsUrl.Append(Helpers.Slugify(artistName));
            lyricsUrl.Append("/");
            lyricsUrl.Append(Helpers.Slugify(song));

            request = new HttpRequestMessage(HttpMethod.Get, lyricsUrl.ToString());
            request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            using (var response = await clientForLyrics.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    songCounter++;
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        using (var streamReader = new System.IO.StreamReader(stream))
                        {
                            using (var jsonTextReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                            {
                                jsonSerializer = new Newtonsoft.Json.JsonSerializer();
                                songLyrics = jsonSerializer.Deserialize<LyricsModel>(jsonTextReader);

                                // Parse songLyrics
                                if (songLyrics.lyrics != "")
                                {
                                    wordCount += Helpers.GetWordCount(songLyrics.lyrics);
                                    songWithLyricsCounter++;
                                }

                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine(wordCount);
                }
            }
            lyricsUrl.Clear();
        }
        if (songWithLyricsCounter != 0)
        {
            average = wordCount / songWithLyricsCounter;
        }
        GoToResultsPage(artistName, average);
    }

    private void GoToResultsPage(string artistName, decimal avg)
    {
        _navigationManager.NavigateTo("results/" + artistName + "/" + avg);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
