using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MicrowellPlate.Main
{
    public class MainViewModel: INotifyPropertyChanged
    {
        public MainViewModel()
        {
            Plates = new ObservableCollection<Plate>()
            {
                new WellPlate6(),
                new WellPlate12(),
            };
        }

        public ICollection<Plate> Plates { get; }

        public Plate SelectedPlate
        {
            get { return _selectedPlate; }
            set { SetProperty(ref _selectedPlate, value); }
        }

        private void SetProperty<T>(ref T field, T value, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return;
            }

            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Plate _selectedPlate;
    }
}
