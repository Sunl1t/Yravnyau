namespace Yravnyai.Razdel_3;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie3_7 : ContentPage
{
	public zadanie3_7()
	{
        InitializeComponent();
        Title = "Задание 7";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack6;
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
        zadanie3_8 page = new zadanie3_8();
        await Navigation.PushAsync(page);
        page.DisplayStack7();
    }
    private async void GoToBack6(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((FourthFloor)navPage.CurrentPage).DisplayStack1();
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        //if ((koef1.Text == "2") & (koef3.Text == "4") & (koef2.Text == "5") & (koef4.Text == "2"))
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