#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "017510435d94237849d16006e0439d912735309e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""homepage-slider""><div class=""single-homepage-slider homepage-bg-1""><div class=""container""><div class=""row""><div class=""col-md-10 offset-lg-1 text-center""><div class=""hero-text""><div class=""hero-text-tablecell""><p class=""subtitle"">E-Ticaret Websitesi</p>
                            <h1>Hoşgeldiniz!</h1>
                            <div class=""hero-btns""><a href=""/Product"" class=""boxed-btn"">Alışverişe Başlayın</a></div></div></div></div></div></div></div>
    
    <div class=""single-homepage-slider homepage-bg-2""><div class=""container""><div class=""row""><div class=""col-lg-10 offset-lg-1 text-center""><div class=""hero-text""><div class=""hero-text-tablecell""><p class=""subtitle"">E-Ticaret Websitesi</p>
                            <h1>Sorun Mu Yaşıyorsunuz?</h1>
                            <div class=""hero-btns""><a href=""/About"" class=""boxed-btn"">İletişime Geçin</a></div></div></div></div></div></div></div></div>


");
            __builder.AddMarkupContent(1, @"<div class=""list-section pt-80 pb-80""><div class=""container""><div class=""row""><div class=""col-lg-4 col-md-6 mb-4 mb-lg-0""><div class=""list-box d-flex align-items-center""><div class=""list-icon""><i class=""fas fa-shipping-fast""></i></div>
                    <div class=""content""><h3>Ücretsiz Kargo</h3>
                        <p>Siparişlerinizin Kargoları Bedava</p></div></div></div>
            <div class=""col-lg-4 col-md-6 mb-4 mb-lg-0""><div class=""list-box d-flex align-items-center""><div class=""list-icon""><i class=""fas fa-phone-volume""></i></div>
                    <div class=""content""><h3>7/24 Destek</h3>
                        <p>Her Saat Ulaşılabilir Destek</p></div></div></div>
            <div class=""col-lg-4 col-md-6""><div class=""list-box d-flex justify-content-start align-items-center""><div class=""list-icon""><i class=""fas fa-sync""></i></div>
                    <div class=""content""><h3>İade</h3>
                        <p>1 Hafta İçerisinde Geri Ödeme</p></div></div></div></div></div></div>


");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "product-section mt-150 mb-150");
            __builder.AddAttribute(4, "style", "padding-top: 30px;");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddMarkupContent(7, "<div class=\"row\"><div class=\"col-lg-8 offset-lg-2 text-center\"><div class=\"section-title\"><h3><span class=\"orange-text\">Tüm</span> Ürünlerimiz</h3></div></div></div>\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddAttribute(10, "style", "height:auto;");
#nullable restore
#line 98 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Index.razor"
             if (_products != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Index.razor"
                 foreach (var productItem in _products)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<WebApplication.Pages.Product.Products.ProductView>(11);
            __builder.AddAttribute(12, "ProductItem", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WebApplication.Entity.Concrete.Product.Product>(
#nullable restore
#line 102 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Index.razor"
                                                                                    productItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Index.razor"
                                                                                                          ()=>AddToCart(productItem)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 103 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Index.razor"
                 

            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<div class=\"col-md-12\" style=\"text-align:center;\"><a href=\"/Product\"><h4>Diğer Ürünlerimiz --></h4></a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Index.razor"
      
    [Inject]
    public IJSRuntime jsRuntime { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }
    [Inject]
    StateManager stateManager { get; set; }
    [Inject]
    IProductService productService { get; set; }
    [Inject]
    IIdentityService identityService { get; set; }
    [Inject]
    public IBasketService basketService { get; set; }
    IEnumerable<Entity.Concrete.Product.Product> _products=new List<Entity.Concrete.Product.Product>() ;
    int _productCount { get; set; }

    bool isSuccess { get; set; }
    string message { get; set; }
    bool showNotification { get; set; } = false;

    public void AccessControl()
    {
        bool isLoggedIn = identityService.IsLoggedIn;
        if (isLoggedIn)
        {
            var stringDate = identityService.GetUserExpiration();
            DateTime loggedTime = DateTime.Parse(stringDate);
            DateTime nowDateTime = DateTime.Now;

            TimeSpan timeDifference = loggedTime - nowDateTime;

            if (timeDifference.TotalMinutes < -5)
            {
                identityService.Logout();
                stateManager.LoginChanged(this);
                //navigationManager.NavigateTo($"logout?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}", true);
            }
        }
    }
    protected async override void OnInitialized()
    {
        AccessControl();
        await GetProducts();
    }
    protected async Task GetProducts()
    {
        var inComingProducts = await productService.GetProductsItem(0,0,0,0, 3);
        _products = inComingProducts.Data;
        _productCount = inComingProducts.Count;
        stateManager.UpdateContent(this, "HomePage");
    }
    protected async override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("myFunction");
            stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
        }
    }
    private async Task StateManager_StateChanged(ComponentBase component, string property)
    {
        if (property == "HomePage")
        {
            await InvokeAsync(StateHasChanged);
        }

    }
    public async Task AddToCart(Entity.Concrete.Product.Product product)
    {
        if (!identityService.IsLoggedIn)
        {
            navigationManager.NavigateTo($"login?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}", true);
            return;
        }
        var addResult = await basketService.AddItemToBasket(product.Id, 1);

        showNotification = true;
        if (addResult)
        {
            isSuccess = true;
            message = "Ürün başarıyla eklendi. Miktar: 1";
        }
        else
        {
            isSuccess = false;
            message = "Ürün ekleme işleminde hata oluştu!";
        }
        stateManager.UpdateContent(this, "HomePage");

        // 2 saniye sonra bildirimi kaldır
        await Task.Delay(2000).ContinueWith(t =>
        {
            isSuccess = false;
            message = "";
            showNotification = false;
            stateManager.UpdateContent(this, "HomePage");
        });


    }
    //private async Task StateManager_StateChanged(ComponentBase component, string property)
    //{
    //    //jSObjectReference = await jsRuntime.InvokeAsync<IJSObjectReference>("import", navigationManager.BaseUri + "assets/js/main.js");
    //    await InvokeAsync(StateHasChanged);

    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
