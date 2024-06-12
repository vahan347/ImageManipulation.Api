namespace ImageManipulation.Api.Models
{
    public class Image
    {
        public string Name { get; set; }

        public string Extension { get; set; }

        public int Size { get; set; }

        public int Radius { get; set; }

        public int Blur { get; set; }

        public string Effect { get; set; }
    }
}
