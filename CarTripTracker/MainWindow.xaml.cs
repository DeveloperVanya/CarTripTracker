using System;
using System.Windows;

namespace CarTripTracker
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GoHome_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
            if (StatusText != null) StatusText.Text = "Розділ: Головна";
        }

        private void GoHistory_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("HistoryPage.xaml", UriKind.Relative));
            if (StatusText != null) StatusText.Text = "Розділ: Журнал";
        }

        private void GoSettings_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("SettingsPage.xaml", UriKind.Relative));
            if (StatusText != null) StatusText.Text = "Розділ: Налаштування";
        }
    }
}