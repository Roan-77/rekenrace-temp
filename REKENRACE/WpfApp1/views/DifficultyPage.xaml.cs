using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.views
{
    /// <summary>
    /// Interaction logic for DifficultyPage.xaml
    /// </summary>
    public partial class DifficultyPage : Page
    {
        private string selectedDifficulty;

        public DifficultyPage()
        {
            InitializeComponent();
        }

        private void DifficultyButton_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                selectedDifficulty = clickedButton.Content.ToString();
                MessageBox.Show($"Selected Difficulty: {selectedDifficulty}");
            }
        }
    }
}
