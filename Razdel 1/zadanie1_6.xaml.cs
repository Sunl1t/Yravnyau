using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Yravnyai.Razdel_1;

public partial class zadanie1_6 : ContentPage
{
	public zadanie1_6()
	{
		InitializeComponent();
        Title = "Задание 6";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack;
    }
    protected internal void DisplayStack5()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }

    private async void GoToForward6(object sender, EventArgs e)
    {
        zadanie1_7 page = new zadanie1_7();
        await Navigation.PushAsync(page);
        page.DisplayStack6();
    }
    private async void GoToBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((SecondFloor)navPage.CurrentPage).DisplayStack();
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
    private void ButtonClick6(object sender, EventArgs e)
    {
        if ((koef1.Text == "4") & (string.IsNullOrEmpty(koef2.Text) || (koef2.Text == "1")) & (koef3.Text == "2"))
        {
            ErrorA.TextColor = Colors.Green;
            ErrorA.Text = "Отлично, молодец!";
        }

        else
        {
            ErrorA.TextColor = Colors.Red;
            ErrorA.Text = "Неверные коэффициенты!";

            /*await DisplayAlert("Данные", "Ответ получен", "Отправить");*/ //вывод уведомления на экран
        }
    }
}