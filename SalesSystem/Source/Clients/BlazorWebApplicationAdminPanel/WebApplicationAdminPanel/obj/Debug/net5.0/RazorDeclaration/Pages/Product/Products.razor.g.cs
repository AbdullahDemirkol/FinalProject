// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplicationAdminPanel.Pages.Product
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Business.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.Basket.Buyer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Entity.Concrete.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Infrastructer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using WebApplicationAdminPanel.Pages.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Http.Internal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Product\Products.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 185 "C:\Users\Abdullah\Desktop\asdas\FinalProject\SalesSystem\Source\Clients\BlazorWebApplicationAdminPanel\WebApplicationAdminPanel\Pages\Product\Products.razor"
       

    [CascadingParameter]
    IModalService Modal { get; set; }
    [Inject]
    StateManager stateManager { get; set; }
    [Inject]
    ModalManager modalManager { get; set; }
    [Inject]
    IProductService _productService { get; set; }
    [Inject]
    IIdentityService _identityService { get; set; }
    [Inject]
    NavigationManager navigationManager { get; set; }
    PaginatedViewModel<Product> _products = new PaginatedViewModel<Product>();
    List<UpCategory> _upCategories = new List<UpCategory>();
    List<DownCategory> _downCategories = new List<DownCategory>();
    List<Brand> _brands = new List<Brand>();
    Product newProduct = new Product();
    List<IBrowserFile> formFiles = new List<IBrowserFile>();
    private int CurPage = 1;
    bool isLoggedIn = false;
    protected void Pagination(int page)
    {
        CurPage = page + 1;
        GetProducts(page);
    }
    protected void NextPage()
    {
        int MaxPage = Convert.ToInt32(Math.Round(Convert.ToDouble(_products.Count / 3)) + 1);
        if (CurPage < MaxPage)
        {
            CurPage++;
            GetProducts(CurPage - 1);
        }
    }
    protected void PrevPage()
    {
        if (CurPage > 1)
        {
            CurPage--;
            GetProducts(CurPage - 1);
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
    protected override void OnInitialized()
    {
        AccessControl();
        GetUpCategory();
        GetDownCategory();
        GetBrand();
        GetProducts(0);

    }
    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
        }
    }
    protected async void GetProducts(int paginationNumber, int pageSize = 6)
    {
        _products = await _productService.GetProductsItem(paginationNumber, pageSize);
        stateManager.UpdateContent(this, "productPage");
    }
    protected async void GetUpCategory()
    {
        _upCategories = await _productService.GetUpCategoryItems();
    }

    protected async void GetDownCategory()
    {
        _downCategories = await _productService.GetDownCategoryItems();
    }

    protected async void GetBrand()
    {
        _brands = await _productService.GetBrandItems();
    }
    private async Task StateManager_StateChanged(ComponentBase component, string property)
    {
        if (property == "productPage")
        {
            await InvokeAsync(StateHasChanged);
        }
    }
    private void OnPriceChanged(string value)
    {
        decimal.TryParse(value, out decimal price);
        if (price != 0)
        {
            newProduct.Price = price;
        }
    }
    private void HandleSelectedFile(InputFileChangeEventArgs e)
    {
        if (!formFiles.Contains(e.File) && formFiles.Count < 3)
        {
            formFiles.Add(e.File);
        }
    }
    private async Task UpdateProduct(Product product)
    {
        var isUpdate = await modalManager.UpdateProductAsync("Ürün Güncelle", product, _brands, _upCategories, _downCategories);
        if (isUpdate != null)
        {
            var result = await _productService.UpdateProductItem(isUpdate);
            modalManager.ShowMessageAsync("Bilgilendirme", result, 2000);
        }
        GetProducts(CurPage - 1);
    }
    private void ShowProduct(Product product)
    {
        modalManager.ShowProductItem("Bilgilendirme",product);
    }
    protected void ClearNewProduct()
    {
        formFiles = new List<IBrowserFile>();
        newProduct = new Product();
    }
    protected async void DeleteProduct(int id)
    {
        var result = await _productService.RemoveProductItem(id);
        if (result.Contains("silindi"))
        {
            //pop-up gösterilicek
            GetProducts(CurPage - 1);
        }
    }
    protected async void AddNewProduct()
    {
        if (newProduct.UpCategoryId == 0)
        {
            newProduct.UpCategoryId = 1;
        }
        if (newProduct.DownCategoryId == 0)
        {
            newProduct.DownCategoryId = 1;
        }
        if (newProduct.BrandId == 0)
        {
            newProduct.BrandId = 1;
        }
        var result= await _productService.AddProductItem(newProduct, formFiles);
        if (result== "Ürün Eklenildi.")
        {
            formFiles = new List<IBrowserFile>();
            newProduct = new Product();
            GetProducts(CurPage-1);
            //pop-up gösterilicek
        }


    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
