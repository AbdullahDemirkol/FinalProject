#pragma checksum "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\ShowMessagePopup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e32f38ada2c6161121147796b2913409f8fae483"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplicationAdminPanel.Pages.Modal
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class ShowMessagePopup : BaseModal
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-body");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\ShowMessagePopup.razor"
        Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row justify-content-center");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "d-flex");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "ml-auto p-2");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "btn btn-light");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\ShowMessagePopup.razor"
                                                     ConfirmClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, 
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\ShowMessagePopup.razor"
                                                                      OkText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\ShowMessagePopup.razor"
       
    public async override Task SetParametersAsync(ParameterView parameters)
    {
        Message = parameters.GetValueOrDefault<string>("Message") ?? "Mesaj Yok";
        OkText = "Ok";
        await base.SetParametersAsync(parameters);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
