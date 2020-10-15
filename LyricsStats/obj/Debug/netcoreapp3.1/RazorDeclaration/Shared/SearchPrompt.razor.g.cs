#pragma checksum "D:\MyCode\LyricsStatsApp\LyricsStats\Shared\SearchPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c7ac9d34b543704d2e4e2c234e45261786fe352"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LyricsStats.Shared
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
    public partial class SearchPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "D:\MyCode\LyricsStatsApp\LyricsStats\Shared\SearchPrompt.razor"
       
    [Parameter]
    public string Title { get; set; }

    private SearchModel searchModel = new SearchModel();

    string name;

    private void HandleValidSubmit()
    {
        name = searchModel.ArtistName;
        GoToArtistsPage(name);
    }

    private void GoToArtistsPage(string artistName)
    {
        _navigationManager.NavigateTo("lyrics/" + artistName);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
