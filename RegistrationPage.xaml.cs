namespace Yravnyai;

public partial class RegistrationPage : ContentPage
{
    public RegistrationPage()
	{
		InitializeComponent();
	}
    private async void To_LoginPage(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}