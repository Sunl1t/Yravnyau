using Yravnyai.Razdel_1;
namespace Yravnyai.Razdel_1;
[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class SecondFloor : ContentPage
{
    bool loaded = false;
    public SecondFloor()
	{
        InitializeComponent();
        NavigationPage SecondFloor = new NavigationPage();
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
    //public abstract class BasePage : ContentPage
    //{
    //    protected void NavigateToPage<TPage>() where TPage : ContentPage, new()
    //    {
    //        Navigation.PushAsync(new TPage());
    //    }

    //    protected void GoBackToRoot()
    //    {
    //        Navigation.PopToRootAsync();
    //    }

    //    private async void GoToBack(object sender, EventArgs e)
    //    {
    //        await Navigation.PopAsync();

    //        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    //        ((SecondFloor)navPage.CurrentPage).DisplayStack();
    //    }

    //    protected internal void DisplayStack()
    //    {
    //        if (App.Current.MainPage == null)
    //        {
    //            throw new InvalidOperationException("MainPage не инициализирована.");
    //        }

    //        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    //    }
    //}

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
    protected internal void DisplayStack8()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    protected internal void DisplayStack9()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    protected internal void DisplayStack10()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }
    protected internal void DisplayStack11()
    {
        if (App.Current.MainPage == null)
        {
            throw new InvalidOperationException("MainPage не инициализирована.");
        }

        NavigationPage navPage = (NavigationPage)App.Current.MainPage;
    }



    //"GoToForward buttons
    private async void GoToForward(object sender, EventArgs e)
    {
        zadanie1_1 page = new zadanie1_1();
        await Navigation.PushAsync(page);
        page.DisplayStack();
    }

    private async void GoToForward1(object sender, EventArgs e)
    {
        zadanie1_2 page = new zadanie1_2();
        await Navigation.PushAsync(page);
        page.DisplayStack1();
    }

    private async void GoToForward2(object sender, EventArgs e)
    {
        zadanie1_3 page = new zadanie1_3();
        await Navigation.PushAsync(page);
        page.DisplayStack2();
    }

    private async void GoToForward3(object sender, EventArgs e)
    {
        zadanie1_4 page = new zadanie1_4();
        await Navigation.PushAsync(page);
        page.DisplayStack3();
    }

    private async void GoToForward4(object sender, EventArgs e)
    {
        zadanie1_5 page = new zadanie1_5();
        await Navigation.PushAsync(page);
        page.DisplayStack4();
    }

    private async void GoToForward5(object sender, EventArgs e)
    {
        zadanie1_6 page = new zadanie1_6();
        await Navigation.PushAsync(page);
        page.DisplayStack5();
    }

    private async void GoToForward6(object sender, EventArgs e)
    {
        zadanie1_7 page = new zadanie1_7();
        await Navigation.PushAsync(page);
        page.DisplayStack6();
    }

    private async void GoToForward7(object sender, EventArgs e)
    {
        zadanie1_8 page = new zadanie1_8();
        await Navigation.PushAsync(page);
        page.DisplayStack7();
    }

    //private async void GoToForward8(object sender, EventArgs e)
    //{
    //    zadanie1_9 page = new zadanie1_9();
    //    await Navigation.PushAsync(page);
    //    zadanie1_9.DisplayStack8();
    //}

    //private async void GoToForward9(object sender, EventArgs e)
    //{
    //    zadanie1_10 page = new zadanie1_10();
    //    await Navigation.PushAsync(page);
    //    page.DisplayStack9();
    //}
}