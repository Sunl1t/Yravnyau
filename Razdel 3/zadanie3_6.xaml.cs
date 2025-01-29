namespace Yravnyai.Razdel_3;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie3_6 : ContentPage
{
	public zadanie3_6()
	{
        InitializeComponent();
        Title = "Задание 6";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack5;
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    protected internal void DisplayStack5()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;

    }
    private async void GoToForward5(object sender, EventArgs e)
    {
        zadanie3_7 page = new zadanie3_7();
        await Navigation.PushAsync(page);
        page.DisplayStack6();
    }
    private async void GoToBack5(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((FourthFloor)navPage.CurrentPage).DisplayStack1();
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        //if ((koef1.Text == "2") & (koef3.Text == "2") & (string.IsNullOrEmpty(koef2.Text) | (koef2.Text == "1")))
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