using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvm
{
    //[INotifyPropertyChanged]
    internal partial class MainViewModel : ObservableObject
    {
        public string CounterString
        {
            get
            {
                return $"Current count: {counter}";
            }
        }
        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(CounterString))]
        private int counter;

        [ICommand]
        public void IncrementCounter()
        {
            Counter++;
        }
    }
}
