namespace Yravnyai.Razdel_3;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie3_2 : ContentPage
{
	public zadanie3_2()
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
    private async void GoToForward1(object sender, EventArgs e)
    {
        zadanie3_3 page = new zadanie3_3();
        await Navigation.PushAsync(page);
        page.DisplayStack2();
    }
    private async void GoToBack1(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((FourthFloor)navPage.CurrentPage).DisplayStack1();
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        //if ((koef1.Text == "2") & (koef2.Text == "41") & (koef3.Text == "28") & (koef4.Text == "26"))
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