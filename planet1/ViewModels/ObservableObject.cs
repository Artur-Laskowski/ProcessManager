using System.ComponentModel;

namespace planet1.ViewModels {
	public abstract class ObservableObject : INotifyPropertyChanged {

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChangedEvent(string propertyName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
