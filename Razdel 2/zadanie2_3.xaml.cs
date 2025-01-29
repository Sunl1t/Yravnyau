using static System.Runtime.InteropServices.JavaScript.JSType;
using Yravnyai.Razdel_2;
namespace Yravnyai.Razdel_2;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie2_3 : ContentPage
{
	public zadanie2_3()
	{
        //InitializeComponent();
        Title = "Задание 3";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack1;
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    protected internal void DisplayStack2()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;

    }
    private async void GoToForward2(object sender, EventArgs e)
    {
        zadanie2_4 page = new zadanie2_4();
        await Navigation.PushAsync(page);
        page.DisplayStack3();
    }
    private async void GoToBack1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((ThirdFloor)navPage.CurrentPage).DisplayStack();
    }

    private void ButtonClick1(object sender, EventArgs e)
    {
        //if ((koef1.Text == "2") & (koef2.Text == "2") & (string.IsNullOrEmpty(koef3.Text) | (koef3.Text == "1")))
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