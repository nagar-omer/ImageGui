using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace ImageServiceGui.ViewModal
{
    interface IViewModal:INotifyPropertyChanged 
    {
        int ViewModalThumbnailSize { get; }
        string ViewModalOutDir { get;}
        string ViewModalSourceName { get; }
        string ViewModalLogName { get; }

        ObservableCollection<string> LbHandlers { get;}
    }
}
