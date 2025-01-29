namespace Yravnyai.Razdel_3;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie3_3 : ContentPage
{
	public zadanie3_3()
	{
        InitializeComponent();
        Title = "Задание 3";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack2;
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    protected internal void DisplayStack2()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;

    }
    private async void GoToForward2(object sender, EventArgs e)
    {
        zadanie3_4 page = new zadanie3_4();
        await Navigation.PushAsync(page);
        page.DisplayStack3();
    }
    private async void GoToBack2(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((FourthFloor)navPage.CurrentPage).DisplayStack1();
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        //if ((koef1.Text == "2") & (koef2.Text == "2") & (string.IsNullOrEmpty(koef3.Text) | (koef3.Text == "1")))
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