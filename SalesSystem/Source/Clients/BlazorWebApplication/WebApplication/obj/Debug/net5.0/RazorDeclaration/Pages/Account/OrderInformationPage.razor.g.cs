// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Orders")]
    public partial class OrderInformationPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 212 "C:\Users\Abdullah\Desktop\Yeni klasör (4)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Account\OrderInformationPage.razor"
       
    private bool isLoggedIn = false;
    [CascadingParameter]
    IModalService Modal { get; set; }
    [Inject]
    public IJSRuntime jsRuntime { get; set; }
    [Inject]
    StateManager stateManager { get; set; }
    [Inject]
    IIdentityService identityService { get; set; }
    [Inject]
    IOrderService orderService { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }

    UserDTO _userModel { get; set; } = new UserDTO();
    List<OrderStatus> _orderStatuses{ get; set; }= new List<OrderStatus>();
    PaginatedViewModel<OrderDTO> _orderModels { get; set; } = new PaginatedViewModel<OrderDTO>();
    int selectedOption = 0;
    private int CurPage = 1;
    private int CurOrderStatus=0;
    private async void Pagination(int page,int? orderStatus)
    {
        CurPage = page + 1;
        if (orderStatus==0)
        {
            await GetOrders(page, null);
        }
        else
        {
            await GetOrders(page, orderStatus);
        }
        var pık = Math.Round(Convert.ToDouble(_orderModels.Count / 6));
    }
    protected async Task NextPage(int? orderStatus)
    {
        int MaxPage = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(_orderModels.Count) / 6));
        if (CurPage < MaxPage)
        {

            CurPage++;
            if (orderStatus == 0)
            {
                await GetOrders(CurPage - 1, null);
            }
            else
            {
                await GetOrders(CurPage - 1, orderStatus);
            }
        }
    }
    protected async Task PrevPage(int? orderStatus)
    {
        if (CurPage > 1)
        {
            CurPage--;
            if (orderStatus == 0)
            {
                await GetOrders(CurPage - 1, null);
            }
            else
            {
                await GetOrders(CurPage - 1, orderStatus);
            }
        }
    }
    private void OptionSelected(ChangeEventArgs e)
    {
        selectedOption = Convert.ToInt32(e.Value);
    }
    protected void GetOrderByOrderStatus()
    {
        CurOrderStatus = selectedOption;
        Pagination(0, CurOrderStatus);
    }

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
        _userModel = identityService.GetUserModel(identityService.GetUserToken());
        await GetOrders(0,null);
    }
    protected async override void OnInitialized()
    {
        await jsRuntime.InvokeVoidAsync("myFunction");
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
        if (property.Contains("orderPage"))
        {
            await InvokeAsync(StateHasChanged);
        }

    }
    protected async Task GetOrders(int pageIndex,int? orderStatus)
    {
        if (orderStatus==null)
        {
            _orderModels = await orderService.GetOrdersDetailByBuyerName(_userModel.Username, 0, pageIndex);

        }
        else
        {
            _orderModels = await orderService.GetOrdersDetailByBuyerName(_userModel.Username, CurOrderStatus, pageIndex);
        }
        SetOrderStatus((List<OrderDTO>)_orderModels.Data);
        await GetSearchValue();
        stateManager.UpdateContent(this, "orderPage");
    }
    protected void SetOrderStatus(List<OrderDTO> orderDTOs)
    {
        foreach (var order in orderDTOs)
        {
            if (order.Status=="islemealinildi")
            {
                order.Status = "İşleme Alınıldı";
            }
            else if (order.Status == "dogrulamabekleniyor")
            {
                order.Status = "Doğrulama Bekleniyor";
            }
            else if (order.Status == "stokonaylandi")
            {
                order.Status = "Stok Onaylandı";
            }
            else if (order.Status == "odenildi")
            {
                order.Status = "Ödenildi";
            }
            else if (order.Status == "gonderildi")
            {
                order.Status = "Gönderildi";
            }
            else if (order.Status == "tamamlanildi")
            {
                order.Status = "Tamamlanıldı";
            }
            else if (order.Status == "iptaledildi")
            {
                order.Status = "İptal Edildi";
            }
        }
    }
    protected async Task GetSearchValue()
    {
        _orderStatuses=await orderService.GetOrderStatuses();
    }
    private async void DeleteOrder(Guid OrderNumber)
    {
        await orderService.CancelOrderStatus(OrderNumber, _userModel.Username);
        CurPage = 1;
        await GetOrders(0,CurOrderStatus);
        ModalParameters modalParameters = new ModalParameters();
        modalParameters.Add("Message", "Sipariş İptal Edildi.");
        Modal.Show<ShowMessagePopup>("Bilgilendirme", modalParameters);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
