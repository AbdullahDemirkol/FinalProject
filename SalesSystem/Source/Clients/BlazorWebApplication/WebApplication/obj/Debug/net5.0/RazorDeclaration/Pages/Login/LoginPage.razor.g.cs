// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages.Login
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class LoginPage : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Login\LoginPage.razor"
       

    [CascadingParameter]
    IModalService Modal { get; set; }
    [Inject]
    StateManager stateManager { get; set; }
    [Inject]
    IIdentityService identityService { get; set; }
    [Inject]
    public IJSRuntime jsRuntime { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }

    private LoginRequest loginRequest = new LoginRequest("", "");
    private UserDTO registerRequest = new UserDTO();
    bool isLoggedIn { get; set; }


    protected override void OnInitialized()
    {
        isLoggedIn = identityService.IsLoggedIn;
    }

    protected async override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("myFunction");
            await jsRuntime.InvokeVoidAsync("toggleDisplayImgClass");
        }
        //jSObjectReference = await jsRuntime.InvokeAsync<IJSObjectReference>("import", navigationManager.BaseUri + "assets/js/login.js");
        //if (firstRender)
        //{
        //    stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
        //}
    }
    //private async Task StateManager_StateChanged(ComponentBase component, string property)
    //{
    //    //jSObjectReference = await jsRuntime.InvokeAsync<IJSObjectReference>("import", navigationManager.BaseUri + "assets/js/login.js");
    //    //await InvokeAsync(StateHasChanged);
    //}
    private async Task loginProcess()
    {
        var result = await identityService.Login(loginRequest.UserName, loginRequest.Password);
        if (result)
        {
            stateManager.LoginChanged(this);
            var collection = HttpUtility.ParseQueryString(new Uri(navigationManager.Uri).Query);
            string retunUrl = collection.Get("returnUrl") ?? "/";
            navigationManager.NavigateTo(retunUrl);
        }
        else
        {
            ModalParameters modalParameters = new ModalParameters();
            modalParameters.Add("Message", "Kullanıcı Adı Yada Kullanıcı Şifresi Hatalı!");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
        }
    }
    private async Task ValidateForm()
    {
        ModalParameters modalParameters = new ModalParameters();

        if (string.IsNullOrEmpty(registerRequest.FirstName))
        {
            modalParameters.Add("Message", "İsim Alanı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (!Regex.IsMatch(registerRequest.FirstName, @"^[a-zA-Z]+$"))
        {
            modalParameters.Add("Message", "İsim Alanında Sadece Harfler Bulunmalıdır.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(registerRequest.LastName))
        {
            modalParameters.Add("Message", "Soyisim Alanı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (!Regex.IsMatch(registerRequest.LastName, @"^[a-zA-Z]+$"))
        {
            modalParameters.Add("Message", "Soyisim Alanında Sadece Harfler Bulunmalıdır.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(registerRequest.Username))
        {
            modalParameters.Add("Message", "Kullanıcı Adı Alanı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(registerRequest.Email))
        {
            modalParameters.Add("Message", "Email Adres Alanı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (!Regex.IsMatch(registerRequest.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            modalParameters.Add("Message", "Email Adres Alanı Hatalı Girildi.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(registerRequest.Phone))
        {
            modalParameters.Add("Message", "Telefon Numarası Alanı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (registerRequest.Phone.Length != 11)
        {
            modalParameters.Add("Message", "Telefon Numarası Alanı 11 Birim Uzunluğunda Olması Gereklidir.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (!Regex.IsMatch(registerRequest.Phone, @"^[0-9]+$"))
        {
            modalParameters.Add("Message", "Telefon Numarası Alanı Rakamlardan Oluşması Gereklidir.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(registerRequest.Password))
        {
            modalParameters.Add("Message", "Şifre Alanı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }

        var result = await identityService.Register(registerRequest);
        if (result== "Kayıt işlemi başarılı bir şekilde gerçekleştirildi.")
        {
            loginRequest = new LoginRequest(registerRequest.Username, registerRequest.Password);
            await loginProcess();
        }
        else
        {
            modalParameters.Add("Message", result);
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
        }


        // Değer doluysa, formu göndermek için burada gerekli işlemleri yapabilirsiniz.
    }
    //private async Task registerProcess()
    //{

    //    var result = await identityService.Register(registerRequest);
    //    //if (result)
    //    //{
    //    //    var collection = HttpUtility.ParseQueryString(new Uri(navigationManager.Uri).Query);
    //    //    string retunUrl = collection.Get("returnUrl") ?? "/";
    //    //    navigationManager.NavigateTo(retunUrl);
    //    //}
    //}
    //public async Task ToggleClass()
    //{
    //    await jsRuntime.InvokeAsync<object>("toggleDisplayImgClass");
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
