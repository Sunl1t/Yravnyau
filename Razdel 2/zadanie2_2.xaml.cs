using static System.Runtime.InteropServices.JavaScript.JSType;
using Yravnyai.Razdel_2;
namespace Yravnyai.Razdel_2;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie2_2 : ContentPage
{
	public zadanie2_2()
	{
        InitializeComponent();
        Title = "Задание 2";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack1;
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    protected internal void DisplayStack1()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;

    }

    private async void GoToBack1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((ThirdFloor)navPage.CurrentPage).DisplayStack();
    }
    private async void GoToForward1(object sender, EventArgs e)
    {
        zadanie2_3 page = new zadanie2_3();
        await Navigation.PushAsync(page);
        page.DisplayStack2();
    }
    private void ButtonClick1(object sender, EventArgs e)
    {
        //if ((koef1.Text == "3") & (koef2.Text == "2") & (string.IsNullOrEmpty(koef3.Text) | (koef3.Text == "1")) & (koef4.Text == "3") & (koef5.Text == "2") & (koef6.Text == "2"))
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