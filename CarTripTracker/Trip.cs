using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CarTripTracker
{
    public class Trip : INotifyPropertyChanged
    {
        private string destination;
        private string mileage;

        public string Destination
        {
            get => destination;
            set { destination = value; OnPropertyChanged(); }
        }

        public string Mileage
        {
            get => mileage;
            set { mileage = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}