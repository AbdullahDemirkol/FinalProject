#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "561647b412df158cb3121a6236c1770448e1ad51"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-header-area");
            __builder.AddAttribute(2, "id", "sticker");
            __builder.AddAttribute(3, "b-o3ur5ervqs");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddAttribute(6, "b-o3ur5ervqs");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddAttribute(9, "b-o3ur5ervqs");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-lg-12 col-sm-12 text-center");
            __builder.AddAttribute(12, "b-o3ur5ervqs");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "main-menu-wrap");
            __builder.AddAttribute(15, "b-o3ur5ervqs");
            __builder.AddMarkupContent(16, "<div class=\"site-logo\" b-o3ur5ervqs><a href=\"/\" b-o3ur5ervqs><img src=\"assets/img/logo.png\" alt b-o3ur5ervqs></a></div>\r\n                    \r\n                    \r\n                    ");
            __builder.OpenElement(17, "nav");
            __builder.AddAttribute(18, "class", "main-menu");
            __builder.AddAttribute(19, "b-o3ur5ervqs");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "b-o3ur5ervqs");
            __builder.AddMarkupContent(22, "<li class=\"current-list-item\" b-o3ur5ervqs><a href=\"/Index\" b-o3ur5ervqs>Anasayfa</a></li>\r\n                            ");
            __builder.AddMarkupContent(23, "<li b-o3ur5ervqs><a href=\"/Product\" b-o3ur5ervqs>Tüm Ürünler</a></li>");
#nullable restore
#line 29 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                             if (!isLoggedIn)
                            {
                                GetUser();

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "b-o3ur5ervqs");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/login");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                                                               GoLoginPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "b-o3ur5ervqs");
            __builder.AddMarkupContent(30, "Giriş Yap");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                                 if (_userDto.Role == "admin")
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<li b-o3ur5ervqs><a href=\"https://localhost:44350/\" b-o3ur5ervqs>Admin Panel</a></li>");
#nullable restore
#line 43 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "b-o3ur5ervqs");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "b-o3ur5ervqs");
            __builder.AddContent(36, 
#nullable restore
#line 45 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                                        _userDto.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, " ");
            __builder.AddContent(38, 
#nullable restore
#line 45 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                                                            _userDto.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                    ");
            __builder.OpenElement(40, "ul");
            __builder.AddAttribute(41, "class", "sub-menu");
            __builder.AddAttribute(42, "b-o3ur5ervqs");
            __builder.AddMarkupContent(43, "<li b-o3ur5ervqs><a href=\"/Account\" b-o3ur5ervqs>Hesabım</a></li>\r\n                                        ");
            __builder.AddMarkupContent(44, "<li b-o3ur5ervqs><a href=\"/Orders\" b-o3ur5ervqs>Siparişlerim</a></li>\r\n                                        ");
            __builder.AddMarkupContent(45, "<li b-o3ur5ervqs><a href=\"/PaymentMethods\" b-o3ur5ervqs>Ödeme Yöntemlerim</a></li>\r\n                                        ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "b-o3ur5ervqs");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "class", "ml-md-auto");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                                                                            GoLogoutPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "b-o3ur5ervqs");
            __builder.AddMarkupContent(52, "Çıkış Yap");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<li b-o3ur5ervqs><a href=\"/About\" b-o3ur5ervqs>Hakkımızda</a></li>");
#nullable restore
#line 65 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                             if (isLoggedIn)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "<li b-o3ur5ervqs><a href=\"/Contact\" b-o3ur5ervqs>İletişim</a></li>");
#nullable restore
#line 68 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "li");
            __builder.AddAttribute(56, "b-o3ur5ervqs");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "header-icons");
            __builder.AddAttribute(59, "b-o3ur5ervqs");
#nullable restore
#line 72 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                                     if (isLoggedIn)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(60, "<a class=\"shopping-cart\" href=\"/Basket\" b-o3ur5ervqs><i class=\"fas fa-shopping-cart\" b-o3ur5ervqs></i></a>");
#nullable restore
#line 75 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(61, "<a class=\"mobile-hide search-bar-icon\" href=\"#\" b-o3ur5ervqs><i class=\"fas fa-search\" b-o3ur5ervqs></i></a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.AddMarkupContent(63, "<a class=\"mobile-show search-bar-icon\" href=\"#\" b-o3ur5ervqs><i class=\"fas fa-search\" b-o3ur5ervqs></i></a>\r\n                    <div class=\"mobile-menu\" b-o3ur5ervqs></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(65, @"<div class=""search-area"" b-o3ur5ervqs><div class=""container"" b-o3ur5ervqs><div class=""row"" b-o3ur5ervqs><div class=""col-lg-12"" b-o3ur5ervqs><span class=""close-btn"" b-o3ur5ervqs><i class=""fas fa-window-close"" b-o3ur5ervqs></i></span>
                <div class=""search-bar"" b-o3ur5ervqs><div class=""search-bar-tablecell"" b-o3ur5ervqs><h3 b-o3ur5ervqs>Search For:</h3>
                        <input type=""text"" placeholder=""Keywords"" b-o3ur5ervqs>
                        <button type=""submit"" b-o3ur5ervqs>Search <i class=""fas fa-search"" b-o3ur5ervqs></i></button></div></div></div></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Shared\NavMenu.razor"
                                                     
[Inject]
NavigationManager navigationManager { get; set; }
[Inject]
IProductService productService { get; set; }
[Inject]
IIdentityService identityService { get; set; }
[Inject]
StateManager stateManager { get; set; }
private bool isLoggedIn = false;

List<UpCategory> upCategories = new List<UpCategory>();
UserDTO _userDto { get; set; }

protected async override Task OnInitializedAsync()
{
    upCategories = await productService.GetUpCategoryItems();
    isLoggedIn = identityService.IsLoggedIn;
}

protected override void OnAfterRender(bool firstRender)
{
    if (firstRender)
    {
        stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
    }
}
private void GetUser()
{
    _userDto= identityService.GetUserModel(identityService.GetUserToken());
}
private async Task StateManager_StateChanged(ComponentBase component, string property)
{
    if (component == this)
    {
        return;
    }
    if (property == "increase")
    {
        //basketItemCount++;
    }
    else if (property == "checkBasket")
    {
        //await calculateItemCount();
    }
    else if (property == "login")
    {
        isLoggedIn = identityService.IsLoggedIn;
        GetUser();
    }
    await InvokeAsync(StateHasChanged);
}


private void GoLoginPage()
{
    navigationManager.NavigateTo($"login?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}");
}
private void GoLogoutPage()
{
    navigationManager.NavigateTo($"logout?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}");
}
private void CheckBasket()
{
    stateManager.UpdateCard(this);
}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
