using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Yravnyai.Razdel_1;

public partial class zadanie1_5 : ContentPage
{
	public zadanie1_5()
	{
		InitializeComponent();
        Title = "������� 5";
        Button backBtn = new Button { Text = "�����" };
        backBtn.Clicked += GoToBack;
    }
    private async void GoToForward5(object sender, EventArgs e)
    {
        zadanie1_6 page = new zadanie1_6();
        await Navigation.PushAsync(page);
        page.DisplayStack5();
    }

    protected internal void DisplayStack4()
    {
        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }

    private async void GoToBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
        ((SecondFloor)navPage.CurrentPage).DisplayStack();
    }
    async void GoToMenu(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
    private void ButtonClick5(object sender, EventArgs e)
    {
        if (koef1.Text == "4" & (koef2.Text == "5") & koef3.Text == "2") //�����������, ����� ���� ����������� ������ �����
        {
            ErrorA.TextColor = Colors.Green;
            ErrorA.Text = "�������, �������!";
        }

        else
        {
            ErrorA.TextColor = Colors.Red;
            ErrorA.Text = "�������� ������������!";

            /*await DisplayAlert("������", "����� �������", "���������");*/ //����� ����������� �� �����
        }
    }
}