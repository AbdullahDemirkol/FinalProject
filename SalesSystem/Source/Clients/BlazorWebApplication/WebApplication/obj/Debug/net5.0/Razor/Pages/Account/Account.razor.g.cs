#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32803572d5ccdce9765deca08938672bdf1ba45f"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages.Account
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account")]
    public partial class Account : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""breadcrumb-section breadcrumb-bg"" b-gi7leq8zwh><div class=""container"" b-gi7leq8zwh><div class=""row"" b-gi7leq8zwh><div class=""col-lg-8 offset-lg-2 text-center"" b-gi7leq8zwh><div class=""breadcrumb-text"" b-gi7leq8zwh><p b-gi7leq8zwh>We sale fresh fruits</p>
                    <h1 b-gi7leq8zwh>Hesabım</h1></div></div></div></div></div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "forAccountBackground");
            __builder.AddAttribute(3, "b-gi7leq8zwh");
            __builder.AddMarkupContent(4, "<div class=\"forAccountBackgroundPadding\" b-gi7leq8zwh></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container emp-profile");
            __builder.AddAttribute(7, "b-gi7leq8zwh");
            __builder.OpenElement(8, "form");
            __builder.AddAttribute(9, "method", "post");
            __builder.AddAttribute(10, "b-gi7leq8zwh");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddAttribute(13, "b-gi7leq8zwh");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-8");
            __builder.AddAttribute(16, "b-gi7leq8zwh");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "profile-head");
            __builder.AddAttribute(19, "b-gi7leq8zwh");
            __builder.OpenElement(20, "h5");
            __builder.AddAttribute(21, "b-gi7leq8zwh");
            __builder.AddContent(22, 
#nullable restore
#line 29 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                             _userModel.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "h6");
            __builder.AddAttribute(25, "b-gi7leq8zwh");
            __builder.AddContent(26, 
#nullable restore
#line 32 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                             _userModel.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " ");
            __builder.AddContent(28, 
#nullable restore
#line 32 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                                   _userModel.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n\r\n                        ");
            __builder.AddMarkupContent(30, "<div class=\"nav nav-tabs\" b-gi7leq8zwh><a class=\"nav-link active\" b-gi7leq8zwh>Hakkında</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.AddMarkupContent(32, @"<div class=""col-md-4"" b-gi7leq8zwh><div class=""profile-img"" b-gi7leq8zwh><img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS52y5aInsxSm31CvHOFHWujqUx_wWTS9iM6s7BAm21oEN_RiGoog"" alt b-gi7leq8zwh>
                        <div class=""file btn btn-lg btn-primary"" b-gi7leq8zwh>
                            Change Photo
                            <input type=""file"" name=""file"" b-gi7leq8zwh></div></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row");
            __builder.AddAttribute(36, "b-gi7leq8zwh");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-md-10");
            __builder.AddAttribute(39, "b-gi7leq8zwh");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "tab-content profile-tab");
            __builder.AddAttribute(42, "id", "myTabContent");
            __builder.AddAttribute(43, "b-gi7leq8zwh");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "tab-pane fade show active");
            __builder.AddAttribute(46, "id", "home");
            __builder.AddAttribute(47, "role", "tabpanel");
            __builder.AddAttribute(48, "aria-labelledby", "home-tab");
            __builder.AddAttribute(49, "b-gi7leq8zwh");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "row");
            __builder.AddAttribute(52, "b-gi7leq8zwh");
            __builder.AddMarkupContent(53, "<div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>İsim</label></div>\r\n                                ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-md-6");
            __builder.AddAttribute(56, "b-gi7leq8zwh");
            __builder.OpenElement(57, "p");
            __builder.AddAttribute(58, "b-gi7leq8zwh");
            __builder.AddContent(59, 
#nullable restore
#line 87 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                        _userModel.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.AddAttribute(63, "b-gi7leq8zwh");
            __builder.AddMarkupContent(64, "<div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Soyisim</label></div>\r\n                                ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-md-6");
            __builder.AddAttribute(67, "b-gi7leq8zwh");
            __builder.OpenElement(68, "p");
            __builder.AddAttribute(69, "b-gi7leq8zwh");
            __builder.AddContent(70, 
#nullable restore
#line 95 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                        _userModel.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "row");
            __builder.AddAttribute(74, "b-gi7leq8zwh");
            __builder.AddMarkupContent(75, "<div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Email</label></div>\r\n                                ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col-md-6");
            __builder.AddAttribute(78, "b-gi7leq8zwh");
            __builder.OpenElement(79, "p");
            __builder.AddAttribute(80, "b-gi7leq8zwh");
            __builder.AddContent(81, 
#nullable restore
#line 103 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                        _userModel.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                            ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "row");
            __builder.AddAttribute(85, "b-gi7leq8zwh");
            __builder.AddMarkupContent(86, "<div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Telefon</label></div>\r\n                                ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "col-md-6");
            __builder.AddAttribute(89, "b-gi7leq8zwh");
            __builder.OpenElement(90, "p");
            __builder.AddAttribute(91, "b-gi7leq8zwh");
            __builder.AddContent(92, 
#nullable restore
#line 111 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                        _userModel.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                            ");
            __builder.AddMarkupContent(94, "<div class=\"row\" b-gi7leq8zwh><div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Ödeme Yöntemi Adeti</label></div>\r\n                                <div class=\"col-md-6\" b-gi7leq8zwh><p b-gi7leq8zwh>5</p></div></div>\r\n\r\n                            ");
            __builder.AddMarkupContent(95, "<div class=\"row\" b-gi7leq8zwh><div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Adres Adeti</label></div>\r\n                                <div class=\"col-md-6\" b-gi7leq8zwh><p b-gi7leq8zwh>5</p></div></div>\r\n\r\n                            ");
            __builder.AddMarkupContent(96, "<div class=\"row\" b-gi7leq8zwh><div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Sipariş Yöntemi Adeti</label></div>\r\n                                <div class=\"col-md-6\" b-gi7leq8zwh><p b-gi7leq8zwh>5</p></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                        ");
            __builder.AddMarkupContent(98, "<div class=\"tab-pane fade\" id=\"profile\" role=\"tabpanel\" aria-labelledby=\"profile-tab\" b-gi7leq8zwh><div class=\"row\" b-gi7leq8zwh><div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Experience</label></div>\r\n                                <div class=\"col-md-6\" b-gi7leq8zwh><p b-gi7leq8zwh>Expert</p></div></div>\r\n                            <div class=\"row\" b-gi7leq8zwh><div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Hourly Rate</label></div>\r\n                                <div class=\"col-md-6\" b-gi7leq8zwh><p b-gi7leq8zwh>10$/hr</p></div></div>\r\n                            <div class=\"row\" b-gi7leq8zwh><div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Total Projects</label></div>\r\n                                <div class=\"col-md-6\" b-gi7leq8zwh><p b-gi7leq8zwh>230</p></div></div>\r\n                            <div class=\"row\" b-gi7leq8zwh><div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>English Level</label></div>\r\n                                <div class=\"col-md-6\" b-gi7leq8zwh><p b-gi7leq8zwh>Expert</p></div></div>\r\n                            <div class=\"row\" b-gi7leq8zwh><div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Availability</label></div>\r\n                                <div class=\"col-md-6\" b-gi7leq8zwh><p b-gi7leq8zwh>6 months</p></div></div>\r\n                            <div class=\"row\" b-gi7leq8zwh><div class=\"col-md-12\" b-gi7leq8zwh><label b-gi7leq8zwh>Your Bio</label><br b-gi7leq8zwh>\r\n                                    <p b-gi7leq8zwh>Your detail description</p></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    <div class=\"forAccountBackgroundPadding\" b-gi7leq8zwh></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 197 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
       
    private bool isLoggedIn = false;

    [Inject]
    public IJSRuntime jsRuntime { get; set; }
    [Inject]
    IIdentityService identityService { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }

    UserDTO _userModel { get; set; }


    protected override void OnInitialized()
    {
        isLoggedIn = identityService.IsLoggedIn;
        if (!isLoggedIn)
        {
            navigationManager.NavigateTo($"login?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}", true);
        }
        GetUser();
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("myFunction");
        }
    }
    private void GetUser()
    {
        _userModel = identityService.GetUserModel(identityService.GetUserToken());
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591