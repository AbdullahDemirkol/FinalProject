#pragma checksum "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48bfe220d103ba72eaa41b5b43024d01e2a9e505"
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
#line 1 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class UpdateUserModalPopup : BaseModal
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
            __builder.AddMarkupContent(10, "<label>Kullanıcı Adı</label>\r\n                    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "placeholder", "Kullanıcı Adı");
            __builder.AddAttribute(15, "required");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                         user.UserModel.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserModel.Username = __value, user.UserModel.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-md-6");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "<label>Şifre</label>\r\n                    ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "password");
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "value", "");
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                                    SetPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "placeholder", "Şifre");
            __builder.AddAttribute(30, "required");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-md-6");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group");
            __builder.AddMarkupContent(38, "<label>İsim</label>\r\n                    ");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "text");
            __builder.AddAttribute(41, "class", "form-control");
            __builder.AddAttribute(42, "placeholder", "İsim");
            __builder.AddAttribute(43, "required");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                         user.UserModel.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserModel.FirstName = __value, user.UserModel.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-md-6");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "form-group");
            __builder.AddMarkupContent(51, "<label>Soyisim</label>\r\n                    ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "class", "form-control");
            __builder.AddAttribute(55, "placeholder", "Soyisim");
            __builder.AddAttribute(56, "required");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                         user.UserModel.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserModel.LastName = __value, user.UserModel.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        <div class=\"row\"></div>\r\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "row");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col-md-6");
            __builder.AddAttribute(64, "style", "padding: 0;");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-md-12");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-group");
            __builder.AddMarkupContent(69, "<label>Email Adresi</label>\r\n                        ");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "email");
            __builder.AddAttribute(72, "class", "form-control");
            __builder.AddAttribute(73, "placeholder", "email@hotmail.com");
            __builder.AddAttribute(74, "required");
            __builder.AddAttribute(75, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                              user.UserModel.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserModel.Email = __value, user.UserModel.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-md-12");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "form-group");
            __builder.AddMarkupContent(82, "<label>Telefon Numarası</label>\r\n                        ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "type", "tel");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "placeholder", "00000000000");
            __builder.AddAttribute(87, "required");
            __builder.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                            user.UserModel.Phone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserModel.Phone = __value, user.UserModel.Phone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "col-md-6");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "form-group");
            __builder.AddMarkupContent(95, "<label>Rolü: </label>\r\n                        ");
            __builder.OpenElement(96, "select");
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                           (e)=>HandleSelectedOption(e)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 52 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                             foreach (var role in roles)
                            {
                                if (user.UserModel.Role.Id == role.Id)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(98, "option");
            __builder.AddAttribute(99, "value", 
#nullable restore
#line 56 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                    role.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(100, "selected");
            __builder.AddContent(101, 
#nullable restore
#line 56 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                       role.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(102, "option");
            __builder.AddAttribute(103, "value", 
#nullable restore
#line 60 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                    role.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(104, 
#nullable restore
#line 60 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                              role.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                }
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\r\n                ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "col-md-6");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "form-group");
            __builder.AddMarkupContent(110, "<label>Statü: </label>\r\n                        ");
            __builder.OpenElement(111, "select");
            __builder.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                           (e)=>HandleSelectedStatus(e)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 71 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                             if (user.UserModel.Status == true)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(113, "option");
            __builder.AddAttribute(114, "value", "true");
            __builder.AddAttribute(115, "selected");
            __builder.AddContent(116, "Aktif");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                                ");
            __builder.OpenElement(118, "option");
            __builder.AddAttribute(119, "value", "false");
            __builder.AddContent(120, "Pasif");
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(121, "option");
            __builder.AddAttribute(122, "value", "true");
            __builder.AddContent(123, "Aktif");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                                ");
            __builder.OpenElement(125, "option");
            __builder.AddAttribute(126, "value", "false");
            __builder.AddAttribute(127, "selected");
            __builder.AddContent(128, "Pasif");
            __builder.CloseElement();
#nullable restore
#line 80 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n            ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "col-md-6");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "form-group");
            __builder.AddAttribute(134, "style", "border: 1px solid black; border-radius: 15px; padding: 15px;");
#nullable restore
#line 87 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                     if (string.IsNullOrEmpty(user.UserModel.ProfileImagePath))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(135, "<div class=\"row\"><div class=\"col-md-6\"><label>Profil Resimi</label></div></div>\r\n                        ");
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "row text-center");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "col-md-12");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(140);
            __builder.AddAttribute(141, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                     (e) => HandleSelectedFile(e)

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 99 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "row");
            __builder.AddMarkupContent(144, "<div class=\"col-md-6\"><label>Profil Resimi</label></div>\r\n                            ");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "col-md-6 text-right");
            __builder.OpenElement(147, "button");
            __builder.AddAttribute(148, "class", "btn btn-danger");
            __builder.AddAttribute(149, "style", "margin-bottom: 10px;");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                                                      DeletePicture

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(151, "Resimi Sil");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                        ");
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "row text-center");
            __builder.OpenElement(155, "div");
            __builder.AddAttribute(156, "class", "col-md-12");
            __builder.AddAttribute(157, "style", "height: 250px; width: 450px;");
            __builder.OpenElement(158, "img");
            __builder.AddAttribute(159, "style", "width:fit-content; height: inherit");
            __builder.AddAttribute(160, "src", 
#nullable restore
#line 112 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                                       "http://localhost:5002/pics" + user.UserModel.ProfileImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 115 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n    ");
            __builder.OpenElement(162, "div");
            __builder.AddAttribute(163, "class", "modal-footer");
            __builder.OpenElement(164, "button");
            __builder.AddAttribute(165, "type", "button");
            __builder.AddAttribute(166, "class", "btn btn-secondary");
            __builder.AddAttribute(167, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                  ()=>CancelUser(isDeletePicture)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(168, "Kapat");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n        \r\n        ");
            __builder.OpenElement(170, "button");
            __builder.AddAttribute(171, "type", "submit");
            __builder.AddAttribute(172, "class", "btn btn-success");
            __builder.AddAttribute(173, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 123 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
                                                                ()=>UpdateUserClicked(user,newPassword)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(174, "Kullanıcıyı Güncelle");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "C:\Users\Abdullah\Desktop\Bitirme\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Modal\UpdateUserModalPopup.razor"
       
    [Parameter]
    public UserDTO user { get; set; }
    [Parameter]
    public List<Role> roles { get; set; }
    [Inject]
    StateManager stateManager { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }
    [Inject]
    IIdentityService _identityService { get; set; }

    bool isDeletePicture = false;
    string newPassword =string.Empty;
    bool isLoggedIn = false;

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
        if (user != null)
        {
            user.UserModel.Phone = '0' + user.UserModel.Phone.Replace(" ", "").Replace("(", "").Replace(")", "");
        }
    }
    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
        }
    }

    protected void DeletePicture()
    {
        user.UserModel.ProfileImagePath = "";
        stateManager.UpdateContent(this, "userPage");
        isDeletePicture = true;
    }
    private async Task StateManager_StateChanged(ComponentBase component, string property)
    {
        if (property == "userPage")
        {
            await InvokeAsync(StateHasChanged);
        }

    }

    private void HandleSelectedOption(ChangeEventArgs e)
    {
        int roleId=Convert.ToInt32(e.Value);
        user.UserModel.Role = roles.FirstOrDefault(p => p.Id == roleId);
    }
    private void HandleSelectedStatus(ChangeEventArgs e)
    {
        var userStatus = Convert.ToBoolean(e.Value);
        user.UserModel.Status = userStatus;
    }
    private async void HandleSelectedFile(InputFileChangeEventArgs e)
    {
        user.ProfilePicture = await GetFileBytesAsync(e.File);
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
    private void SetPassword(ChangeEventArgs e)
    {
        newPassword = e.Value.ToString();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
