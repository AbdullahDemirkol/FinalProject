// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages.Order
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Order\CreateOrder.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CheckOut")]
    public partial class CreateOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 221 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Order\CreateOrder.razor"
       
    private bool isLoggedIn = false;

    [CascadingParameter]
    IModalService Modal { get; set; }
    [Inject]
    IIdentityService identityService { get; set; }

    [Inject]
    IBasketService basketService { get; set; }
    [Inject]
    IOrderService orderService { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }
    [Inject]
    StateManager stateManager { get; set; }
    [Inject]
    public IJSRuntime jsRuntime { get; set; }
    CustomerBasket _customerBasket { get; set; } = new CustomerBasket();
    PaginatedViewModel<PaymentMethod> _paymentMethods = new PaginatedViewModel<PaymentMethod>();


    public void AccessControl()
    {
        isLoggedIn = identityService.IsLoggedIn;
        if (isLoggedIn)
        {
            var stringDate = identityService.GetUserExpiration();
            DateTime loggedTime = DateTime.Parse(stringDate);
            DateTime nowDateTime = DateTime.Now;

            TimeSpan timeDifference = loggedTime - nowDateTime;

            if (timeDifference.TotalMinutes < -5)
            {
                identityService.Logout();
                isLoggedIn = identityService.IsLoggedIn;
                //stateManager.LoginChanged(this);
                //navigationManager.NavigateTo($"logout?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}", true);
            }
        }
    }
    protected async override Task OnInitializedAsync()
    {
        AccessControl();
        if (!isLoggedIn)
        {
            navigationManager.NavigateTo($"login?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}", true);
        }
        else
        {

            _customerBasket = await basketService.GetBasket();
            _paymentMethods = await orderService.GetPaymentMethodsDetailByBuyerName(identityService.GetUsername(), 0, 0);
            await jsRuntime.InvokeVoidAsync("myFunction");
        }
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
        if (property.Contains("createOrderPage"))
        {
            await InvokeAsync(StateHasChanged);
        }

    }
    Order orderModel = new Order()
    {
        Address = new Address("", "", "", "","","","",""),
        Buyer = new Buyer(new PaymentMethod("", "", "", "", 0)),
        Description = "Description"
    };

    async Task OnValidSubmit()
    {
        orderModel.Buyer.Name = identityService.GetUsername();
        orderModel.Buyer.PaymentMethod.CardExpirationApiFormat();
        var basketDto = new BasketDTO()
        {
            City = orderModel.Address.City,
            Street = orderModel.Address.Street,
            Neighbourhood = orderModel.Address.Neighbourhood,
            BuildingNo = orderModel.Address.BuildingNo,
            ApartmentNo = orderModel.Address.ApartmentNo,
            District = orderModel.Address.District,
            Country = orderModel.Address.Country,
            ZipCode = orderModel.Address.ZipCode,
            CardNumber = orderModel.Buyer.PaymentMethod.CardNumber,
            CardHolderName = orderModel.Buyer.PaymentMethod.CardHolderName,
            CardExpirationSort = orderModel.Buyer.PaymentMethod.CardExpirationShort,
            CardExpiration = orderModel.Buyer.PaymentMethod.Expiration,
            CardSecurityNumber = orderModel.Buyer.PaymentMethod.SecurityNumber,
            CardTypeId = orderModel.Buyer.PaymentMethod.CardTypeId,
            BuyerName = orderModel.Buyer.Name
        };
        await basketService.CheckOut(basketDto);
        stateManager.UpdateCard(this);
        navigationManager.NavigateTo("/");
    }
    protected void SetPaymentMethod(PaymentMethod paymentMethod)
    {
        orderModel.Buyer.PaymentMethod = paymentMethod;
        orderModel.Buyer.PaymentMethod.CardExpirationShort = paymentMethod.CardExpirationShort.Replace(".", "/");
    }
    //-----------------------------------------------------------------------------------
    //private string myValue;
    private async Task ValidateForm()
    {
        ModalParameters modalParameters = new ModalParameters();

        if (string.IsNullOrEmpty(orderModel.Address.Neighbourhood))
        {
            modalParameters.Add("Message", "Mahalle Adı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(orderModel.Address.Street))
        {
            modalParameters.Add("Message", "Sokak Adı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(orderModel.Address.BuildingNo))
        {
            modalParameters.Add("Message", "Apartman Numarası Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (!Regex.IsMatch(orderModel.Address.BuildingNo, @"^\d+$"))
        {
            modalParameters.Add("Message", "Apartman Numarası Sadece Sayılardan Oluşmalı.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(orderModel.Address.ApartmentNo))
        {
            modalParameters.Add("Message", "Daire Numarası Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }

        if (!Regex.IsMatch(orderModel.Address.ApartmentNo, @"^\d+$"))
        {
            modalParameters.Add("Message", "Daire Numarası Sadece Sayılardan Oluşmalı.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(orderModel.Address.ZipCode) || orderModel.Address.ZipCode.Length != 5)
        {
            modalParameters.Add("Message", "Posta Kodu 5 Haneli Olması Gereklidir.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(orderModel.Address.City))
        {
            modalParameters.Add("Message", "İl Adı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(orderModel.Address.District))
        {
            modalParameters.Add("Message", "İlçe Adı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(orderModel.Address.Country))
        {
            modalParameters.Add("Message", "Ülke Adı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(orderModel.Buyer.PaymentMethod.CardNumber))
        {
            modalParameters.Add("Message", "Kart Numarası Alanı Boş Bırakılamaz.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }

        if (!Regex.IsMatch(orderModel.Buyer.PaymentMethod.CardNumber, @"^\d+$"))
        {
            modalParameters.Add("Message", "Kart Numarası Alanı Sadece Sayı İçermelidir.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (orderModel.Buyer.PaymentMethod.CardNumber.Length != 16)
        {
            modalParameters.Add("Message", "Kart Numarası Alanı 16 Haneden Oluşması Gereklidir.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (string.IsNullOrEmpty(orderModel.Buyer.PaymentMethod.CardHolderName))
        {

            modalParameters.Add("Message", "Kart Üstündeki İsim ve Soyisim Boş Bırakılmamalıdır.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (!Regex.IsMatch(orderModel.Buyer.PaymentMethod.CardHolderName, @"\s{1,2}"))
        {

            modalParameters.Add("Message", "Kart Üstündeki İsim ve Soyisim'in içinde 1 boşluk bırakılmalıdır.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (orderModel.Buyer.PaymentMethod.CardExpirationShort.Length != 5 || orderModel.Buyer.PaymentMethod.CardExpirationShort[2] != '.' ||
            !char.IsDigit(orderModel.Buyer.PaymentMethod.CardExpirationShort[0]) || !char.IsDigit(orderModel.Buyer.PaymentMethod.CardExpirationShort[1]) ||
            !char.IsDigit(orderModel.Buyer.PaymentMethod.CardExpirationShort[3]) || !char.IsDigit(orderModel.Buyer.PaymentMethod.CardExpirationShort[4]))
        {

            modalParameters.Add("Message", "Kart Son Kullanma Tarihi MM.YY şeklinde olmalıdır. Örneğin 11.25 olmalıdır.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        if (!Regex.IsMatch(orderModel.Buyer.PaymentMethod.SecurityNumber, @"^\d+$") || orderModel.Buyer.PaymentMethod.SecurityNumber.Length != 3)
        {
            modalParameters.Add("Message", "Kart Güvenlik Numarası Alanı 3 Haneli Sayı İçermelidir.");
            Modal.Show<ShowMessagePopup>("Hata Mesajı", modalParameters);
            return;
        }
        await OnValidSubmit();

        // Değer doluysa, formu göndermek için burada gerekli işlemleri yapabilirsiniz.
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
