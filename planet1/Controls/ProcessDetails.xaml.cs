using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace planet1.Controls {
    /// <summary>
    /// Interaction logic for ProcessDetails.xaml
    /// </summary>
    public partial class ProcessDetails : UserControl {
        public ProcessDetails() {
            InitializeComponent();
            this.DataContext = this;
        }
        
        public System.Diagnostics.Process Process {
            get { return (System.Diagnostics.Process)GetValue(ProcessProperty); }
            set { SetValue(ProcessProperty, value); }
        }

        public static DependencyProperty ProcessProperty =
           DependencyProperty.Register("Process", typeof(int), typeof(ProcessDetails));
    }
}
