#pragma checksum "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a9fdfed5695c8fe341ddae0b98977a9f336b0b1"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplicationAdminPanel.Pages.Login
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class LoginPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "login");
            __builder.AddAttribute(2, "b-5fr3qckfb9");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "login_box");
            __builder.AddAttribute(5, "b-5fr3qckfb9");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "left");
            __builder.AddAttribute(8, "b-5fr3qckfb9");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "contact");
            __builder.AddAttribute(11, "b-5fr3qckfb9");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
                                  loginRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
                                                               loginProcess

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(16, "<h3 b-5fr3qckfb9>GIRIS YAP</h3>\r\n                    ");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "type", "text");
                __builder2.AddAttribute(19, "placeholder", "KULLANICI ADI");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
                                        loginRequest.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginRequest.UserName = __value, loginRequest.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(22, "b-5fr3qckfb9");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "placeholder", "SIFRE");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
                                        loginRequest.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginRequest.Password = __value, loginRequest.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(29, "b-5fr3qckfb9");
                __builder2.CloseElement();
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
                     if (showNotification)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(30, "<button class=\"submit\" disabled b-5fr3qckfb9>Giriş Yap</button>");
#nullable restore
#line 12 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(31, "<button class=\"submit\" b-5fr3qckfb9>Giriş Yap</button>");
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
                    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.AddMarkupContent(33, "<div class=\"right\" b-5fr3qckfb9><div class=\"right-text\" b-5fr3qckfb9><h2 b-5fr3qckfb9>ADMIN PANELE HOŞGELDİNİZ!</h2>\r\n                <h5 b-5fr3qckfb9>ADMIN GIRISI</h5></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
 if (showNotification)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "notification-container");
            __builder.AddAttribute(36, "b-5fr3qckfb9");
            __builder.OpenComponent<WebApplicationAdminPanel.Pages.Modal.Notification>(37);
            __builder.AddAttribute(38, "IsSuccess", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
                                  isSuccess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
                                                       message

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Login\LoginPage.razor"
       
    [Inject]
    private IIdentityService _identityService { get; set; }
    private LoginRequest loginRequest = new LoginRequest("", "");
    [Inject]
    StateManager stateManager { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }

    bool isSuccess { get; set; }
    string message { get; set; }
    bool showNotification { get; set; } = false;

    private async Task loginProcess()
    {
        var result = await _identityService.Login(loginRequest.UserName, loginRequest.Password);
        if (result)
        {
            LoginNotification(result, "Giriş Başarılı. Lütfen Bekleyiniz.");
            await Task.Delay(2000);
            //var collection = HttpUtility.ParseQueryString(new Uri(navigationManager.Uri).Query);
            //string retunUrl = collection.Get("returnUrl") ?? "/";
            navigationManager.NavigateTo("/");
        }
        else
        {
            LoginNotification(result, "Giriş Başarısız.");
        }
    }
    private async void LoginNotification(bool success,string message)
    {
        isSuccess = success ;
        this.message = message;
        showNotification = true;
        await InvokeAsync(StateHasChanged);
        //stateManager.UpdateContent(this, "LoginPage");

        await Task.Delay(2000).ContinueWith(t =>
        {
            isSuccess = false;
            message = "";
            showNotification = false;
            InvokeAsync(StateHasChanged);
            //stateManager.UpdateContent(this, "LoginPage");
        });
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
