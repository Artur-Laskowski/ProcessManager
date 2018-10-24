using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace planet1.Models {
    class ProcessSource : IProcessSource {
        public Process[] AllProcesses {
            get {
                return Process.GetProcesses();
            }
        }
    }
}
