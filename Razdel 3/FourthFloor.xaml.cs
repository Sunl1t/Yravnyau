using Yravnyai.Razdel_3;

namespace Yravnyai.Razdel_3;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class FourthFloor : ContentPage
{
    bool loaded = false;
    public FourthFloor()
	{
        InitializeComponent();
        NavigationPage FourthFloor = new NavigationPage();
        IconImageSource = "Razdel_3_bely.png";
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (loaded == false)
        {
            DisplayStack0();
            loaded = true;
        }
    }

    protected internal void DisplayStack0()
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

    protected internal void DisplayStack8()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }



    private async void GoToPage0(object sender, EventArgs e)
    {
        zadanie3_1 page = new zadanie3_1();
        await Navigation.PushAsync(page);
        page.DisplayStack0();
    }
    private async void GoToPage1(object sender, EventArgs e)
    {
        zadanie3_2 page = new zadanie3_2();
        await Navigation.PushAsync(page);
        page.DisplayStack1();
    }
    private async void GoToPage2(object sender, EventArgs e)
    {
        zadanie3_3 page = new zadanie3_3();
        await Navigation.PushAsync(page);
        page.DisplayStack2();
    }
    private async void GoToPage3(object sender, EventArgs e)
    {
        zadanie3_4 page = new zadanie3_4();
        await Navigation.PushAsync(page);
        page.DisplayStack3();
    }
    private async void GoToPage4(object sender, EventArgs e)
    {
        zadanie3_5 page = new zadanie3_5();
        await Navigation.PushAsync(page);
        page.DisplayStack4();
    }
    private async void GoToPage5(object sender, EventArgs e)
    {
        zadanie3_6 page = new zadanie3_6();
        await Navigation.PushAsync(page);
        page.DisplayStack5();
    }
    private async void GoToPage6(object sender, EventArgs e)
    {
        zadanie3_7 page = new zadanie3_7();
        await Navigation.PushAsync(page);
        page.DisplayStack6();
    }
    private async void GoToPage7(object sender, EventArgs e)
    {
        zadanie3_8 page = new zadanie3_8();
        await Navigation.PushAsync(page);
        page.DisplayStack7();
    }
    private async void GoToPage8(object sender, EventArgs e)
    {
        zadanie3_2 page = new zadanie3_2();
        await Navigation.PushAsync(page);
        page.DisplayStack1();
    }
}