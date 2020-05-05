using System;
using System.ComponentModel;

namespace CoronaInfo.ViewModel
{
    public class CountryViewModel : INotifyPropertyChanged 
    {
        public CountryViewModel()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
