using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using OLIVIEM.Models;
using System;

namespace Oliviem.Utils
{
    public class CloudinaryUtil
    {
        private Cloudinary _cloudinary;
       
        //public CloudinaryUtil()
        //{
        //    _cloudinary = new Cloudinary(new Account("knngvyen", "513856637581116", "A-taBdU89jvvT_YgRZ0k48UpxNs"));
        //}

        public Photo UploadPicture(string relativePath, string publicId)
        {
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(@relativePath),
                PublicId = publicId
            };

            var uploadResult = this._cloudinary.Upload(uploadParams);

            return new Photo() { Name = uploadResult.PublicId, Path = uploadResult.Uri.AbsoluteUri};
        }

     
    }
}
