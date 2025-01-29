namespace Yravnyai.Razdel_1;

public partial class zadanie1_1 : ContentPage
{
	public zadanie1_1()
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
    private async void GoToForward1(object sender, EventArgs e)
    {
        zadanie1_2 page = new zadanie1_2();
        await Navigation.PushAsync(page);
        page.DisplayStack1();
    }

    private async void GoToBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((SecondFloor)navPage.CurrentPage).DisplayStack();
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        if ((string.IsNullOrEmpty(koef1.Text) || (koef1.Text == "1")) & (koef2.Text == "2") & (string.IsNullOrEmpty(koef3.Text) || (koef3.Text == "1")) & (koef4.Text == "2")) //понадобится, когда буду прописывать пустые коэфы
        {
            ErrorA.TextColor = Colors.Green;
            ErrorA.Text = "Отлично, молодец!";
        }

        else
        {
            ErrorA.TextColor = Colors.Red;
            ErrorA.Text = "Неверные коэффициенты!";

        }
    }
}