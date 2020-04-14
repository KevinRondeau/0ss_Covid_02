
using System.Windows;
using BillingManagement.UI;
using BillingManagement.UI.Views;

namespace Inventaire
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainView _window;

        public App()
        {

            _window = new MainView();

            _window.Show();
        }
    }
}
