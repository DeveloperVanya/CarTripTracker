using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CarTripTracker
{
    public partial class HomePage : Page
    {
        public Trip CurrentTrip { get; set; }

        public HomePage()
        {
            InitializeComponent();
            CurrentTrip = new Trip { Destination = "Київ", Mileage = "100" };
            this.DataContext = CurrentTrip;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CurrentTrip.Destination) && !string.IsNullOrWhiteSpace(CurrentTrip.Mileage))
            {
                if (InfoDisplay != null)
                {
                    InfoDisplay.Text = $"✅ Збережено: {CurrentTrip.Destination}";
                    InfoDisplay.Foreground = Brushes.Green;
                }
            }
            else
            {
                MessageBox.Show("Заповніть усі поля!");
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentTrip.Destination = string.Empty;
            CurrentTrip.Mileage = string.Empty;
            if (InfoDisplay != null) InfoDisplay.Text = string.Empty;
        }
    }
}