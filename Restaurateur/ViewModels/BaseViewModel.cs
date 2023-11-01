using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurateur.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        protected virtual void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        protected virtual void OnPropertyChanging([CallerMemberName] string name = "") =>
            PropertyChanging?.Invoke(this, new System.ComponentModel.PropertyChangingEventArgs(name));

        protected void SetValue<T>(ref T property, T value, [CallerMemberName] string name = "")
        {
            if (!property.Equals(value))
            {
                property = value;
                OnPropertyChanged(name);
            }
        }
    }
}
