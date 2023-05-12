using Blazored.Modal;
using Blazored.Modal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAdminPanel.Business.Abstract;
using WebApplicationAdminPanel.Entity.Concrete.DTOs;
using WebApplicationAdminPanel.Entity.Concrete.Product;
using WebApplicationAdminPanel.Entity.Concrete.User;
using WebApplicationAdminPanel.Pages.Modal;

namespace WebApplicationAdminPanel.Utilities
{
    public class ModalManager
    {
        private readonly IModalService _modalService;
        private readonly IProductService _productService;

        public ModalManager(IModalService modalService, IProductService productService)
        {
            _modalService = modalService;
            _productService = productService;
        }
        public void ShowMessageAsync(string title,string message,int duration=0)
        {
            ModalParameters modalParameters = new ModalParameters();
            modalParameters.Add("Message", message);
            _modalService.Show<ShowMessagePopup>(title,modalParameters);
        }
        public async Task<bool> ConfirmationAsync(string title, string message)
        {

            ModalParameters modalParameters = new ModalParameters();
            modalParameters.Add("Message", message);

            var modalRef = _modalService.Show<ShowMessagePopup>(title, modalParameters);
            var modalResult= await modalRef.Result;

            return !modalResult.Cancelled;
        }
        public async Task<ProductDTO> UpdateProductAsync(string title,Product product,List<Brand> brands,List<UpCategory> upCategories,List<DownCategory> downCategories)
        {
            ModalParameters modalParameters = new ModalParameters();
            modalParameters.Add("product", product);
            modalParameters.Add("brands", brands);
            modalParameters.Add("upCategories", upCategories);
            modalParameters.Add("downCategories", downCategories);

            var modalRef = _modalService.Show<UpdateProductModalPopup>(title, modalParameters);
            var modalResult = await modalRef.Result;

            if (!modalResult.Cancelled)
            {
                try
                {
                    if (modalResult.Data is ValueTuple<string, int> removeProduct)
                    {
                        var result = await _productService.RemoveProductPicture(removeProduct.Item1, removeProduct.Item2);
                        if (result == "Ürün Resimi Silindi.")
                        {
                            var products = await _productService.GetProductItem(removeProduct.Item2);
                            product = products.First();
                            var productDto=await UpdateProductAsync("Ürünü Güncelle", product, brands, upCategories, downCategories);
                            return productDto;
                        }
                    }
                    else
                    {
                        var productDTO = modalResult.Data as ProductDTO;
                        if (productDTO != null)
                        {
                            return productDTO;
                        }
                    }
                }
                catch (Exception e)
                {
                    var p = e.Message;
                    return null;
                }
            }
            return null;
        }
        public async Task<(UserDTO, bool, string)> UpdateUserAsync(string title, UserDTO user, List<Role> roles)
        {
            ModalParameters modalParameters = new ModalParameters();
            modalParameters.Add("user", user);
            modalParameters.Add("roles", roles);

            var modalRef = _modalService.Show<UpdateUserModalPopup>(title, modalParameters);
            var modalResult = await modalRef.Result;

            if (!modalResult.Cancelled)
            {
                try
                {
                    if (modalResult.Data is bool reloadUser)
                    {
                        return (user, !reloadUser, null);
                    }
                    else
                    {
                        var (userDto, newPas) = ((UserDTO, string))modalResult.Data;
                        return (userDto, true, newPas);
                    }
                }
                catch (Exception)
                {
                    return (null, false, null);
                }
            }
            return (null, false, null);
        }

        public void ShowProductItem(string title,Product product)
        {
            ModalParameters modalParameters = new ModalParameters();
            modalParameters.Add("product", product);
            _modalService.Show<ShowProductItem>(title,modalParameters);
        }
        public void ShowUserItem(string title, User user)
        {
            ModalParameters modalParameters = new ModalParameters();
            modalParameters.Add("user", user);
            _modalService.Show<ShowUserItem>(title, modalParameters);
        }
    }
}
