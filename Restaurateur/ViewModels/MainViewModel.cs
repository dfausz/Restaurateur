using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restaurateur.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Timer _timer;

        private DateTime now = DateTime.Now;
        public DateTime Now
        {
            get => now;
            set => SetValue(ref now, value);
        }

        public ICommand StartCommand { get; }
        public ICommand StopCommand { get; }

        public MainViewModel()
        {
            StartCommand = new Command(() =>
            {
                _timer = new Timer(new TimerCallback((s) => Now = DateTime.Now),
                           null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
            });

            StopCommand = new Command(() =>
            {
                _timer.Dispose();
            });
        }

        protected override void OnPropertyChanged([CallerMemberName] string name = "")
        {
            base.OnPropertyChanged(name);

            switch(name)
            {
                case nameof(Now):
                    break;
            }
        }
    }
}
