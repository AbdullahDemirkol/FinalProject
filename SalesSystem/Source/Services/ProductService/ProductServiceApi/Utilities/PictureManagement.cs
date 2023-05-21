using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using ProductServiceApi.DataAccess;
using ProductServiceApi.Entity.Concrete;
using ProductServiceApi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Utilities
{
    public static class PictureManagement
    {
        public static async Task<(string, Picture)> Add(IFormFile file, Picture picture, ProductContext productContext)
        {
            var imageMessage = FileHelper.Add(file);
            if (imageMessage == "Dosya bulunamadı." || imageMessage == "Yanlış dosya tipi.")
            {
                return (imageMessage, picture);
            }
            picture.ImagePath = imageMessage;
            productContext.Pictures.Add(picture);
            await productContext.SaveChangesAsync();


            return ("Ürün Resimi Eklenildi.", picture);

        }

        public static async Task<string> Remove(int pictureId, int productId, ProductContext productContext)
        {
            var image = productContext.Pictures.FirstOrDefault(c => c.Id == pictureId && c.ProductId == productId);
            if (image != null)
            {
                FileHelper.Delete(image.ImagePath);
                productContext.Pictures.Remove(image);
                await productContext.SaveChangesAsync();
                return "Ürün Resimi Silindi.";
            }
            return "Ürün Bulunamadı.";

        }

        public static async Task<string> Update(IFormFile file, Picture picture, ProductContext productContext)
        {
            var Image = productContext.Pictures.FirstOrDefault(c => c.Id == picture.Id);
            if (Image != null)
            {
                var updatedFileMessage = FileHelper.Update(file, picture.ImagePath);
                if (updatedFileMessage == "Dosya bulunamadı." || updatedFileMessage == "Yanlış dosya tipi.")
                {
                    return updatedFileMessage;
                }
                picture.ImagePath = updatedFileMessage;
                productContext.Pictures.Update(picture);
                await productContext.SaveChangesAsync();
                return "Ürün Resimi Güncellenildi.";
            }
            return "Güncellenicek Ürün Resimi Bulunamadı.";
        }
    }
}
