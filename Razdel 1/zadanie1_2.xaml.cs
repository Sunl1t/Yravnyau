namespace Yravnyai.Razdel_1;

public partial class zadanie1_2 : ContentPage
{
	public zadanie1_2()
	{
		InitializeComponent();
        Title = "������� 2";
        Button backBtn = new Button { Text = "�����" };
        backBtn.Clicked += GoToBack;
    }
    protected internal void DisplayStack1()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    private async void GoToBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((SecondFloor)navPage.CurrentPage).DisplayStack1();
    }

    private async void GoToForward2(object sender, EventArgs e)
    {
        zadanie1_3 page = new zadanie1_3();
        await Navigation.PushAsync(page);
        page.DisplayStack2();
    }

    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
    private void ButtonClick(object sender, EventArgs e)
    {
        if ((string.IsNullOrEmpty(koef2.Text) | koef2.Text == "1") & koef1.Text == "2" & (string.IsNullOrEmpty(koef3.Text) | koef3.Text == "1") & (string.IsNullOrEmpty(koef4.Text) | koef4.Text == "1"))
        {
            ErrorB.TextColor = Colors.Green;
            ErrorB.Text = "�������, �������!";
        }

        else
        {
            ErrorB.TextColor = Colors.Red;
            ErrorB.Text = "�������� ������������!";

        }
    }
}