using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows;

namespace planet1.ViewModels {
    internal class MainViewModel : ObservableObject {
        private readonly Models.IProcessSource _processSource;

        public MainViewModel(Models.IProcessSource model) {
            _processSource = model;
            _processes = _processSource.AllProcesses;
        }
        public MainViewModel() : this(new Models.ProcessSource()) {

        }
        
        private Process[] _processes;

        public Process[] Processes {
            get => _processes;
            set {
                SetProperty(ref _processes, value);
            }
        }

        private Process _currentItem;

        public Process CurrentItem {
            get => _currentItem;
            set {
                SetProperty(ref _currentItem, value);
            }
        }

        public ICommand KillProcessCommand {
            get => new DelegateCommand(KillProcess, (object o) => true);
        }

        protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "") {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return;

            field = value;
            RaisePropertyChangedEvent(propertyName);
        }

        private void KillProcess(object o) {
            MessageBox.Show((o as int?).ToString());
        }
    }
}
