using IdentityCheckServiceApi.DataAccess;
using IdentityCheckServiceApi.Entity.Concrete;
using IdentityCheckServiceApi.Helper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Utilities
{
    public static class PictureManagement
    {
        public static string Add(IFormFile file, UserModel userModel)
        {
            var imageMessage = FileHelper.AddPicture(file, userModel.ProfileImagePath);
            if (imageMessage == "Dosya bulunamadı." || imageMessage == "Yanlış dosya tipi.")
            {
                return imageMessage;
            }
            userModel.ProfileImagePath = imageMessage;

            return "Kullanıcı Resimi Eklenildi.";
        }
        public static string Update(IFormFile file, string profileImagePath)
        {
            var imageMessage = FileHelper.AddPicture(file, profileImagePath);
            if (imageMessage == "Dosya bulunamadı." || imageMessage == "Yanlış dosya tipi.")
            {
                return imageMessage;
            }
            return imageMessage;
        }

        public static string Remove(string userName, IdentityCheckContext identityContext)
        {
            var user = identityContext.Users.FirstOrDefault(c => c.Username == userName);
            if (user != null)
            {
                FileHelper.DeletePicture(user.ProfileImagePath);
                return "Ürün Resimi Silindi.";
            }
            return "Ürün Bulunamadı.";

        }
    }
}
