using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restaurateur.ViewModels
{
    public class StarViewModel : BaseViewModel
    {
        private bool toggled;
        public bool Toggled
        {
            get => toggled;
            set => SetValue(ref toggled, value);
        }

        public ICommand ToggleCommand { get; }

        public StarViewModel()
        {
            ToggleCommand = new Command(() =>
            {
                Toggled = !Toggled;
            });
        }
    }
}
