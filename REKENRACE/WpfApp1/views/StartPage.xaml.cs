using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace WpfApp1.views
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }
        private void RemoveText(object sender, RoutedEventArgs e)
        {
            if (NameTextBox.Text == "Enter your name")
            {
                NameTextBox.Text = "";
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                NameTextBox.Text = "Enter your name";
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // Store the name typed in the TextBox
            string userName = NameTextBox.Text;

            // Navigate to the DifficultyPage
            NavigationService.Navigate(new DifficultyPage());
        }
    }
}