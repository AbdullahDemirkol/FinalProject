#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6c3a42db624f8b3916d59f74c16b8a81337f47e"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.Pages.Product.DetailProduct
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductDetail/{productId:int}")]
    public partial class DetailProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""breadcrumb-section breadcrumb-bg""><div class=""container""><div class=""row""><div class=""col-lg-8 offset-lg-2 text-center""><div class=""breadcrumb-text""><p>E-Ticaret Websitesi</p>
                    <h1>Ürün Detayı</h1></div></div></div></div></div>


");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "single-product mt-150 mb-150");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-5");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "single-product-img");
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                     if (productItem.Pictures != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                         if (productItem.Pictures.Count() > 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", 
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                        "http://localhost:5001/pics" + productItem.Pictures[0].ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "alt");
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<img src=\"assets/img/default-product.png\" alt>");
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<img src=\"assets/img/default-product.png\" alt>");
#nullable restore
#line 36 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-7");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "single-product-content");
            __builder.OpenElement(21, "h3");
            __builder.AddContent(22, 
#nullable restore
#line 41 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                         productItem.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "p");
            __builder.AddMarkupContent(25, "<strong>Kategori: </strong>");
#nullable restore
#line 43 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                    if (productItem.DownCategory != null)
                        {
                            

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, 
#nullable restore
#line 45 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                             productItem.DownCategory.DownCategoryName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 45 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                                      
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "p");
            __builder.AddMarkupContent(29, "<strong>Marka: </strong>");
#nullable restore
#line 49 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                 if (productItem.Brand != null)
                        {
                            

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, 
#nullable restore
#line 51 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                             productItem.Brand.BrandName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 51 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                        
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "p");
            __builder.AddContent(33, 
#nullable restore
#line 54 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                        productItem.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "p");
            __builder.AddAttribute(36, "class", "single-product-pricing");
            __builder.AddMarkupContent(37, "Fiyatı: ");
            __builder.AddContent(38, 
#nullable restore
#line 55 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                               productItem.Price.ToString("N2")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(39, " TL");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "single-product-form");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "number");
            __builder.AddAttribute(45, "placeholder", "1");
            __builder.AddAttribute(46, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                                       (e)=>UpdateProductQuantity(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "class", "cart-btn");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                      ()=>AddToCart(productItem,null)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, " Sepete Ekle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n\r\n");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "more-products mb-150");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "container");
            __builder.AddMarkupContent(57, "<div class=\"row\"><div class=\"col-lg-8 offset-lg-2 text-center\"><div class=\"section-title\"><h3> Aynı Kategoriye Ait Başka Ürünler</h3></div></div></div>\r\n\r\n        ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "row");
#nullable restore
#line 79 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
             if (similarPoductsItem.Count != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                 foreach (var similarPoductItem in similarPoductsItem)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-lg-4 col-md-6 text-center strawberry");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "single-product-item");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "product-image");
#nullable restore
#line 86 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                 if (similarPoductItem.Pictures.Count != 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "a");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                 ()=>GoDetailProduct(similarPoductItem.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(68, "img");
            __builder.AddAttribute(69, "src", 
#nullable restore
#line 88 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                                                                        "http://localhost:5001/pics" + similarPoductItem.Pictures[0].ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(70, "style", "height:300px;");
            __builder.AddAttribute(71, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                }
                                else
                                {
                                    //href = "/ProductDetail/@similarPoductItem.Id"
                                    

#line default
#line hidden
#nullable disable
            __builder.OpenElement(72, "a");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                 ()=>GoDetailProduct(similarPoductItem.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(74, "<img src=\"assets/img/default-product.png\" style=\"width: 261px;height: 300px;\" alt>");
            __builder.CloseElement();
#nullable restore
#line 95 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                            ");
            __builder.OpenElement(76, "h3");
            __builder.AddContent(77, 
#nullable restore
#line 97 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                 similarPoductItem.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.OpenElement(79, "h3");
            __builder.AddContent(80, 
#nullable restore
#line 98 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                 similarPoductItem.Brand.BrandName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                            ");
            __builder.OpenElement(82, "h3");
            __builder.AddContent(83, 
#nullable restore
#line 99 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                 similarPoductItem.UpCategory.UpCategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                            ");
            __builder.OpenElement(85, "h3");
            __builder.AddContent(86, 
#nullable restore
#line 100 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                 similarPoductItem.DownCategory.DownCategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n\r\n                            ");
            __builder.OpenElement(88, "p");
            __builder.AddAttribute(89, "class", "product-price");
            __builder.AddMarkupContent(90, "<span>Fiyatı</span> ");
            __builder.AddContent(91, 
#nullable restore
#line 102 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                                          similarPoductItem.Price.ToString("N2")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(92, " TL ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                            ");
            __builder.OpenElement(94, "a");
            __builder.AddAttribute(95, "class", "cart-btn");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                          ()=>GoDetailProduct(similarPoductItem.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "Ürünü İncele");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                            ");
            __builder.OpenElement(99, "a");
            __builder.AddAttribute(100, "class", "cart-btn");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                          ()=>AddToCart(similarPoductItem,1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(102, " Sepete Ekle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 109 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 109 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 115 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
 if (showNotification)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "notification-container");
            __builder.OpenComponent<WebApplication.Pages.Modal.Notification>(105);
            __builder.AddAttribute(106, "IsSuccess", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 118 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                  isSuccess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "Message", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 118 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
                                                       message

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 120 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\DetailProduct\DetailProduct.razor"
       
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
    [Parameter]
    public int productId { get; set; }

    private int productQuantity;

    Product productItem = new Product();
    List<Product> similarPoductsItem = new List<Product>();

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
    protected async override Task OnInitializedAsync()
    {
        AccessControl();
        await GetProduct();
        await SimilarPoductItem();
        stateManager.UpdateContent(this, "ProductDetail");
    }
    //protected async override void OnInitialized()
    //{
    //    //Task.Delay(2000);
    //}
    protected async Task GetProduct()
    {
        var listProduct = await productService.GetProductItem(productId);
        productItem = listProduct.First();
    }
    protected async Task SimilarPoductItem()
    {
        var listProduct = await productService.GetSimilarProductsItem(productItem.Id);
        similarPoductsItem = listProduct;
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
        }
    }
    private async Task StateManager_StateChanged(ComponentBase component, string property)
    {
        if (property == "ProductDetail")
        {
            await InvokeAsync(StateHasChanged);
        }
    }
    protected async void GoDetailProduct(int productId)
    {
        this.productId = productId;
        await GetProduct();
        await SimilarPoductItem();
        navigationManager.NavigateTo("/ProductDetail/" + productId);
        stateManager.UpdateContent(this, "ProductDetail");
    }

    private void UpdateProductQuantity(ChangeEventArgs e)
    {
        productQuantity = Convert.ToInt32(e.Value);
    }
    public async Task AddToCart(Product product, int? quantity)
    {

        if (!identityService.IsLoggedIn)
        {
            navigationManager.NavigateTo(navigationManager.BaseUri + $"login?returnUrl={Uri.EscapeDataString(navigationManager.Uri)}", true);
            return;
        }
        (bool,int) addResult;
        if (quantity == null)
        {
            var isAdded= await basketService.AddItemToBasket(product.Id, productQuantity);
            addResult = (isAdded, productQuantity);
        }
        else
        {
            var isAdded = await basketService.AddItemToBasket(product.Id, 1);
            addResult = (isAdded, 1);
        }

        showNotification = true;
        if (addResult.Item1)
        {
            isSuccess = true;
            message = $"Ürün başarıyla eklendi. Miktar: {addResult.Item2}";
        }
        else
        {
            isSuccess = false;
            message = "Ürün ekleme işleminde hata oluştu!";
        }
        StateHasChanged();

        // 2 saniye sonra bildirimi kaldır
        await Task.Delay(2000).ContinueWith(t =>
        {
            isSuccess = false;
            message = "";
            showNotification = false;
            StateHasChanged();
        });


    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
