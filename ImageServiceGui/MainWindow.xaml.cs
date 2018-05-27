using ImageServiceGui.pages;
using ImageServiceGui.view_model;
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

namespace ImageServiceGui {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window {
        // Main Window class
        private MainWindowData _windowData = new MainWindowData();
        // public propertis to change elements in the pages
        public SettingsPage Settings;
        public LogPage Log;
        private MainViewModel _viewModel;

        // constructor
        public MainWindow() {
            InitializeComponent();
            Log = logPage;
            Settings = settingsPage;

            _viewModel = new MainViewModel(this);

            DataContext = _windowData;
        }

        // change background on main window(connected/disconnected)
        public void BackgroundColor(Brush color) {
            _windowData.BackgroundColor = color;
        }
    }
}
