using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ImageServiceGui.pages {

    // class that holds information for main windoe
    class MainWindowData : Observable{

        private Brush _bachgroundColor;

        public MainWindowData() {
            _bachgroundColor = Brushes.Gray;
        }

        // background property
        public Brush BackgroundColor {
            get {
                if (_bachgroundColor == null)
                    return Brushes.Gray;
                return _bachgroundColor;
            }

            set {
                _bachgroundColor = value;
                OnPropertyChanged("BackgroundColor");
            }
        }
    }
}
