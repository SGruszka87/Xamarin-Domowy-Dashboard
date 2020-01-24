using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DomowyDashboard.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        internal void RaisePropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
