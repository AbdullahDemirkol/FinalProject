#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d33303df0572350300ca7d598ec19e80d8c4cff"
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
#line 1 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/About")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""breadcrumb-section breadcrumb-bg""><div class=""container""><div class=""row""><div class=""col-lg-8 offset-lg-2 text-center""><div class=""breadcrumb-text""><p>We sale fresh fruits</p>
                    <h1>Hakkımızda</h1></div></div></div></div></div>


");
            __builder.AddMarkupContent(1, "<div class=\"feature-bg\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-8\"><div class=\"featured-text\"><h2 class=\"pb-3\">Why <span class=\"orange-text\">Fruitkha</span></h2>\r\n                    <div class=\"row\"><div class=\"col-lg-6 col-md-6 mb-4 mb-md-5\"><div class=\"list-box d-flex\"><div class=\"list-icon\"><i class=\"fas fa-shipping-fast\"></i></div>\r\n                                <div class=\"content\"><h3>Home Delivery</h3>\r\n                                    <p>sit voluptatem accusantium dolore mque laudantium, totam rem aperiam, eaque ipsa quae ab illo.</p></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6 mb-5 mb-md-5\"><div class=\"list-box d-flex\"><div class=\"list-icon\"><i class=\"fas fa-money-bill-alt\"></i></div>\r\n                                <div class=\"content\"><h3>Best Price</h3>\r\n                                    <p>sit voluptatem accusantium dolore mque laudantium, totam rem aperiam, eaque ipsa quae ab illo.</p></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6 mb-5 mb-md-5\"><div class=\"list-box d-flex\"><div class=\"list-icon\"><i class=\"fas fa-briefcase\"></i></div>\r\n                                <div class=\"content\"><h3>Custom Box</h3>\r\n                                    <p>sit voluptatem accusantium dolore mque laudantium, totam rem aperiam, eaque ipsa quae ab illo.</p></div></div></div>\r\n                        <div class=\"col-lg-6 col-md-6\"><div class=\"list-box d-flex\"><div class=\"list-icon\"><i class=\"fas fa-sync-alt\"></i></div>\r\n                                <div class=\"content\"><h3>Quick Refund</h3>\r\n                                    <p>sit voluptatem accusantium dolore mque laudantium, totam rem aperiam, eaque ipsa quae ab illo.</p></div></div></div></div></div></div>\r\n            <div class=\"col-lg-4\"><div class=\"contact-form-wrap\"><div class=\"contact-form-box\"><h4><i class=\"fas fa-map\"></i> Shop Address</h4>\r\n                        <p>34/8, East Hukupara <br> Gifirtok, Sadan. <br> Country Name</p></div>\r\n                    <div class=\"contact-form-box\"><h4><i class=\"far fa-clock\"></i> Shop Hours</h4>\r\n                        <div class=\"row\"><p>PAZARTESİ - CUMA: Sabah 9\'dan Akşam 9\'a</p></div>\r\n                        <div class=\"row\"><p>CUMARTESİ - PAZAR: Sabah 10\'dan Akşam 9\'a kadar açığız.</p></div></div>\r\n                    <div class=\"contact-form-box\"><h4><i class=\"fas fa-address-book\"></i> Contact</h4>\r\n                        <p>Phone: +00 111 222 3333 <br> Email: support@fruitkha.com</p></div></div></div></div></div></div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"find-location blue-bg\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-12 text-center\"><p><i class=\"fas fa-map-marker-alt\"></i> Lokasyonumuz</p></div></div></div></div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(3, @"<div class=""embed-responsive embed-responsive-21by9""><iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d26432.42324808999!2d-118.34398767954286!3d34.09378509738966!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x80c2bf07045279bf%3A0xf67a9a6797bdfae4!2sHollywood%2C%20Los%20Angeles%2C%20CA%2C%20USA!5e0!3m2!1sen!2sbd!4v1576846473265!5m2!1sen!2sbd"" width=""600"" height=""450"" frameborder=""0"" style=""border:0;"" allowfullscreen class=""embed-responsive-item""></iframe></div>


");
            __builder.AddMarkupContent(4, "<div class=\"mt-150\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-8 offset-lg-2 text-center\"><div class=\"section-title\"><h3>Our <span class=\"orange-text\">Team</span></h3>\r\n                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Aliquid, fuga quas itaque eveniet beatae optio.</p></div></div></div>\r\n        <div class=\"row\"><div class=\"col-lg-4 col-md-6\"><div class=\"single-team-item\"><div class=\"team-bg team-bg-1\"></div>\r\n                    <h4>Jimmy Doe <span>Farmer</span></h4>\r\n                    <ul class=\"social-link-team\"><li><a href=\"#\" target=\"_blank\"><i class=\"fab fa-facebook-f\"></i></a></li>\r\n                        <li><a href=\"#\" target=\"_blank\"><i class=\"fab fa-twitter\"></i></a></li>\r\n                        <li><a href=\"#\" target=\"_blank\"><i class=\"fab fa-instagram\"></i></a></li></ul></div></div>\r\n            <div class=\"col-lg-4 col-md-6\"><div class=\"single-team-item\"><div class=\"team-bg team-bg-2\"></div>\r\n                    <h4>Marry Doe <span>Farmer</span></h4>\r\n                    <ul class=\"social-link-team\"><li><a href=\"#\" target=\"_blank\"><i class=\"fab fa-facebook-f\"></i></a></li>\r\n                        <li><a href=\"#\" target=\"_blank\"><i class=\"fab fa-twitter\"></i></a></li>\r\n                        <li><a href=\"#\" target=\"_blank\"><i class=\"fab fa-instagram\"></i></a></li></ul></div></div>\r\n            <div class=\"col-lg-4 col-md-6 offset-md-3 offset-lg-0\"><div class=\"single-team-item\"><div class=\"team-bg team-bg-3\"></div>\r\n                    <h4>Simon Joe <span>Farmer</span></h4>\r\n                    <ul class=\"social-link-team\"><li><a href=\"#\" target=\"_blank\"><i class=\"fab fa-facebook-f\"></i></a></li>\r\n                        <li><a href=\"#\" target=\"_blank\"><i class=\"fab fa-twitter\"></i></a></li>\r\n                        <li><a href=\"#\" target=\"_blank\"><i class=\"fab fa-instagram\"></i></a></li></ul></div></div></div></div></div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(5, "<div class=\"testimonail-section mt-80 mb-150\"><div class=\"container\"><div class=\"row\"><div class=\"col-lg-10 offset-lg-1 text-center\"><div class=\"testimonial-sliders\"><div class=\"single-testimonial-slider\"><div class=\"client-avater\"><img src=\"assets/img/avaters/avatar2.png\" alt></div>\r\n                        <div class=\"client-meta\"><h3>David Niph <span>Local shop owner</span></h3>\r\n                            <p class=\"testimonial-body\">\r\n                                \" Sed ut perspiciatis unde omnis iste natus error veritatis et  quasi architecto beatae vitae dict eaque ipsa quae ab illo inventore Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium \"\r\n                            </p>\r\n                            <div class=\"last-icon\"><i class=\"fas fa-quote-right\"></i></div></div></div>\r\n                    <div class=\"single-testimonial-slider\"><div class=\"client-avater\"><img src=\"assets/img/avaters/avatar3.png\" alt></div>\r\n                        <div class=\"client-meta\"><h3>Jacob Sikim <span>Local shop owner</span></h3>\r\n                            <p class=\"testimonial-body\">\r\n                                \" Sed ut perspiciatis unde omnis iste natus error veritatis et  quasi architecto beatae vitae dict eaque ipsa quae ab illo inventore Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium \"\r\n                            </p>\r\n                            <div class=\"last-icon\"><i class=\"fas fa-quote-right\"></i></div></div></div></div></div></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 236 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\About.razor"
       

    [Inject]
    public IJSRuntime jsRuntime { get; set; }

    bool reloadPage { get; set; } = true;

    protected override void OnInitialized()
    {
        //reloadPage = true;
        //var jsInProcess = (IJSInProcessRuntime)JSRuntime;
        //myScript = jsInProcess.Invoke<IJSObjectReference>("import", navigationManager.BaseUri + "assets/js/main.js");
        //stateManager.UpdateBody(this, 0, 0, 0, 0);
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("myFunction");
            //myScript = await JSRuntime.InvokeAsync<IJSObjectReference>("import","assets/js/main.js");
        }
    }
    //private async Task StateManager_StateChanged(ComponentBase component, string property)
    //{
    //    if (reloadPage)
    //    {
    //        reloadPage = false;
    //        await InvokeAsync(StateHasChanged);
    //    }
    //    else
    //    {
    //        return;
    //    }
    //}

    [Inject]
    StateManager stateManager { get; set; }

    [Inject]
    NavigationManager navigationManager { get; set; }

    //protected override void OnAfterRender(bool firstRender)
    //{
    //    if (firstRender)
    //    {
    //        stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
    //    }
    //}

    //private async Task StateManager_StateChanged(ComponentBase component, string property)
    //{
    //    await InvokeAsync(StateHasChanged);
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591