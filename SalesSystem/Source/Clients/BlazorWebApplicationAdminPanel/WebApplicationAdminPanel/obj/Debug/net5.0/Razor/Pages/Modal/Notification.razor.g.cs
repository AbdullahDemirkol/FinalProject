#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\Notification.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e027e559abd4473fc6ba9906ac1212b5a07852f"
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
#line 1 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class Notification : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "notification" + " " + (
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\Notification.razor"
                           IsSuccess ? "success" : "error"

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(2, "span");
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\Notification.razor"
           Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\Notification.razor"
       
    [Parameter]
    public string Message { get; set; }
    [Parameter]
    public bool IsSuccess { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
