#pragma checksum "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\Results.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f999d80b03882714972a1bfda63332b026219d5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/results/{artistName}/{average}")]
    public partial class Results : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "D:\MyCode\LyricsStatsApp\LyricsStats\Pages\Results.razor"
       

    [Parameter]
    public string ArtistName { get; set; }

    [Parameter]
    public string Average { get; set; }

    bool isTaskRunning = false;                             // This is for disabling the button after it has been clicked once to add the artist
    string buttonName = "Store artist for comparison";                                                                                                                                                                                                                                        
  

    protected override void OnInitialized()
    {
        StateContainer.OnChange += StateHasChanged;
    }

    private void ChangePropertyValue()
    {
        StateContainer.SetProperty(ArtistName, Average);

        isTaskRunning = true;                                                                                                                   //
        buttonName = "Please navigate to Home page, to enter another arist name";
    }

    public void Dispose()
    {
        StateContainer.OnChange -= StateHasChanged;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LyricsStats.Domain.StateContainer StateContainer { get; set; }
    }
}
#pragma warning restore 1591