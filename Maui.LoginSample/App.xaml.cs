using Maui.LoginSample.Views;

namespace Maui.LoginSample;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new LoginPage();
    }
}
