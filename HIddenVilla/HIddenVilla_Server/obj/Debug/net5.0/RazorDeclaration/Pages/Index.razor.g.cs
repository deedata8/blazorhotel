// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HIddenVilla_Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using HIddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using HIddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\Index.razor"
using Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\Index.razor"
      

    string SelectedRoomProp = "";
    List<BlazorRoom> RoomsList = new List<BlazorRoom>();

    BlazorRoom Room = new BlazorRoom()
    {
        Id = 1,
        RoomName = "Village Suite",
        IsActive = true,
        Price = 499,
        RoomProps = new List<BlazorRoomProp>
{
            new BlazorRoomProp(){ Id=1, Name="Sq ft", Value="100" },
            new BlazorRoomProp(){ Id=2, Name="Occupancy", Value="4" }

        }
    };

    protected override void OnInitialized()
    {
        base.OnInitialized();
        RoomsList.Add(Room);
        RoomsList.Add(
            new BlazorRoom()
            {
                Id = 2,
                RoomName = "Executive Suite",
                IsActive = true,
                Price = 899,
                RoomProps = new List<BlazorRoomProp>
                {
                    new BlazorRoomProp(){ Id=1, Name="Sq ft", Value="200" },
                    new BlazorRoomProp(){ Id=2, Name="Occupancy", Value="6" }
                }
            });

    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591