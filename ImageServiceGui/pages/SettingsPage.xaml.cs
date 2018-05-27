using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public delegate void RemovedClickedHandker();
        public delegate void HandlersListChangedHandker();
        public event RemovedClickedHandker RemovedClicked;
        public event HandlersListChangedHandker HandlersListChanged;

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

        public void AddHndlerToList(string handler) {
            _settingsData.addHndler(handler);
        }

        public void RemoveHndlerFromList(string handler) {
            _settingsData.removeHndler(handler);
        }

        public void EnableRemove() {
            _settingsData.ClickEnabled = true;
        }

        public void DisableRemove() {
            _settingsData.ClickEnabled = false;
        }

        private void OnRemoveButtonClicked(object sender, RoutedEventArgs e) {
            RemovedClicked();
        }

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e) {
            HandlersListChanged();
        }
    }
}
