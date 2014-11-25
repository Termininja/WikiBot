namespace Wiki.Core.Models.TaxoBox
{
    using System.Text;

    public class Image
    {
        private string Link { get; set; }

        private string ImageCaption { get; set; }

        private string Link2 { get; set; }

        private string Image2Caption { get; set; }

        public Image(string link)
        {
            this.Link = link;
        }

        public Image(string link, string imageCaption)
            : this(link)
        {
            this.ImageCaption = imageCaption;
        }

        public Image(string link, string imageCaption, string link2)
            : this(link, imageCaption)
        {
            this.Link2 = link2;
        }

        public Image(string link, string imageCaption, string link2, string image2Caption)
            : this(link, imageCaption, link2)
        {
            this.Image2Caption = image2Caption;
        }

        public override string ToString()
        {
            StringBuilder image = new StringBuilder();
            if (this.Link != null) image.AppendLine("| image = " + this.Link);
            if (this.ImageCaption != null) image.AppendLine("| image_caption = " + this.ImageCaption);
            if (this.Link2 != null) image.AppendLine("| image2 = " + this.Link2);
            if (this.Image2Caption != null) image.AppendLine("| image2_caption = " + this.Image2Caption);

            return image.ToString();
        }
    }
}
