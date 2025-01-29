namespace Yravnyai;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class FifthFloor : ContentPage
{
	public FifthFloor()
	{
		InitializeComponent();
	}
    private async void ToolbarItem_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new LoginPage());
        await Navigation.PopToRootAsync();

    }
    private async void ResetNavigationStack(object sender, EventArgs e)
    {
        Navigation.InsertPageBefore(new LoginPage(), this);
        await Navigation.PopAsync();
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

    }
}