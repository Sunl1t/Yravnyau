using static System.Runtime.InteropServices.JavaScript.JSType;
using Yravnyai.Razdel_2;
namespace Yravnyai.Razdel_2;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie2_5 : ContentPage
{
	public zadanie2_5()
	{
        InitializeComponent();
        Title = "Задание 5";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack1;
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    protected internal void DisplayStack4()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;

    }

    private async void GoToBack1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((ThirdFloor)navPage.CurrentPage).DisplayStack();
    }
    private async void GoToForward4(object sender, EventArgs e)
    {
        zadanie2_6 page = new zadanie2_6();
        await Navigation.PushAsync(page);
        page.DisplayStack5();
    }
    private void ButtonClick1(object sender, EventArgs e)
    {
        //if ((koef1.Text == "2") & (string.IsNullOrEmpty(koef2.Text) | (koef2.Text == "1")) & (koef3.Text == "2"))
        //{
        //    ErrorB.TextColor = Colors.Green;
        //    ErrorB.Text = "Отлично, молодец!";
        //}

        //else
        //{
        //    ErrorB.TextColor = Colors.Red;
        //    ErrorB.Text = "Неверные коэффициенты!";
        //}
    }
}