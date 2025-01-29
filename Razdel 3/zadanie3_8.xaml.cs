namespace Yravnyai.Razdel_3;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie3_8 : ContentPage
{
	public zadanie3_8()
	{
        InitializeComponent();
        Title = "Задание 8";
        Button backBtn = new Button { Text = "Назад" };
        backBtn.Clicked += GoToBack7;
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
        zadanie666 page = new zadanie666();
        await Navigation.PushAsync(page);
        page.DisplayStack5();
    }*/
    private async void GoToBack7(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((FourthFloor)navPage.CurrentPage).DisplayStack1();
    }

    private void ButtonClick(object sender, EventArgs e)
    {
        //if ((koef1.Text == "2") & (koef2.Text == "3") & (koef3.Text == "2") & (koef4.Text == "2"))
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