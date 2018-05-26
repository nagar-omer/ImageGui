using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ImageServiceGui.CommandBinding;

namespace ImageServiceGui.ViewModal
{
    class ViewModal: IViewModal
    {
        MainWindow guiWindow;
        public ICommand RemoveCommand { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<string> lbHandlers = new ObservableCollection<string>();
        //private IObservable<string> lbHandlers = new IObservable<string>();
        private string selectedItem;

        public int DeleteHandler()
        {
            return 0;
        }
        public string ViewModalOutDir
        {
            get{ return this.guiWindow.Settings.GetOutDir(); }
        }
        public string ViewModalSourceName
        {
           get { return this.guiWindow.Settings.GetSourceName(); }
        }

        public string ViewModalLogName
        {
           get { return this.guiWindow.Settings.GetLogName(); }
        }

        public int ViewModalThumbnailSize
        {
            get { return this.guiWindow.Settings.GetThumbnailSize(); }
        }
        public ObservableCollection<string> LbHandlers
        {
            get { return this.lbHandlers; }
        }
        public string SelectedItem
        {
            set
            {
                this.selectedItem = value;
                this.NotifyPropertyChanged("SelectedItem");
            }
            get
            {
                return this.selectedItem;
            }
        }

        public string GetSettingsFromService() { return "still empty"; }
        
        public ViewModal(MainWindow window)
        {
            this.guiWindow = window;
            guiWindow.Settings.PropertyChanged += delegate (Object sender, PropertyChangedEventArgs e)
            {
                NotifyPropertyChanged("ViewModal_" + e.PropertyName);
            };
            
            this.GetSettingsFromService();
            this.lbHandlers.Add("1.");
            this.lbHandlers.Add("2.");
            this.lbHandlers.Add("3.");

            this.RemoveCommand = new DelegateCommand<object>(this.OnSubmit, this.CanSubmit);
        }
        /*
         check if the object is not null* 
         */
        private bool CanSubmit(object obj)
        {
            if (selectedItem != null)
            {
                return true;
            }
            return false;
        }
        /*send massage to server to remove from handlers, get from server if succeed
            remove the selected item from the observable collection*/
        private void OnSubmit(object obj)
        {
            this.lbHandlers.Remove(selectedItem);
        }

        public void NotifyPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            var command = this.RemoveCommand as DelegateCommand<object>;
            command.RaiseCanExecuteChange();
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.ComponentModel;
//using System.Windows.Input;
//using ImageServiceGUI.CommandBinding;
//using ImageServiceGUI.Model;

//namespace ImageServiceGUI.ViewModel
//{
//    class VMSettingsPage : IVMSettingsPage
//    {
//        private IModelSettingsPage model;

//        public event PropertyChangedEventHandler PropertyChanged;
//        private ObservableCollection<string> lbHandlers = new ObservableCollection<string>();
//        private string selectedItem;

//        public ICommand RemoveCommand { get; private set; }

//        public string VM_OutputDirectory
//        {
//            get { return this.model.OutputDirectory; }
//        }

//        public string VM_SourceName
//        {
//            get { return this.model.SourceName; }
//        }

//        public string VM_LogName
//        {
//            get { return this.model.LogName; }
//        }

//        public int VM_ThumbnailSize
//        {
//            get { return this.model.ThumbnailSize; }
//        }

//        public ObservableCollection<string> LbHandlers
//        {
//            get { return this.lbHandlers; }
//        }

//        public string SelectedItem
//        {
//            set {
//                this.selectedItem = value;
//                this.NotifyPropertyChanged("SelectedItem");
//            }
//            get { return this.selectedItem; }
//        }

//        public VMSettingsPage(IModelSettingsPage model)
//        {
//            this.model = model;
//            model.PropertyChanged += delegate (Object sender, PropertyChangedEventArgs e) {
//                NotifyPropertyChanged("VM_" + e.PropertyName);
//            };
//            this.model.GetSettingsFromService();
//            this.lbHandlers.Add("one");
//            this.lbHandlers.Add("two");
//            this.lbHandlers.Add("three");

//            this.RemoveCommand = new DelegateCommand<object>(this.OnSubmit, this.CanSubmit);
//        }

//        private void OnSubmit(object obj)
//        {
//            // send to server remove from handlers

//            // get from server if succeed

//            // remove the selected item from the observable collection
//            this.lbHandlers.Remove(selectedItem);
//        }

//        private bool CanSubmit(object obj)
//        {
//            if (selectedItem != null)
//            {
//                return true;
//            }
//            return false;
//        }

//        public void NotifyPropertyChanged(string propName)
//        {
//            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
//            var command = this.RemoveCommand as DelegateCommand<object>;
//            command.RaiseCanExecuteChange();
//        }
//    }
//}