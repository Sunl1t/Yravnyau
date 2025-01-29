using static System.Runtime.InteropServices.JavaScript.JSType;
using Yravnyai.Razdel_2;
namespace Yravnyai.Razdel_2;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie2_7 : ContentPage
{
	public zadanie2_7()
	{
        InitializeComponent();
        Title = "Задание 7";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack1;
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    protected internal void DisplayStack6()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;

    }
    private async void GoToForward6(object sender, EventArgs e)
    {
        zadanie2_8 page = new zadanie2_8();
        await Navigation.PushAsync(page);
        page.DisplayStack7();
    }
    private async void GoToBack1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((ThirdFloor)navPage.CurrentPage).DisplayStack();
    }

    private void ButtonClick1(object sender, EventArgs e)
    {
        //if ((string.IsNullOrEmpty(koef1.Text) | (koef1.Text == "1")) & (koef2.Text == "3") & (koef3.Text == "2") & (koef4.Text == "2"))
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