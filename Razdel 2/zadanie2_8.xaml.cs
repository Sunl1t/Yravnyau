using static System.Runtime.InteropServices.JavaScript.JSType;

using Yravnyai.Razdel_2;
namespace Yravnyai.Razdel_2;
public partial class zadanie2_8 : ContentPage
{
	public zadanie2_8()
	{
        InitializeComponent();
        Title = "Задание 8";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack1;
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    protected internal void DisplayStack7()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;

    }
    /*private async void GoToForward7(object sender, EventArgs e)
    {
        zadanie2_9 page = new zadanie2_9();
        await Navigation.PushAsync(page);
        page.DisplayStack8();
    }*/
    private async void GoToBack1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((ThirdFloor)navPage.CurrentPage).DisplayStack();
    }

    private void ButtonClick1(object sender, EventArgs e)
    {
    //    if ((koef1.Text == "2") & (koef2.Text == "3") & (koef3.Text == "2") & (koef4.Text == "2"))
    //    {
    //        ErrorB.TextColor = Colors.Green;
    //        ErrorB.Text = "Отлично, молодец!";
    //    }

    //    else
    //    {
    //        ErrorB.TextColor = Colors.Red;
    //        ErrorB.Text = "Неверные коэффициенты!";
    //    }
    }
}