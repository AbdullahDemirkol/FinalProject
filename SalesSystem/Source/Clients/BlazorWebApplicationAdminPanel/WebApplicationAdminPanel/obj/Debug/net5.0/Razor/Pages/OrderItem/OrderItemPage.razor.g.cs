#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "481a63e28f6e39264e5ce608c08f171da4fff34c"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplicationAdminPanel.Pages.OrderItem
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderItem/{order}")]
    public partial class OrderItemPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
 if (orderDto != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-md-12");
            __builder.AddAttribute(2, "b-gyriy29nt6");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddAttribute(5, "b-gyriy29nt6");
            __builder.AddMarkupContent(6, "<h3 onclick=\"history.back();\" class=\"back-button\" b-gyriy29nt6> &lt;</h3>\r\n            ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "style", "right:0;position: absolute;");
            __builder.AddAttribute(9, "class", "main-btn");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                                   OrderUpdate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "b-gyriy29nt6");
            __builder.AddContent(12, 
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                                                 updateText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "style", "padding-top: 15px;");
            __builder.AddAttribute(16, "b-gyriy29nt6");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "display: flex; flex-direction: row;");
            __builder.AddAttribute(19, "b-gyriy29nt6");
            __builder.AddMarkupContent(20, "<div class=\"col-md-2\" b-gyriy29nt6><h4 b-gyriy29nt6>Sipariş Numarası:</h4></div>\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "b-gyriy29nt6");
            __builder.OpenElement(23, "h4");
            __builder.AddAttribute(24, "b-gyriy29nt6");
            __builder.AddContent(25, 
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                     orderDto.OrderNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "style", "display: flex; flex-direction: row;");
            __builder.AddAttribute(29, "b-gyriy29nt6");
            __builder.AddMarkupContent(30, "<div class=\"col-md-2\" b-gyriy29nt6><h4 b-gyriy29nt6>Sipariş Tarihi:</h4></div>\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "b-gyriy29nt6");
            __builder.OpenElement(33, "h4");
            __builder.AddAttribute(34, "b-gyriy29nt6");
            __builder.AddContent(35, 
#nullable restore
#line 25 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                     orderDto.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "display: flex; flex-direction: row;");
            __builder.AddAttribute(39, "b-gyriy29nt6");
            __builder.AddMarkupContent(40, "<div class=\"col-md-2\" b-gyriy29nt6><h4 b-gyriy29nt6>Alıcı:</h4></div>\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "b-gyriy29nt6");
            __builder.OpenElement(43, "h4");
            __builder.AddAttribute(44, "b-gyriy29nt6");
            __builder.AddContent(45, 
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                     orderDto.BuyerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "style", "display: flex; flex-direction: row;");
            __builder.AddAttribute(49, "b-gyriy29nt6");
            __builder.AddMarkupContent(50, "<div class=\"col-md-2\" b-gyriy29nt6><h4 b-gyriy29nt6>Sipariş Adresi:</h4></div>\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "b-gyriy29nt6");
            __builder.OpenElement(53, "h4");
            __builder.AddAttribute(54, "b-gyriy29nt6");
            __builder.AddContent(55, 
#nullable restore
#line 41 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                     orderDto.Neighbourhood

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(56, " Mah. ");
            __builder.AddContent(57, 
#nullable restore
#line 41 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                  orderDto.Street

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(58, " Sok. No:");
            __builder.AddContent(59, 
#nullable restore
#line 41 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                           orderDto.BuildingNo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(60, "/D:");
            __builder.AddContent(61, 
#nullable restore
#line 41 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                                                  orderDto.ApartmentNo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, "  ");
            __builder.AddContent(63, 
#nullable restore
#line 41 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                                                                         orderDto.District

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(64, "/");
            __builder.AddContent(65, 
#nullable restore
#line 41 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                                                                                            orderDto.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "style", "display: flex; flex-direction: row;");
            __builder.AddAttribute(69, "b-gyriy29nt6");
            __builder.AddMarkupContent(70, "<div class=\"col-md-2\" b-gyriy29nt6><h4 b-gyriy29nt6>Posta Kodu:</h4></div>\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "b-gyriy29nt6");
            __builder.OpenElement(73, "h4");
            __builder.AddAttribute(74, "b-gyriy29nt6");
            __builder.AddContent(75, 
#nullable restore
#line 49 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                     orderDto.ZipCode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "style", "display: flex; flex-direction: row;");
            __builder.AddAttribute(79, "b-gyriy29nt6");
#nullable restore
#line 53 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
             if (updateMode)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(80, "<div class=\"col-md-2\" b-gyriy29nt6><h4 b-gyriy29nt6>Sipariş Durumu: Update Mod Açık</h4></div>\r\n                ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "b-gyriy29nt6");
            __builder.OpenElement(83, "select");
            __builder.AddAttribute(84, "id", "StatusSelect");
            __builder.AddAttribute(85, "class", "statusSelect");
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                              OptionSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "b-gyriy29nt6");
#nullable restore
#line 60 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                         foreach (var _orderStatus in _orderStatuses)
                        {
                            if (orderDto.Status != _orderStatus.Name)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(88, "option");
            __builder.AddAttribute(89, "value", 
#nullable restore
#line 64 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                _orderStatus.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(90, "b-gyriy29nt6");
            __builder.AddContent(91, 
#nullable restore
#line 64 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                  _orderStatus.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(92, "option");
            __builder.AddAttribute(93, "value", 
#nullable restore
#line 68 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                _orderStatus.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(94, "selected");
            __builder.AddAttribute(95, "b-gyriy29nt6");
            __builder.AddContent(96, 
#nullable restore
#line 68 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                           _orderStatus.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(97, "<div class=\"col-md-2\" b-gyriy29nt6><h4 b-gyriy29nt6>Sipariş Durumu: Update Mod kapalı</h4></div>\r\n                ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "b-gyriy29nt6");
            __builder.OpenElement(100, "h4");
            __builder.AddAttribute(101, "b-gyriy29nt6");
            __builder.AddContent(102, 
#nullable restore
#line 80 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                         orderDto.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 82 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n        ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "style", "display: flex; flex-direction: row;");
            __builder.AddAttribute(106, "b-gyriy29nt6");
            __builder.AddMarkupContent(107, "<div class=\"col-md-2\" b-gyriy29nt6><h4 b-gyriy29nt6>Ödeme Yöntemi:</h4></div>\r\n            ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "b-gyriy29nt6");
            __builder.OpenElement(110, "h4");
            __builder.AddAttribute(111, "b-gyriy29nt6");
            __builder.AddContent(112, 
#nullable restore
#line 89 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                      $"{orderDto.PaymentMethodPrefix}-****-****-{orderDto.PaymentMethodSuffix}"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n        ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "col-md-12");
            __builder.AddAttribute(116, "style", "padding-top:15px");
            __builder.AddAttribute(117, "b-gyriy29nt6");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "class", "row");
            __builder.AddAttribute(120, "b-gyriy29nt6");
            __builder.AddMarkupContent(121, "<h2 b-gyriy29nt6>Sipariş Ürünleri </h2>");
            __builder.OpenElement(122, "h2");
            __builder.AddAttribute(123, "style", "right:0;position: absolute;");
            __builder.AddAttribute(124, "b-gyriy29nt6");
            __builder.AddContent(125, "Toplam: ");
            __builder.AddContent(126, 
#nullable restore
#line 94 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                                           orderDto.Total.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n        <h4 class=\"text-right\" b-gyriy29nt6></h4>\r\n        ");
            __builder.OpenElement(128, "table");
            __builder.AddAttribute(129, "class", "table");
            __builder.AddAttribute(130, "b-gyriy29nt6");
            __builder.AddMarkupContent(131, @"<thead b-gyriy29nt6><tr b-gyriy29nt6><th b-gyriy29nt6>Ürün Resimi</th>
                    <th b-gyriy29nt6>Ürün Adı</th>
                    <th b-gyriy29nt6>Ürün Fiyatı</th>
                    <th b-gyriy29nt6>Adet</th>
                    <th b-gyriy29nt6>Toplam Fiyat</th></tr></thead>
            ");
            __builder.OpenElement(132, "tbody");
            __builder.AddAttribute(133, "b-gyriy29nt6");
#nullable restore
#line 109 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                 foreach (var orderItem in orderDto.OrderItems)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(134, "tr");
            __builder.AddAttribute(135, "style", "vertical-align: middle;");
            __builder.AddAttribute(136, "b-gyriy29nt6");
#nullable restore
#line 112 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                         if (orderItem.PictureUrl != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(137, "td");
            __builder.AddAttribute(138, "class", "product-image");
            __builder.AddAttribute(139, "b-gyriy29nt6");
            __builder.OpenElement(140, "img");
            __builder.AddAttribute(141, "src", 
#nullable restore
#line 114 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                                                                  "http://localhost:5001/pics" + orderItem.PictureUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(142, "style", "height: auto; width: 150px;");
            __builder.AddAttribute(143, "alt");
            __builder.AddAttribute(144, "b-gyriy29nt6");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 115 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(145, "<td class=\"product-image\" b-gyriy29nt6><img src=\"assets/img/default-product.png\" style=\"height: auto; width: 150px;\" alt b-gyriy29nt6></td>");
#nullable restore
#line 119 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(146, "td");
            __builder.AddAttribute(147, "b-gyriy29nt6");
            __builder.AddContent(148, 
#nullable restore
#line 120 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                             orderItem.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                        ");
            __builder.OpenElement(150, "td");
            __builder.AddAttribute(151, "b-gyriy29nt6");
            __builder.AddContent(152, 
#nullable restore
#line 121 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                             orderItem.UnitPrice.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                        ");
            __builder.OpenElement(154, "td");
            __builder.AddAttribute(155, "b-gyriy29nt6");
            __builder.AddContent(156, 
#nullable restore
#line 122 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                             orderItem.Units

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                        ");
            __builder.OpenElement(158, "td");
            __builder.AddAttribute(159, "b-gyriy29nt6");
            __builder.AddContent(160, 
#nullable restore
#line 123 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                             orderItem.Total().ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 125 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n        <hr b-gyriy29nt6>");
            __builder.CloseElement();
#nullable restore
#line 130 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(162, "<h3 b-gyriy29nt6>Sipariş Bulunamadı.</h3>");
#nullable restore
#line 134 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 136 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\OrderItem\OrderItemPage.razor"
       
    [Parameter]
    public string Order { get; set; }

    [Inject]
    StateManager stateManager { get; set; }
    [Inject]
    IOrderService orderService { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }
    [Inject]
    IIdentityService _identityService { get; set; }

    List<OrderStatus> _orderStatuses { get; set; } = new List<OrderStatus>();
    bool updateMode = false;
    string updateText = "Sipariş Durumu Değiştir";
    private OrderDTO orderDto;
    int selectedOption;
    bool isLoggedIn = false;

    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
        }
    }
    private async Task StateManager_StateChanged(ComponentBase component, string property)
    {
        if (property == "orderItemPage")
        {
            await InvokeAsync(StateHasChanged);
        }

    }

    public void AccessControl()
    {
        isLoggedIn = _identityService.IsLoggedIn;
        if (isLoggedIn)
        {
            var stringDate = _identityService.GetUserExpiration();
            DateTime loggedTime = DateTime.Parse(stringDate);
            DateTime nowDateTime = DateTime.Now;

            TimeSpan timeDifference = loggedTime - nowDateTime;

            if (timeDifference.TotalMinutes < -5)
            {
                navigationManager.NavigateTo($"logout");
            }
        }
    }
    protected override async Task OnInitializedAsync()
    {
        AccessControl();
        if (!string.IsNullOrEmpty(Order))
        {
            string jsonParameter = Uri.UnescapeDataString(Order);
            orderDto = JsonSerializer.Deserialize<OrderDTO>(jsonParameter);
        }
        _orderStatuses = await orderService.GetOrderStatuses();
        await Task.CompletedTask;
    }
    public void OrderUpdate()
    {
        if (updateMode)
        {
            orderService.SetOrderStatus(orderDto,selectedOption);
            orderDto.Status = _orderStatuses.FirstOrDefault(p => p.Id == selectedOption).Name;
            updateMode = false;
            updateText = "Sipariş Durumu Değiştir";
        }
        else
        {
            updateMode = true;
            updateText = "Siparişi Güncelle";
        }
        stateManager.UpdateContent(this, "orderItemPage");
    }
    private void OptionSelected(ChangeEventArgs e)
    {
        //setOrderStatus /{ statusId}/ buyerName /{ buyerName}
        selectedOption = Convert.ToInt32(e.Value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
