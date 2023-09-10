using Domain.Enums;
using Services.Contracts;

namespace Services.Implementations
{
    public class ImageService : IImageService
    {
        private readonly string _imageFolderPath;

        public ImageService(string imageFolderPath)
        {
            _imageFolderPath = imageFolderPath;
        }

        public byte[] GetImageById(ImageType imageType, string id)
        {
            string imagePath = Path.Combine(_imageFolderPath, imageType.ToString(), $"{id}.png");

            if (File.Exists(imagePath))
            {
                return File.ReadAllBytes(imagePath);
            }

            var defaultPath = Path.Combine(_imageFolderPath, imageType.ToString(), "default.png");
            return File.ReadAllBytes(defaultPath);
        }
    }
}
