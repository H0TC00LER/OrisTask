using Domain.Enums;

namespace Services.Contracts
{
    public interface IImageService
    {
        public byte[] GetImageById(ImageType imageType, string id);
    }
}
