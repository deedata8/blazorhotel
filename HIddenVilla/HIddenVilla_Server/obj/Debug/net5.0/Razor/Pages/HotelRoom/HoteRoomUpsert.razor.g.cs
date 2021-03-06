#pragma checksum "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c94bddbc315239e4ba9bef959a9ad74d0c2df03"
// <auto-generated/>
#pragma warning disable 1591
namespace HIddenVilla_Server.Pages.HotelRoom
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
#line 11 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using HIddenVilla_Server.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\_Imports.razor"
using HIddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
using HIddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/edit/{Id:int}")]
    public partial class HoteRoomUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(4, 
#nullable restore
#line 11 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " Hotel Room");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                 HotelRoomModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                                HandleHotelRoomUpsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                HotelRoomModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Name = __value, HotelRoomModel.Name))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __Blazor.HIddenVilla_Server.Pages.HotelRoom.HoteRoomUpsert.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 21 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                ()=>HotelRoomModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label>Occupancy</label>\r\n                        ");
                __Blazor.HIddenVilla_Server.Pages.HotelRoom.HoteRoomUpsert.TypeInference.CreateInputNumber_1(__builder2, 36, 37, "form-control", 38, 
#nullable restore
#line 25 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                  HotelRoomModel.Occupancy

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Occupancy = __value, HotelRoomModel.Occupancy)), 40, () => HotelRoomModel.Occupancy);
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __Blazor.HIddenVilla_Server.Pages.HotelRoom.HoteRoomUpsert.TypeInference.CreateValidationMessage_2(__builder2, 42, 43, 
#nullable restore
#line 26 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                ()=>HotelRoomModel.Occupancy

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<label>Rate</label>\r\n                        ");
                __Blazor.HIddenVilla_Server.Pages.HotelRoom.HoteRoomUpsert.TypeInference.CreateInputNumber_3(__builder2, 48, 49, "form-control", 50, 
#nullable restore
#line 30 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                  HotelRoomModel.RegularRate

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.RegularRate = __value, HotelRoomModel.RegularRate)), 52, () => HotelRoomModel.RegularRate);
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __Blazor.HIddenVilla_Server.Pages.HotelRoom.HoteRoomUpsert.TypeInference.CreateValidationMessage_4(__builder2, 54, 55, 
#nullable restore
#line 31 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                ()=>HotelRoomModel.RegularRate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "<label>Sq ft.</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                HotelRoomModel.SqFt

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.SqFt = __value, HotelRoomModel.SqFt))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.SqFt));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n                        ");
                __Blazor.HIddenVilla_Server.Pages.HotelRoom.HoteRoomUpsert.TypeInference.CreateValidationMessage_5(__builder2, 66, 67, 
#nullable restore
#line 36 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                ()=>HotelRoomModel.SqFt

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.AddMarkupContent(71, "<label>Details</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(72);
                __builder2.AddAttribute(73, "class", "form-control");
                __builder2.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                    HotelRoomModel.Details

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Details = __value, HotelRoomModel.Details))));
                __builder2.AddAttribute(76, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.Details));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n                        ");
                __Blazor.HIddenVilla_Server.Pages.HotelRoom.HoteRoomUpsert.TypeInference.CreateValidationMessage_6(__builder2, 78, 79, 
#nullable restore
#line 41 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                ()=>HotelRoomModel.Details

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.OpenElement(83, "button");
                __builder2.AddAttribute(84, "class", "btn btn-primary");
                __builder2.AddContent(85, 
#nullable restore
#line 44 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
                                                         Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(86, " Room");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(88);
                __builder2.AddAttribute(89, "href", "hotel-room");
                __builder2.AddAttribute(90, "class", "btn btn-secondary");
                __builder2.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(92, "Back to Index");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\deidr\source\repos\blazor\HIddenVilla\HIddenVilla_Server\Pages\HotelRoom\HoteRoomUpsert.razor"
       

    [Parameter]
    public int? Id { get; set; }

    private HotelRoomDTO HotelRoomModel { get; set; } = new HotelRoomDTO();
    private string Title { get; set; } = "Create";

    protected override async Task OnInitializedAsync()
    {
        if (Id != null)
        {
            Title = "Update";
            HotelRoomModel = await HotelRoomRepository.GetHotelRoom(Id.Value);
        }
        else
        {
            //create
            HotelRoomModel = new HotelRoomDTO();
        }
    }

    private async Task HandleHotelRoomUpsert()
    {
        try
        {
            var roomDetailsByName = await HotelRoomRepository.IsRoomUnique(HotelRoomModel.Name, HotelRoomModel.Id);
            if (roomDetailsByName != null)
            {
                await JsRuntime.ToastrError("Room Name already exists.");
                return;
            }
            if (HotelRoomModel.Id != 0 && Title == "Update")
            {
                var updateRoomResult = await HotelRoomRepository.UpdateHotelRoom(HotelRoomModel.Id, HotelRoomModel);
                await JsRuntime.ToastrSuccess("Hotel room updated successfully.");
            }
            else
            {
                var createdResult = await HotelRoomRepository.CreateHotelRoom(HotelRoomModel);
                await JsRuntime.ToastrSuccess("Hotel room created successfully.");
            }
        }
        catch (Exception ex)
        {
            //log exceptions
        }

        NavigationManager.NavigateTo("hotel-room");

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
namespace __Blazor.HIddenVilla_Server.Pages.HotelRoom.HoteRoomUpsert
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
