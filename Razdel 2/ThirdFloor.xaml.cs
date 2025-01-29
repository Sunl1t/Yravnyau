using Yravnyai.Razdel_2;

namespace Yravnyai.Razdel_2;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ThirdFloor : ContentPage
{
    bool loaded = false;
    public ThirdFloor()
	{
        InitializeComponent();
        NavigationPage ThirdFloor = new NavigationPage();
        IconImageSource = "Razdel_1_bely.png";
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (loaded == false)
        {
            DisplayStack();
            loaded = true;
        }
    }

    protected internal void DisplayStack()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    protected internal void DisplayStack1()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    protected internal void DisplayStack2()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    protected internal void DisplayStack3()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    protected internal void DisplayStack4()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    protected internal void DisplayStack5()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    protected internal void DisplayStack6()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    protected internal void DisplayStack7()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }



    private async void GoToPage(object sender, EventArgs e)
    {
        zadanie2_1 page = new zadanie2_1();
        await Navigation.PushAsync(page);
        page.DisplayStack();
    }
    private async void GoToPage1(object sender, EventArgs e)
    {
        zadanie2_2 page = new zadanie2_2();
        await Navigation.PushAsync(page);
        page.DisplayStack1();
    }
    private async void GoToPage2(object sender, EventArgs e)
    {
        zadanie2_3 page = new zadanie2_3();
        await Navigation.PushAsync(page);
        page.DisplayStack2();
    }
    private async void GoToPage3(object sender, EventArgs e)
    {
        zadanie2_4 page = new zadanie2_4();
        await Navigation.PushAsync(page);
        page.DisplayStack3();
    }
    private async void GoToPage4(object sender, EventArgs e)
    {
        zadanie2_5 page = new zadanie2_5();
        await Navigation.PushAsync(page);
        page.DisplayStack4();
    }
    private async void GoToPage5(object sender, EventArgs e)
    {
        zadanie2_6 page = new zadanie2_6();
        await Navigation.PushAsync(page);
        page.DisplayStack5();
    }
    private async void GoToPage6(object sender, EventArgs e)
    {
        zadanie2_7 page = new zadanie2_7();
        await Navigation.PushAsync(page);
        page.DisplayStack6();
    }
    private async void GoToPage7(object sender, EventArgs e)
    {
        zadanie2_8 page = new zadanie2_8();
        await Navigation.PushAsync(page);
        page.DisplayStack7();
    }
}