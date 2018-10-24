using System;
using System.Windows.Input;

namespace planet1.ViewModels {
	public class DelegateCommand : ICommand {

		private readonly Action<object> _action;
		private readonly Func<object, bool> _canExecuteFunc;

		public DelegateCommand(Action<object> action, Func<object, bool> canExecuteFunc) {
			_action = action;
			_canExecuteFunc = canExecuteFunc;
		}

		public void Execute(object parameter) {
			_action(parameter);
		}

		public bool CanExecute(object parameter) {
			return _canExecuteFunc(parameter);
		}

#pragma warning disable 67
		public event EventHandler CanExecuteChanged {
			add {
				CommandManager.RequerySuggested += value;
			}
			remove {
				CommandManager.RequerySuggested -= value;
			}
		}
#pragma warning restore 67
	}
}
