using System.Reflection;

namespace Yravnyai
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            Routing.RegisterRoute("registration", typeof(RegistrationPage));

            Image embeddedImage = new()
            {
                Source = ImageSource.FromResource("himiya.pic11.jpg", typeof(MainPage).GetTypeInfo().Assembly)
            };
            /*NavigationPage navPage1 = new NavigationPage(new Basilisk());
            navPage1.IconImageSource = "Razdel_1_bely.png";
            navPage1.Title = "Новости";

            Children.Add(navPage2);
            Children.Add(navPage3);
            Children.Add(navPage4);
            Children.Add(navPage5);  полная залупа а не метод из-за которого я чуть не начал переписывать прилоежние*/
        }

    }
    //[ContentProperty(nameof(Source))]
    //public class ImageResourceExtension : IMarkupExtension
    //{
    //    public string Source { get; set; }

    //    public object ProvideValue(IServiceProvider serviceProvider)
    //    {
    //        if (Source == null)
    //        {
    //            return 0;
    //        }
    //        var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

    //        return imageSource;
    //    }
    //}

}
