using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CarTripTracker
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(DestinationInput.Text) && !string.IsNullOrWhiteSpace(MileageInput.Text))
            {
                InfoDisplay.Text = $"Збережено: {DestinationInput.Text}";
                InfoDisplay.Foreground = Brushes.Green;
                DestinationInput.Clear();
                MileageInput.Clear();
            }
            else
            {
                MessageBox.Show("Заповніть усі поля!");
            }
        }
    }
}