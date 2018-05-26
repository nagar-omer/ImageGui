using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for LogsPage.xaml
    /// </summary>
    
    // Log Page User-Control
    public partial class LogPage : UserControl {
        LogData logData ;

        public LogPage() {
            // init observable object
            ObservableCollection<LogListItem> y = new ObservableCollection<LogListItem>();
            logData = new LogData(y);
            InitializeComponent();
            DataContext = logData;
        }

        // add log to screen
        public void AddLog(Type type, string message) {
            logData.AddLog(type, message);
        }
    }
}
