#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8a22ebaaeaf4c0484834b7bd5b2e7bcf7444d51"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages.Basket
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Basket")]
    public partial class Basket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
 if (identityService.IsLoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, @"<div class=""breadcrumb-section breadcrumb-bg""><div class=""container""><div class=""row""><div class=""col-lg-8 offset-lg-2 text-center""><div class=""breadcrumb-text""><p>Fresh and Organic</p>
                        <h1>Sepet</h1></div></div></div></div></div>
    
    
    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "cart-section mt-150 mb-150");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-8 col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "cart-table-wrap");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "cart-table");
            __builder.AddMarkupContent(13, @"<thead class=""cart-table-head""><tr class=""table-head-row""><th class=""product-remove""></th>
                                    <th class=""product-image"">Ürün Resimi</th>
                                    <th class=""product-name"">Ürün Adı</th>
                                    <th class=""product-price"">Ürün Fiyatı</th>
                                    <th class=""product-quantity"">Ürün Adeti</th>
                                    <th class=""product-total"">Toplam Ürün Adeti</th></tr></thead>
                            ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 37 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                 if (basketModel.BasketItems.Any())
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                     foreach (var basketItem in basketModel.BasketItems)
                                    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.AddAttribute(16, "class", "table-body-row");
#nullable restore
#line 43 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                               string pictureUrl = "http://localhost:5001/pics" + basketItem.PictureUrl;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "class", "product-remove");
            __builder.OpenElement(19, "a");
            __builder.AddAttribute(20, "href", "#");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                                                                               async()=>await RemoveItemFromList(basketItem)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<i class=\"far fa-window-close\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                            ");
            __builder.AddMarkupContent(24, "<td class=\"product-image\"><img src=\"assets/img/products/product-img-3.jpg\" alt></td>\r\n                                            ");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "class", "product-name");
            __builder.AddContent(27, 
#nullable restore
#line 46 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                                                      basketItem.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                            ");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "class", "product-price");
            __builder.AddContent(31, 
#nullable restore
#line 47 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                                                       basketItem.UnitPrice.ToString("N2")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, " TL");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                                            ");
            __builder.AddMarkupContent(34, "<td class=\"product-quantity\"><input type=\"number\" placeholder=\"0\"></td>\r\n                                            ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "class", "product-total");
            __builder.AddContent(37, 
#nullable restore
#line 49 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                                                       basketItem.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                     
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-lg-4");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "total-section");
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "class", "total-table");
            __builder.AddMarkupContent(45, "<thead class=\"total-table-head\"><tr class=\"table-total-row\"><th>Total</th>\r\n                                    <th>Price</th></tr></thead>\r\n                            ");
            __builder.OpenElement(46, "tbody");
            __builder.OpenElement(47, "tr");
            __builder.AddAttribute(48, "class", "total-data");
            __builder.AddMarkupContent(49, "<td><strong>Total Adet: </strong></td>\r\n                                    ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 70 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                         basketModel.TotalQuantity()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                            ");
            __builder.OpenElement(53, "tr");
            __builder.AddAttribute(54, "class", "total-data");
            __builder.AddMarkupContent(55, "<td><strong>Total Fiyat: </strong></td>\r\n                                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 78 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                     basketModel.TotalUnitPrice()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(58, " TL");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "cart-buttons");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "href", "");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                                 (()=>ReloadPage())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "class", "boxed-btn");
            __builder.AddContent(66, "Sepeti Yenile");
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                             if (basketModel.BasketItems.Count > 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(67, "a");
            __builder.AddAttribute(68, "href", "");
            __builder.AddAttribute(69, "class", "boxed-btn black");
            __builder.AddAttribute(70, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                                                                               ()=>CheckOut()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(71, "Check Out");
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 96 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "<p>giriş başarısız</p>");
#nullable restore
#line 101 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Basket\Basket.razor"
       
    private bool isLoggedIn = false;

    CustomerBasket basketModel = new CustomerBasket();
    [Inject]
    IBasketService basketService { get; set; }
    [Inject]
    IIdentityService identityService { get; set; }
    [Inject]
    StateManager stateManager { get; set; }

    [Inject]
    NavigationManager navigationManager { get; set; }
    [Inject]
    public IJSRuntime jsRuntime { get; set; }
    protected async override Task OnInitializedAsync()
    {
        isLoggedIn = identityService.IsLoggedIn;
        if (isLoggedIn)
        {
            basketModel = await basketService.GetBasket();
        }
        else
        {
            await jsRuntime.InvokeVoidAsync("myFunction");
            navigationManager.NavigateTo($"login?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}", true);
        }
    }

    protected async override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("myFunction");
            //stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
        }
    }
    //private async Task StateManager_StateChanged(ComponentBase component, string property)
    //{
    //    if (property.Contains("basketPage"))
    //    {
    //        await InvokeAsync(StateHasChanged);
    //    }

    //}

    void CheckOut()
    {
        navigationManager.NavigateTo("/CheckOut");
    }
    async Task ReloadPage()
    {
        basketModel = await basketService.GetBasket();
        stateManager.UpdateContent(this, "basketPage");
    }
    async Task RemoveItemFromList(BasketItem item)
    {
        basketModel.BasketItems.Remove(item);
        basketModel = await basketService.UpdateBasket(basketModel);
        stateManager.UpdateCard(this);
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
