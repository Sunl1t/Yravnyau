using static System.Runtime.InteropServices.JavaScript.JSType;
using Yravnyai.Razdel_2;
namespace Yravnyai.Razdel_2;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie2_4 : ContentPage
{
	public zadanie2_4()
	{
        InitializeComponent();
        Title = "������� 4";
        Button backBtn = new Button { Text = "�����" };
        backBtn.Clicked += GoToBack1;
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    protected internal void DisplayStack3()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;

    }
    private async void GoToForward3(object sender, EventArgs e)
    {
        zadanie2_5 page = new zadanie2_5();
        await Navigation.PushAsync(page);
        page.DisplayStack4();
    }
    private async void GoToBack1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((ThirdFloor)navPage.CurrentPage).DisplayStack();
    }

    private void ButtonClick1(object sender, EventArgs e)
    {
        //if ((koef1.Text == "2") & (string.IsNullOrEmpty(koef2.Text) | (koef2.Text == "1")) & (koef3.Text == "2"))
        //{
        //    ErrorB.TextColor = Colors.Green;
        //    ErrorB.Text = "�������, �������!";
        //}

        //else
        //{
        //    ErrorB.TextColor = Colors.Red;
        //    ErrorB.Text = "�������� ������������!";
        //}
    }
}