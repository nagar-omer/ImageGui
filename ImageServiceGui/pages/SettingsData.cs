using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ImageServiceGui.pages {

    // this class holds information for the settings page
    class SettingsData : Observable {
        private string _outputDir;
        private string _sourceName;
        private string _logName;
        private string _thumbSize;
        private Boolean _clickEnabled;
        public ObservableCollection<string> Paths { get; set; }

        // constructor, inits remove bottun to unclicable
        public SettingsData(ObservableCollection<string>  paths) {
            _clickEnabled = false;
            Paths = paths;
        }

        // add handler to list
        public void addHndler(string handler) {
            Paths.Add(handler);
        }

        // remove handler from list
        public void removeHndler(string handler) {
            Paths.Remove(handler);
        }

        // output dir property
        public string OutputDir {
            get {
                if (_outputDir == null)
                    return " - no output dir - ";
                return _outputDir;
            }

            set {
                _outputDir = value;
                OnPropertyChanged("OutputDir");
            }
        }

        // source name property
        public string SourceName {
            get {
                if (_sourceName == null)
                    return " - no source name - ";
                return _sourceName;
            }

            set {
                _sourceName = value;
                OnPropertyChanged("SourceName");
            }
        }

        // log name property
        public string LogName {
            get {
                if (_logName == null)
                    return " - no logger name - ";
                return _logName;
            }

            set {
                _logName = value;
                OnPropertyChanged("LogName");
            }
        }

        // thumbnail size property
        public string ThumbSize {
            get {
                if (_thumbSize == null)
                    return " - no thumb size - ";
                return _thumbSize;
            }

            set {
                _thumbSize = value;
                OnPropertyChanged("ThumbSize");
            }
        }

        // is remove button clicked enabled property
        public Boolean ClickEnabled {
            get {
                return _clickEnabled;
            }

            set {
                _clickEnabled = value;
                OnPropertyChanged("ClickEnabled");
            }
        }

    }
}
