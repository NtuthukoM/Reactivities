using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Reactivities.Application.Interfaces;
using Reactivities.Application.Photos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Photos
{
    public class PhotoAccessor : IPhotoAccessor
    {
        private readonly Cloudinary cloudinary;
        public PhotoAccessor(IOptions<CloudinarySettings> options)
        {
            var account = new Account(
                  options.Value.CloudName,
                  options.Value.ApiKey,
                  options.Value.ApiSecret);
            cloudinary = new Cloudinary(account);

        }
        public async Task<PhotoUploadResult> AddPhoto(IFormFile file)
        {
            if(file.Length > 0)
            {
                await using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    Transformation = new Transformation()
                        .Width(500).Height(500).Crop("fill")
                };
                var uploadResult = await cloudinary.UploadAsync(uploadParams);
                if(uploadResult.Error != null)
                {
                    throw new Exception(uploadResult.Error.Message);
                }

                return new PhotoUploadResult
                {
                    PublicId = uploadResult.PublicId,
                    Url = uploadResult.SecureUrl.ToString()
                };
            }
            return null;
        }

        public async Task<string> DeletePhoto(string publicId)
        {
            var deleteParams = new DeletionParams(publicId);
            var result = await cloudinary.DestroyAsync(deleteParams);
            if(result.Result == "ok")
            {
                return result.Result;
            }else
            {
                return null;
            }
        }
    }
}
