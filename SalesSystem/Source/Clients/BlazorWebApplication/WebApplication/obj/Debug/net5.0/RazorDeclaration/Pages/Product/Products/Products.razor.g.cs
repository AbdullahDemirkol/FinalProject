// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication.Pages.Product.Products
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/{search}")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 239 "C:\Users\Abdullah\Desktop\Yeni klasör (5)\FinalProject\SalesSystem\Source\Clients\BlazorWebApplication\WebApplication\Pages\Product\Products\Products.razor"
       
    [Parameter]
    public string search { get; set; } = string.Empty;
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


    List<UpCategory> upCategories = new List<UpCategory>();
    List<DownCategory> downCategories = new List<DownCategory>();
    List<Brand> brands = new List<Brand>();

    private int CurPage = 1;
    private int CurDownCategoryId = 0;
    private int CurUpCategoryId = 0;
    private int CurBrandId = 0;

    bool isSuccess { get; set; }
    string message { get; set; }
    bool showNotification { get; set; } = false;

    int selectedUpCategoryId;
    int selectedDownCategoryId;
    int selectedBrandId;

    bool changeSearch = false;

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
        //var jsInProcess = (IJSInProcessRuntime)JSRuntime;
        //myScript = jsInProcess.Invoke<IJSObjectReference>("import", navigationManager.BaseUri + "assets/js/main.js");
        //var uri = navigationManager.ToAbsoluteUri(navigationManager.Uri);
        //var queryStrings = QueryHelpers.ParseQuery(uri.Query);
        //if (queryStrings.TryGetValue("upCategory", out var upCategory))
        //{
        //    _upCategory = Convert.ToInt32(upCategory);
        //}

        //if (queryStrings.TryGetValue("downCategory", out var downCategory))
        //{
        //    _downCategory = Convert.ToInt32(downCategory);
        //}

        //if (queryStrings.TryGetValue("brand", out var brand))
        //{
        //    _brand = Convert.ToInt32(brand);
        //}
        //if (queryStrings.TryGetValue("reload", out var reload))
        //{
        //    _reload = Convert.ToInt32(reload);
        //}

        AccessControl();
        upCategories = await productService.GetUpCategoryItems();
        downCategories = await productService.GetDownCategoryItems();
        brands = await productService.GetBrandItems();
        if (!string.IsNullOrEmpty(search))
        {
            SearchProducts(CurPage - 1);
        }
        else
        {
            await GetProductsDataAsync(CurPage - 1, CurUpCategoryId, CurDownCategoryId, CurBrandId);
        }
    }

    //protected async override Task OnAfterRenderAsync(bool firstRender)
    //{
    //    if (firstRender)
    //    {
    //        await jsRuntime.InvokeVoidAsync("myFunction");
    //    }
    //}
    protected async override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("myFunction");
            stateManager.StateChanged += async (source, property) => await StateManager_StateChanged(source, property);
        }
    }
    //------------------------------------------------------------------------------------------------------------------------
    IEnumerable<Product> _products { get; set; } = new List<Product>();
    int _productCount { get; set; }

    //private async Task GetProductsAsync(int page, UpCategory upCategory = null, DownCategory downCategory = null, Brand brand = null)
    //{
    //    CurUpCategory = null;
    //    CurDownCategory = null;
    //    CurBrand = null;
    //    if (upCategory != null)
    //    {
    //        CurUpCategory = upCategory;
    //        CurPage = 1;
    //    }
    //    if (downCategory != null)
    //    {
    //        CurDownCategory = downCategory;
    //        CurPage = 1;
    //    }
    //    if (brand != null)
    //    {
    //        CurBrand = brand;
    //        CurPage = 1;
    //    }
    //    var inComingProducts = await GetProductsDataAsync(page, CurUpCategory, CurDownCategory, CurBrand);

    //    _products = inComingProducts.Data;
    //    _productCount = inComingProducts.Count;
    //    stateManager.UpdateContent(this, "ProductPage");

    //}
    private async void FilterProduct()
    {
        CurUpCategoryId = selectedUpCategoryId;
        CurDownCategoryId = selectedDownCategoryId;
        CurBrandId = selectedBrandId;
        await GetProductsDataAsync(0, CurUpCategoryId, CurDownCategoryId, CurBrandId);
        if (!string.IsNullOrEmpty(search))
        {
            search = string.Empty;
            CurPage = 1;
        }
        navigationManager.NavigateTo("/Product");
    }
    private async void SearchProducts(int page)
    {
        var inComingProducts = await productService.GetSearchProductsItem(page, search);
        _products = inComingProducts.Data;
        _productCount = inComingProducts.Count;
        stateManager.UpdateContent(this, "ProductPage");
    }
    private async Task GetProductsDataAsync(int page, int upCategoryId, int downCategoryId, int brandId)
    {
        var inComingProducts = await productService.GetProductsItem(page, upCategoryId, downCategoryId, brandId, null);

        _products = inComingProducts.Data;
        _productCount = inComingProducts.Count;
        stateManager.UpdateContent(this, "ProductPage");
        //return await productService.GetProductsItem(page, upCategoryId, downCategoryId, brandId,null);
    }
    //private async Task<PaginatedViewModel<Product>> GetProductsDataAsync(int page, UpCategory upCategory = null, DownCategory downCategory = null, Brand brand = null)
    //{

    //    if (upCategory != null && downCategory == null && brand == null)
    //    {
    //        return await productService.GetProductItemByUpCategories(upCategory, page, null);
    //    }
    //    if (upCategory == null && downCategory != null && brand == null)
    //    {
    //        return await productService.GetProductItemByDownCategories(downCategory, page, null);
    //    }
    //    if (upCategory == null && downCategory == null && brand != null)
    //    {
    //        return await productService.GetProductItemByBrands(brand, page, null);
    //    }
    //    return await productService.GetProductsItem(page, null);
    //}
    private async void Pagination(int page)
    {
        CurPage = page + 1;
        if (changeSearch)
        {
            CurPage = 1;
            changeSearch = false;
        }
        if (!string.IsNullOrEmpty(search))
        {
            SearchProducts(page);
        }
        else
        {
            await GetProductsDataAsync(page, CurUpCategoryId, CurDownCategoryId, CurBrandId);
        }

        //await GetProductsAsync(page, CurUpCategory, CurDownCategory, CurBrand);
    }
    //------------------------------------------------------------------------------------------------------------------------
    private async Task StateManager_StateChanged(ComponentBase component, string property)
    {
        if (property == "ProductPage")
        {
            await InvokeAsync(StateHasChanged);
        }

    }

    public async Task AddToCart(Product product)
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
        stateManager.UpdateContent(this, "ProductPage");

        // 2 saniye sonra bildirimi kaldır
        await Task.Delay(2000).ContinueWith(t =>
        {
            isSuccess = false;
            message = "";
            showNotification = false;
            stateManager.UpdateContent(this, "ProductPage");
        });


    }


    protected async Task NextPage()
    {
        int MaxPage = Convert.ToInt32(Math.Round(Convert.ToDouble(_productCount / 6)) + 1);
        if (CurPage < MaxPage)
        {

            CurPage++;
            await GetProductsDataAsync(CurPage - 1, CurUpCategoryId, CurDownCategoryId, CurBrandId);
        }
    }
    protected async Task PrevPage()
    {
        if (CurPage > 1)
        {
            CurPage--;
            await GetProductsDataAsync(CurPage - 1, CurUpCategoryId, CurDownCategoryId, CurBrandId);
        }
    }
    private void OptionUpCategorySelected(ChangeEventArgs e)
    {
        selectedUpCategoryId = Convert.ToInt32(e.Value);
        selectedDownCategoryId = 0;
    }
    private void OptionDownCategorySelected(ChangeEventArgs e)
    {
        selectedDownCategoryId = Convert.ToInt32(e.Value);
        if (selectedDownCategoryId != 0)
        {
            selectedUpCategoryId = downCategories.FirstOrDefault(p => p.Id == selectedDownCategoryId).UpCategoryId;
        }
    }
    private void OptionBrandSelected(ChangeEventArgs e)
    {
        selectedBrandId = Convert.ToInt32(e.Value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
