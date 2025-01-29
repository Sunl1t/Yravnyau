namespace Yravnyai;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        //this.BindingContext = new LoginViewModel();
    }

    private async void Log_in(object sender, EventArgs e)
    {
        if (Navigation != null && Navigation.NavigationStack.Count() > 0)
        {
            var existingPages = Navigation.NavigationStack.ToList();
            while (existingPages.Count > 1)
            {
                foreach (var page in existingPages)
                {
                    Navigation.RemovePage(page);
                }
            }
        }
        Navigation.InsertPageBefore(new MainPage(), this);
        await Navigation.PopAsync();

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistrationPage());
    }
}