#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec856d2659a22d958c0d1e7eac2e46887882bc9e"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplicationAdminPanel.Pages.Modal
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
    public partial class UpdateProductModalPopup : BaseModal
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddAttribute(1, "enctype", "multipart/form-data");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "modal-body");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-6");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group");
            __builder.AddMarkupContent(10, "<label>Ürün Adı</label>\r\n                    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "name", "productName");
            __builder.AddAttribute(15, "required");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                         productDto.Product.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productDto.Product.Name = __value, productDto.Product.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-6");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "<label>Fiyatı</label>\r\n                    ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "required");
            __builder.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                          productDto.Product.Price

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productDto.Product.Price = __value, productDto.Product.Price));
            __builder.SetUpdatesAttributeName("Value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
               var p = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
             foreach (var picture in productDto.Product.Pictures)
            {
                if (!string.IsNullOrEmpty(picture.ImagePath))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-md-4");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group");
            __builder.AddAttribute(37, "style", "border: 1px solid black; border-radius: 15px; padding: 15px;");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "row");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-md-6");
            __builder.OpenElement(42, "label");
            __builder.AddContent(43, 
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                            p

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(44, ". Resim");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-md-6 text-right");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-danger");
            __builder.AddAttribute(50, "style", "border-radius: 10px; margin-bottom: 10px;");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                                                                               ()=>DeletePictureClicked(picture.ImagePath,productDto.Product.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Resimi sil");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "row");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-md-12 text-center");
            __builder.OpenElement(58, "img");
            __builder.AddAttribute(59, "src", 
#nullable restore
#line 36 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                "http://localhost:5001/pics" + picture.ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(60, "style", "height: 400px; width: inherit;");
            __builder.AddAttribute(61, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                }
                p++;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
             for (int i = 0; i < 3 - productDto.Product.Pictures.Count(); i++)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col-md-4");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.AddAttribute(66, "style", "border: 1px solid black; border-radius: 15px; padding: 15px;");
            __builder.OpenElement(67, "label");
            __builder.AddContent(68, 
#nullable restore
#line 49 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                p

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(69, ". Resim");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "row text-center");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "col-md-12");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(75);
            __builder.AddAttribute(76, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                     (e)=>HandleSelectedFile(e)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                p++;
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "row");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "form-group col-md-12");
            __builder.AddMarkupContent(82, "<label>Açıklama</label>\r\n                ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "text");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "required");
            __builder.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                     productDto.Product.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productDto.Product.Description = __value, productDto.Product.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "row");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col-md-4");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "form-group");
            __builder.AddMarkupContent(96, "<label>Üst Kategori: </label>\r\n                    ");
            __builder.OpenElement(97, "select");
            __builder.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                   productDto.Product.UpCategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productDto.Product.UpCategoryId = __value, productDto.Product.UpCategoryId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 72 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                         foreach (var upCategory in upCategories)
                        {
                            if (productDto.Product.UpCategoryId == upCategory.Id)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(100, "option");
            __builder.AddAttribute(101, "value", 
#nullable restore
#line 76 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                upCategory.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(102, "selected");
            __builder.AddContent(103, 
#nullable restore
#line 76 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                         upCategory.UpCategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 77 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(104, "option");
            __builder.AddAttribute(105, "value", 
#nullable restore
#line 80 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                upCategory.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(106, 
#nullable restore
#line 80 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                upCategory.UpCategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "col-md-4");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "form-group");
            __builder.AddMarkupContent(112, "<label>Alt Kategori: </label>\r\n                    ");
            __builder.OpenElement(113, "select");
            __builder.AddAttribute(114, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                   productDto.Product.DownCategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(115, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productDto.Product.DownCategoryId = __value, productDto.Product.DownCategoryId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 90 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                         foreach (var downCategory in downCategories)
                        {
                            if (downCategory.UpCategoryId == productDto.Product.UpCategoryId)
                            {
                                if (productDto.Product.DownCategoryId == downCategory.Id)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(116, "option");
            __builder.AddAttribute(117, "value", 
#nullable restore
#line 96 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                    downCategory.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(118, "selected");
            __builder.AddContent(119, 
#nullable restore
#line 96 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                               downCategory.DownCategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 97 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(120, "option");
            __builder.AddAttribute(121, "value", 
#nullable restore
#line 100 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                    downCategory.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(122, 
#nullable restore
#line 100 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                      downCategory.DownCategoryName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 101 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                }
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n            ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "col-md-4");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "form-group");
            __builder.AddMarkupContent(128, "<label>Markalar: </label>\r\n                    ");
            __builder.OpenElement(129, "select");
            __builder.AddAttribute(130, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 111 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                   productDto.Product.BrandId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(131, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => productDto.Product.BrandId = __value, productDto.Product.BrandId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 112 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                         foreach (var brand in brands)
                        {
                            if (productDto.Product.BrandId == brand.Id)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(132, "option");
            __builder.AddAttribute(133, "value", 
#nullable restore
#line 116 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                brand.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(134, "selected");
            __builder.AddContent(135, 
#nullable restore
#line 116 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                    brand.BrandName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 117 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(136, "option");
            __builder.AddAttribute(137, "value", 
#nullable restore
#line 120 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                brand.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(138, 
#nullable restore
#line 120 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                           brand.BrandName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 121 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n    ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "row justify-content-center");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "d-flex");
            __builder.OpenElement(144, "button");
            __builder.AddAttribute(145, "class", "btn btn-primary");
            __builder.AddAttribute(146, "style", "padding: 5px; margin: 0 15px;");
            __builder.AddAttribute(147, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 130 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                                            ()=>UpdateProductClicked(productDto)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(148, 
#nullable restore
#line 130 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                                                                                   YesText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n            ");
            __builder.OpenElement(150, "button");
            __builder.AddAttribute(151, "class", "btn btn-danger");
            __builder.AddAttribute(152, "style", "padding: 5px; margin: 0 15px;");
            __builder.AddAttribute(153, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 131 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                                            CancelClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(154, 
#nullable restore
#line 131 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
                                                                                                            CancelText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "C:\Users\Abdullah\Desktop\Bitirme Projesi\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateProductModalPopup.razor"
       
    [Parameter]
    public Product product { get; set; }
    [Parameter]
    public List<Brand> brands { get; set; }
    [Parameter]
    public List<UpCategory> upCategories{ get; set; }
    [Parameter]
    public List<DownCategory> downCategories { get; set; }
    [Inject]
    IProductService _productService { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }
    [Inject]
    IIdentityService _identityService { get; set; }

    ProductDTO productDto = new ProductDTO();
    bool isLoggedIn = false;

    public int pictureCount = 3;

    public override Task SetParametersAsync(ParameterView parameters)
    {
        Message = parameters.GetValueOrDefault<string>("Message") ?? "No Message Found";
        YesText = "Güncelle";
        CancelText = "Kapat";
        return base.SetParametersAsync(parameters);
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
    protected override void OnInitialized()
    {
        AccessControl();
        productDto.Product = product;
        productDto.ProductImageFiles = new List<byte[]>();
        pictureCount = pictureCount - product.Pictures.Count();
        base.OnInitialized();
    }

    private async Task HandleSelectedFile(InputFileChangeEventArgs e)
    {
        try
        {
            if ( productDto.ProductImageFiles.Count < pictureCount)
            {
                var productFileImage = await GetFileBytesAsync(e.File);
                productDto.ProductImageFiles.Add(productFileImage);
            }
        }
        catch (Exception)
        {

            throw;
        }
    }
    private async Task<byte[]> GetFileBytesAsync(IBrowserFile formFile)
    {
        try
        {
            var buffer = new byte[16 * 1024]; // 16KB'lık bir buffer tanımlıyoruz.
            using (var ms = new MemoryStream())
            {
                var stream = formFile.OpenReadStream();
                int read;
                while ((read = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    await ms.WriteAsync(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
