using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp1.views;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.NavigationService.Navigate(new StartPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new StartPage());
        }
    }
}
