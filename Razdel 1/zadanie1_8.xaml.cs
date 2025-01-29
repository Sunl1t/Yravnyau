using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Yravnyai.Razdel_1;

public partial class zadanie1_8 : ContentPage
{
	public zadanie1_8()
	{
		InitializeComponent();
        Title = "Задание 8";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack8;
    }
    /*private async void GoToForward8(object sender, EventArgs e)
    {
        zadanie1_8 page = new zadanie1_8();
        await Navigation.PushAsync(page);
        page.DisplayStack7();
    }*/

        protected internal void DisplayStack7()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    private async void GoToBack8(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((SecondFloor)navPage.CurrentPage).DisplayStack();
    }

    /*async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }*/
    private void ButtonClick8(object sender, EventArgs e)
    {
        if ((koef1.Text == "2") & (koef2.Text == "3") & (koef3.Text == "2") & (koef4.Text == "2"))
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