#pragma checksum "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b841337391c1938047a0e0c351b00172fd4bc46c"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages.Product.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using WebApplication.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\_Imports.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class ProductView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-lg-4 col-md-6 text-center");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "single-product-item");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "product-image");
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
             if (ProductItem.Pictures.Count != 0)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "href", "/ProductDetail/" + (
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
                                         ProductItem.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
                                                                     "http://localhost:5001/pics" + ProductItem.Pictures[0].ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "style", "height:300px;");
            __builder.AddAttribute(11, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", "/ProductDetail/" + (
#nullable restore
#line 11 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
                                         ProductItem.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "<img src=\"assets/img/default-product.png\" style=\"width: 261px;height: 300px;\" alt>");
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "h3");
            __builder.AddContent(17, 
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
             ProductItem.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "h3");
            __builder.AddContent(20, 
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
             ProductItem.Brand.BrandName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "h3");
            __builder.AddContent(23, 
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
             ProductItem.UpCategory.UpCategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "h3");
            __builder.AddContent(26, 
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
             ProductItem.DownCategory.DownCategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n        ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "product-price");
            __builder.AddMarkupContent(30, "<span>Fiyatı</span> ");
            __builder.AddContent(31, 
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
                                                      ProductItem.Price.ToString("N2")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(32, " TL ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "class", "cart-btn");
            __builder.AddAttribute(36, "href", "/ProductDetail/" + (
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
                                                  ProductItem.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(37, "Ürünü İncele");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "class", "cart-btn");
            __builder.AddAttribute(41, "onclick", 
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
                                      OnClick

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(42, " Sepete Ekle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\yedek\son hale\yedekk\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\ProductView.razor"
       

    [Parameter]
    public Product ProductItem { get; set; }
    [Parameter]
    public EventCallback<MouseEventArgs> OnClick { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }
    [Inject]
    IJSRuntime jsRuntime { get; set; }
    




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
