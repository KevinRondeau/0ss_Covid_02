using BillingManagement.Models;
using BillingManagement.UI.ViewModels;
using System.Windows;

namespace BillingManagement.UI.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        
        public MainView()
        {
           InitializeComponent();
            DataContext = new MainViewModel();
        }


    }
}
