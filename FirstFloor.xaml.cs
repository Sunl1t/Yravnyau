namespace Yravnyai
{
public partial class FirstFloor : ContentPage
{
	public FirstFloor()
	{
            InitializeComponent();
	}

    private async void GoGoogle(object sender, EventArgs e)
        {
            Uri uri = new Uri("http://www.google.com");
            await Launcher.OpenAsync(uri);
        }
        private async void GoWiki(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://ru.wikipedia.org/wiki/Окислительно-восстановительные_реакции");
            await Launcher.OpenAsync(uri);
        }

    private async void GoFox(object sender, EventArgs e)
        {
            Uri uri = new Uri("https://foxford.ru/wiki/himiya/okislitelno-vosstanovitelnye-reaktsii?utm_referrer=https%3A%2F%2Fyandex.ru%2F");
            await Launcher.OpenAsync(uri);
        }
}
}