using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ImageServiceGui.pages {
    public enum Type { INFO, WARNING, ERROR };

    // class for a single item of log mainly contains properties
    public class LogListItem{
        private string _message;
        private Type _type;
        private Brush _color;
        private string _type_str;

        // constructor - as the regular format (type, message)
        public LogListItem(Type type, string message) {
            _message = message;
            _type = type;
            setType(type);
        }

        // set type - updates color and string
        private void setType(Type type) {
            _type = type;
            switch (_type) {
                case Type.INFO:
                    _color = Brushes.LightGreen;
                    LogType = "INFO";
                    return;
                case Type.WARNING:
                    _color = Brushes.LightYellow;
                    _type_str = "WARNING";
                    return;
                case Type.ERROR:
                    _color = Brushes.LightCoral;
                    _type_str = "ERROR";
                    return;
                default:
                    _color = Brushes.LightGreen;
                    _type_str = "INFO";
                    return;
            }
        }

        // message property
        public string Message {
            get {
                if (_message == null)
                    return " - empty log message - ";
                return _message;
            }

            set {
                _message = value;
            }
        }

        // background color property
        public Brush Color {
            get {
                if (_color == null)
                    return Brushes.Green;
                return _color;
            }
            set {
                _color = value;
            }
        }

        // type property
        public string LogType {
            get {
                if (_type_str == null)
                    return "INFO";
                return _type_str;
            }
            set {
                _type_str = value;
            }
        }

    }
}
