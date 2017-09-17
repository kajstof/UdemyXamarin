using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace UdemyXamarin.MarkupExtensions
{
    class EmbeddedImage : IMarkupExtension<ImageSource>
    {
        [ContentProperty("ResourceId")]
        public string ResourceId { get; set; }
        public ImageSource ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResourceId))
                return null;
            return ImageSource.FromResource("UdemyXamarin.Images.background.jpg");
        }
    }
}