using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageServiceGui.pages {
    // base class for observable classes (data for pages/windows)
    public class Observable : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        // general method for property changed event, the input is the name of the property
        protected void OnPropertyChanged(string prop) {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
