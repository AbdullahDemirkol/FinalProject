#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91ccc2721fdf012b57c19330c3fb4444b77b96f3"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/About")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""breadcrumb-section breadcrumb-bg""><div class=""container""><div class=""row""><div class=""col-lg-8 offset-lg-2 text-center""><div class=""breadcrumb-text""><p>E-Ticaret Websitesi</p>
                    <h1>Hakkımızda</h1></div></div></div></div></div>


");
            __builder.AddMarkupContent(1, "<div class=\"feature-bg\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-8\"><div class=\"featured-text\"><h2 class=\"pb-3\">Neden Bizi <span class=\"orange-text\">Seçmelisiniz!</span></h2>\r\n                    <div class=\"row\"><div class=\"col-lg-6 col-md-6 mb-4 mb-md-5\"><div class=\"list-box d-flex\"><div class=\"list-icon\"><i class=\"fas fa-shipping-fast\"></i></div>\r\n                                <div class=\"content\"><h3>Hızlı Teslimat</h3></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6 mb-5 mb-md-5\"><div class=\"list-box d-flex\"><div class=\"list-icon\"><i class=\"fas fa-money-bill-alt\"></i></div>\r\n                                <div class=\"content\"><h3>Uygun Fiyat</h3></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6 mb-5 mb-md-5\"><div class=\"list-box d-flex\"><div class=\"list-icon\"><i class=\"fas fa-shield-alt\"></i></div>\r\n                                <div class=\"content\"><h3>Güvenilirlik</h3></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6\"><div class=\"list-box d-flex\"><div class=\"list-icon\"><i class=\"fas fa-sync-alt\"></i></div>\r\n                                <div class=\"content\"><h3>Hızlı İade</h3></div></div></div></div></div></div>\r\n            <div class=\"col-lg-4\"><div class=\"contact-form-wrap\"><div class=\"contact-form-box\"><h4><i class=\"fas fa-map\"></i> Mağaza Adresi</h4>\r\n                        <div class=\"row\"><p> Beşiktaş, İstanbul. </p></div></div>\r\n                    <div class=\"contact-form-box\"><h4><i class=\"far fa-clock\"></i> Mağaza Saatleri</h4>\r\n                        <div class=\"row\"><p>HAFTA İÇİ: 9:00-21:00</p></div>\r\n                        <div class=\"row\"><p>HAFTA SONU: 10:00-22:00</p></div></div>\r\n                    <div class=\"contact-form-box\"><h4><i class=\"fas fa-address-book\"></i> İletişim</h4>\r\n                        <div class=\"row\"><p>Telefon: 0216 999 99 99</p></div>\r\n                        <div class=\"row\"><p>Email: support@e-ticaret.com</p></div></div></div></div></div></div></div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"find-location blue-bg\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-12 text-center\"><p><i class=\"fas fa-map-marker-alt\"></i> Lokasyonumuz</p></div></div></div></div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(3, @"<div class=""embed-responsive embed-responsive-21by9""><iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d48134.46391619232!2d28.98602515038854!3d41.060161036480594!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cab63f6f8193f1%3A0x36c864a929a1018c!2zQmXFn2lrdGHFny_EsHN0YW5idWw!5e0!3m2!1str!2str!4v1682355170115!5m2!1str!2str"" width=""600"" height=""450"" frameborder=""0"" style=""border:0;"" allowfullscreen class=""embed-responsive-item""></iframe></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\About.razor"
       

    [Inject]
    StateManager stateManager { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }
    [Inject]
    public IJSRuntime jsRuntime { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("myFunction");
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
