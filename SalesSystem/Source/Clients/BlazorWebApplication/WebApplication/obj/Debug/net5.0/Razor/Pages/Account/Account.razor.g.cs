#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff4e952160abe48ef76b7b81112e375124598012"
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
#line 24 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account")]
    public partial class Account : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""breadcrumb-section breadcrumb-bg"" b-gi7leq8zwh><div class=""container"" b-gi7leq8zwh><div class=""row"" b-gi7leq8zwh><div class=""col-lg-8 offset-lg-2 text-center"" b-gi7leq8zwh><div class=""breadcrumb-text"" b-gi7leq8zwh><p b-gi7leq8zwh>E-Ticaret Websitesi</p>
                    <h1 b-gi7leq8zwh>Hesabım</h1></div></div></div></div></div>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "forAccountBackground");
            __builder.AddAttribute(3, "b-gi7leq8zwh");
            __builder.AddMarkupContent(4, "<div class=\"forAccountBackgroundPadding\" b-gi7leq8zwh></div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container emp-profile");
            __builder.AddAttribute(7, "b-gi7leq8zwh");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddAttribute(10, "b-gi7leq8zwh");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-8");
            __builder.AddAttribute(13, "b-gi7leq8zwh");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.AddAttribute(16, "b-gi7leq8zwh");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-12");
            __builder.AddAttribute(19, "b-gi7leq8zwh");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "profile-head");
            __builder.AddAttribute(22, "b-gi7leq8zwh");
            __builder.OpenElement(23, "h5");
            __builder.AddAttribute(24, "b-gi7leq8zwh");
            __builder.AddContent(25, 
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                 _userModel.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "h6");
            __builder.AddAttribute(28, "b-gi7leq8zwh");
            __builder.AddContent(29, 
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                 _userModel.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, " ");
            __builder.AddContent(31, 
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                                       _userModel.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                            ");
            __builder.AddMarkupContent(33, "<div class=\"nav nav-tabs\" b-gi7leq8zwh><a class=\"nav-link active\" b-gi7leq8zwh>Hakkında</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.AddAttribute(37, "b-gi7leq8zwh");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-md-10");
            __builder.AddAttribute(40, "b-gi7leq8zwh");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "tab-content profile-tab");
            __builder.AddAttribute(43, "id", "myTabContent");
            __builder.AddAttribute(44, "b-gi7leq8zwh");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "tab-pane fade show active");
            __builder.AddAttribute(47, "id", "home");
            __builder.AddAttribute(48, "role", "tabpanel");
            __builder.AddAttribute(49, "aria-labelledby", "home-tab");
            __builder.AddAttribute(50, "b-gi7leq8zwh");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.AddAttribute(53, "b-gi7leq8zwh");
            __builder.AddMarkupContent(54, "<div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>İsim</label></div>\r\n                                    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "col-md-6");
            __builder.AddAttribute(57, "b-gi7leq8zwh");
            __builder.OpenElement(58, "p");
            __builder.AddAttribute(59, "b-gi7leq8zwh");
            __builder.AddContent(60, 
#nullable restore
#line 50 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                            _userModel.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "row");
            __builder.AddAttribute(64, "b-gi7leq8zwh");
            __builder.AddMarkupContent(65, "<div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Soyisim</label></div>\r\n                                    ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-md-6");
            __builder.AddAttribute(68, "b-gi7leq8zwh");
            __builder.OpenElement(69, "p");
            __builder.AddAttribute(70, "b-gi7leq8zwh");
            __builder.AddContent(71, 
#nullable restore
#line 58 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                            _userModel.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "row");
            __builder.AddAttribute(75, "b-gi7leq8zwh");
            __builder.AddMarkupContent(76, "<div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Email</label></div>\r\n                                    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "col-md-6");
            __builder.AddAttribute(79, "b-gi7leq8zwh");
            __builder.OpenElement(80, "p");
            __builder.AddAttribute(81, "b-gi7leq8zwh");
            __builder.AddContent(82, 
#nullable restore
#line 66 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                            _userModel.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "row");
            __builder.AddAttribute(86, "b-gi7leq8zwh");
            __builder.AddMarkupContent(87, "<div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Telefon</label></div>\r\n                                    ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "col-md-6");
            __builder.AddAttribute(90, "b-gi7leq8zwh");
            __builder.OpenElement(91, "p");
            __builder.AddAttribute(92, "b-gi7leq8zwh");
            __builder.AddContent(93, 
#nullable restore
#line 74 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                            _userModel.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                                ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "row");
            __builder.AddAttribute(97, "b-gi7leq8zwh");
            __builder.AddMarkupContent(98, "<div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Ödeme Yöntemi Adeti</label></div>\r\n                                    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "col-md-6");
            __builder.AddAttribute(101, "b-gi7leq8zwh");
            __builder.OpenElement(102, "p");
            __builder.AddAttribute(103, "b-gi7leq8zwh");
            __builder.AddContent(104, 
#nullable restore
#line 82 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                            _paymentMethodModels.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                                ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "row");
            __builder.AddAttribute(108, "b-gi7leq8zwh");
            __builder.AddMarkupContent(109, "<div class=\"col-md-6\" b-gi7leq8zwh><label b-gi7leq8zwh>Sipariş Yöntemi Adeti</label></div>\r\n                                    ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "col-md-6");
            __builder.AddAttribute(112, "b-gi7leq8zwh");
            __builder.OpenElement(113, "p");
            __builder.AddAttribute(114, "b-gi7leq8zwh");
            __builder.AddContent(115, 
#nullable restore
#line 90 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                            _orderModels.Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "col-md-4");
            __builder.AddAttribute(119, "b-gi7leq8zwh");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "profile-img");
            __builder.AddAttribute(122, "b-gi7leq8zwh");
#nullable restore
#line 100 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                     if (!string.IsNullOrEmpty(_userModel.ProfileImagePath))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(123, "img");
            __builder.AddAttribute(124, "src", 
#nullable restore
#line 102 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                    "http://localhost:5002/pics" + _userModel.ProfileImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(125, "b-gi7leq8zwh");
            __builder.CloseElement();
#nullable restore
#line 103 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(126, "<img src=\"/assets/img/default-profile.png\" alt b-gi7leq8zwh>");
#nullable restore
#line 107 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "file btn btn-lg btn-primary");
            __builder.AddAttribute(129, "b-gi7leq8zwh");
            __builder.AddMarkupContent(130, "\r\n                        Fotoğrafı Değiştir\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(131);
            __builder.AddAttribute(132, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 111 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
                                             (e)=>HandleSelectedFile(e)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(133, "type", "file");
            __builder.AddAttribute(134, "name", "file");
            __builder.AddAttribute(135, "style", "position: absolute; opacity: 0; right: 0; top: 0;");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n    <div class=\"forAccountBackgroundPadding\" b-gi7leq8zwh></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\Account.razor"
       
    private bool isLoggedIn = false;

    [CascadingParameter]
    IModalService Modal { get; set; }
    [Inject]
    public IJSRuntime jsRuntime { get; set; }
    [Inject]
    IIdentityService identityService { get; set; }
    [Inject]
    StateManager stateManager { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }
    [Inject]
    IOrderService orderService { get; set; }


    UserDTO _userModel { get; set; }
    PaginatedViewModel<OrderDTO> _orderModels { get; set; } = new PaginatedViewModel<OrderDTO>();
    PaginatedViewModel<PaymentMethod> _paymentMethodModels { get; set; } = new PaginatedViewModel<PaymentMethod>();

    IBrowserFile pictureFiles;

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
            stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
        }
    }
    private async Task StateManager_StateChanged(ComponentBase component, string property)
    {
        if (property.Contains("accountPage"))
        {
            await InvokeAsync(StateHasChanged);
        }

    }
    private async void GetUser()
    {
        _userModel = identityService.GetUserModel(identityService.GetUserToken());
        _userModel.ProfileImagePath = await identityService.GetPicture(_userModel.Username);
        _orderModels = await orderService.GetOrdersDetailByBuyerName(_userModel.Username, 0,0);
        _paymentMethodModels = await orderService.GetPaymentMethodsDetailByBuyerName(_userModel.Username, 0,0);
        stateManager.UpdateContent(this, "accountPage");
    }
    private async Task HandleSelectedFile(InputFileChangeEventArgs e)
    {
        pictureFiles = e.File;
        var isChangedPicture= await identityService.ChangePicture(pictureFiles,_userModel.Username);
        ModalParameters modalParameters = new ModalParameters();
        if (isChangedPicture)
        {
            modalParameters.Add("Message", "Resim Başarılı Bir Şekilde Eklenildi.");
        }
        else
        {
            modalParameters.Add("Message", "Resim Eklenirken Hata Oluştu.");
        }
        Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
        GetUser();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
