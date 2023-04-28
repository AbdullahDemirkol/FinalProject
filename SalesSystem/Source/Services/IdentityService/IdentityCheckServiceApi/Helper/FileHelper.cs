using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCheckServiceApi.Helper
{
    public class FileHelper
    {
        private static string _currentDirectory = Environment.CurrentDirectory + "\\Pics";
        private static string _folderName = "\\images\\";

        public FileHelper()
        {
            CheckDirectory(_currentDirectory + _folderName);
        }


        public static string AddPicture(IFormFile file, string imagePath)
        {

            var checkFileControl = CheckIfFile(file);
            if (checkFileControl != string.Empty)
            {
                return checkFileControl;
            }

            var type = Path.GetExtension(file.FileName);
            var checkTypeControl = CheckIfFileType(type);
            if (checkTypeControl != string.Empty)
            {
                return checkTypeControl;
            }
            if (!string.IsNullOrEmpty(imagePath))
            {
                DeleteFile((_currentDirectory + imagePath).Replace("/", "\\"));
            }

            var randomName = Guid.NewGuid().ToString();
            CheckDirectory(_currentDirectory + _folderName);
            CreateFile(_currentDirectory + _folderName + randomName + type, file);
            return (_folderName + randomName + type);
        }

        public static string DeletePicture(string imagePath)
        {
            DeleteFile((_currentDirectory + imagePath).Replace("/", "\\"));
            return "Silme işlemi gerçekleşti.";
        }
        private static string CheckIfFile(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                return string.Empty;
            }
            return "Dosya bulunamadı.";
        }
        private static string CheckIfFileType(string type)
        {
            if (type != ".jpg" && type != ".jpeg" && type != ".png")
            {
                return "Yanlış dosya tipi.";
            }
            return string.Empty;
        }

        private static void CheckDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        private static void CreateFile(string directory, IFormFile file)
        {
            try
            {
                using (FileStream fs = File.Create(directory))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
            }
            catch (Exception e)
            {
                var sdas = e.Message;
                throw;
            }
        }
        private static void DeleteFile(string directory)
        {
            if (File.Exists(directory.Replace("/", "\\")))
            {
                File.Delete(directory.Replace("/", "\\"));
            }
        }
    }
}
