using System;
using System.ComponentModel;
namespace MyLittleBeaconOpgave.ViewModel
{
    public class SalesOrderViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnpropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
