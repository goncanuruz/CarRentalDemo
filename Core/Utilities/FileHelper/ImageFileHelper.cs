
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
    public class ImageFileHelper
    {
        private static string _directory=Environment.CurrentDirectory;
        private static string _folderName = "\\images\\";
        public static IResult Upload(IFormFile file)
        {
            var fileExtension = Path.GetExtension(file.FileName);
            var name = Guid.NewGuid().ToString();

            using (FileStream fileStream=File.Create(_directory+_folderName+name+fileExtension))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            return new SuccessResult((_folderName+name+fileExtension).Replace("\\", "/"));
        }
    }
    
}
