using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageServiceGui.pages {
    // this class contains information for the log page
    public class LogData : Observable {
        public ObservableCollection<LogListItem> Logs { get; set; }

        // adds log row to screen
        public void AddLog(Type type, string message) {
            Logs.Add(new LogListItem(type, message));
        }

        // constructor init with logs list
        public LogData(ObservableCollection<LogListItem> logs) {
            Logs = logs;
        }
    }
}
