using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ImageServiceGui.view_model
{
    class MainViewModel{
        private MainWindow view;

        public MainViewModel(MainWindow window) {
            view = window;
            view.Settings.RemovedClicked += OnRemovedClickedHandler;
            view.Settings.HandlersListChanged += OnHandlersListChangedHandler;



            view.Log.AddLog(pages.Type.INFO, "info message");
            view.Log.AddLog(pages.Type.ERROR, "error message");
            view.Log.AddLog(pages.Type.WARNING, "warning message");

            view.Settings.AddHndlerToList("one");
            view.Settings.AddHndlerToList("two");
            view.Settings.AddHndlerToList("dsadasfae");
            view.Settings.EnableRemove();
            // view.Settings.DisableRemove();
            view.Settings.RemoveHndlerFromList("one");
            view.Settings.SetOutDir("c/dasds/ccsa/cca");
            view.Settings.SetLogName("logger");

            
            // TODO load logs
            // TODO load config
        }

        public void OnRemovedClickedHandler() {
            view.Log.AddLog(pages.Type.ERROR, "error message");
            // TODO implement - remove handler from view
        }

        public void OnHandlersListChangedHandler() {
            // TODO implement - remove handler from view
        }
    }
}
