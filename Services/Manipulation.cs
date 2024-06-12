using ImageManipulation.Api.Models;

namespace ImageManipulation.Api.Services
{
    public class Manipulation : IManipulation<Image>
    {
        public Image Resize(Image image)
        {
            image.Size = 100;
            return image;
        }

        public Image Blur(Image image)
        {
            image.Blur = 5;
            return image;
        }

        public Image ApplyEffect(Image image)
        {
            image.Effect = "Grayscale";
            return image;
        }
    }
}
