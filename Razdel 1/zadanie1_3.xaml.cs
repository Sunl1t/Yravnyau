using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Yravnyai.Razdel_1;

public partial class zadanie1_3 : ContentPage
{
	public zadanie1_3()
	{
		InitializeComponent();
        Title = "Задание 3";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack;
    }
    private async void GoToForward3(object sender, EventArgs e)
    {
        zadanie1_4 page = new zadanie1_4();
        await Navigation.PushAsync(page);
        page.DisplayStack3();
    }

    protected internal void DisplayStack2()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    private async void GoToBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((SecondFloor)navPage.CurrentPage).DisplayStack1();
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        if ((string.IsNullOrEmpty(koef2.Text) | koef2.Text == "1") & koef1.Text == "2" & (string.IsNullOrEmpty(koef3.Text) | koef3.Text == "1") & (string.IsNullOrEmpty(koef4.Text) | koef4.Text == "1"))
        {
            ErrorB.TextColor = Colors.Green;
            ErrorB.Text = "Отлично, молодец!";
        }

        else
        {
            ErrorB.TextColor = Colors.Red;
            ErrorB.Text = "Неверные коэффициенты!";

        }
    }
}