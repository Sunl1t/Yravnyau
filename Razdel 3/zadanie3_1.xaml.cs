namespace Yravnyai.Razdel_3;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie3_1 : ContentPage
{
	public zadanie3_1()
	{
        InitializeComponent();
        Title = "Задание 1";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack0;
    }
    private async void GoToForward0(object sender, EventArgs e)
    {
        zadanie3_2 page = new zadanie3_2();
        await Navigation.PushAsync(page);
        page.DisplayStack1();
    }
    protected internal void DisplayStack0()
    {
        _ = (NavigationPage)App.Current.MainPage;

    }

    private async void GoToBack0(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((FourthFloor)navPage.CurrentPage).DisplayStack0();
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        //if ((koef1.Text == "2") & (koef2.Text == "16") & (koef3.Text == "2") & (koef4.Text == "2") & (koef5.Text == "8") & (koef6.Text == "5"))
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