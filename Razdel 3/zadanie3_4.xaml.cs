namespace Yravnyai.Razdel_3;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class zadanie3_4 : ContentPage
{
	public zadanie3_4()
	{
        InitializeComponent();
        Title = "������� 4";
        Button backBtn = new Button { Text = "�����" };
        backBtn.Clicked += GoToBack3;
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
        zadanie3_5 page = new zadanie3_5();
        await Navigation.PushAsync(page);
        page.DisplayStack4();
    }
    private async void GoToBack3(object sender, EventArgs e)
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
        //    ErrorB.Text = "�������, �������!";
        //}

        //else
        //{
        //    ErrorB.TextColor = Colors.Red;
        //    ErrorB.Text = "�������� ������������!";

        //}
    }
}