using static System.Runtime.InteropServices.JavaScript.JSType;
using Yravnyai.Razdel_2;
namespace Yravnyai.Razdel_2;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie2_1 : ContentPage
{
	public zadanie2_1()
	{
        InitializeComponent();
        Title = "Задание 1";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack;
    }

    protected internal void DisplayStack()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;

    }
    private async void GoToForward(object sender, EventArgs e)
    {
        zadanie2_2 page = new zadanie2_2();
        await Navigation.PushAsync(page);
        page.DisplayStack1();
    }
    private async void GoToBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((ThirdFloor)navPage.CurrentPage).DisplayStack();
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        //if ((koef1.Text == "5") & (koef2.Text == "2") & (koef3.Text == "3") & (koef4.Text == "5") & (koef5.Text == "2") & (string.IsNullOrEmpty(koef6.Text) | koef6.Text == "1") & (koef7.Text == "3"))
        //{
        //    ErrorB.TextColor = Colors.Green;
        //    ErrorB.Text = "Отлично, молодец!";
        //}

        //else
        //{
        //    ErrorB.TextColor = Colors.Red;
        //    ErrorB.Text = "Неверные коэффициенты!";

        //    /*await DisplayAlert("Данные", "Ответ получен", "Отправить");*/ //вывод уведомления на экран если нужно будет добавить оповещение - задать asinc (in func)
        //}
    }
}