using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace ImageServiceGui.pages {
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
     
    // settings page User-Control 
    public partial class SettingsPage : UserControl {

        public event PropertyChangedEventHandler PropertyChanged;
        private SettingsData _settingsData;
        public SettingsPage() {
            // init observable object
            ObservableCollection<string> y = new ObservableCollection<string>();
            // init data
            _settingsData = new SettingsData(y);
            InitializeComponent();
            DataContext = _settingsData;
        }
        
        // set of function to change properties of the page

        public void SetOutDir(string outDir){
            _settingsData.OutputDir = outDir;
        }

        public void SetSourceName(string source) {
            _settingsData.SourceName = source;
        }

        public void SetLogName(string logger) {
            _settingsData.LogName = logger;
        }

        public void SetThumbnailSize(int size) {
            _settingsData.ThumbSize = size.ToString();
        }

        public void AddHndler(string handler) {
            _settingsData.addHndler(handler);
        }

        public void RemoveHndler(string handler) {
            _settingsData.removeHndler(handler);
        }

        public void EnableRemove() {
            _settingsData.ClickEnabled = true;
        }

        public void DisableRemove() {
            _settingsData.ClickEnabled = false;
        }

        private void OnRemoveButtonClicked(object sender, RoutedEventArgs e) {
            // TODO activate view model func
        }
        //get functions for requiered things.
        public string GetOutDir()
        {
            return this._settingsData.OutputDir;
        }
        public string GetSourceName()
        {
            return this._settingsData.SourceName;
        }
        public string GetLogName()
        {
            return this._settingsData.LogName;
        }
        public int GetThumbnailSize()
        {
            return Int32.Parse(this._settingsData.ThumbSize);
        }
    }
}
