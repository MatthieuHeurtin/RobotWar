using System;
using System.Runtime.CompilerServices;

namespace RobotWarsGUI.ViewModel
{
    public class InputViewModel
    {
        public event EventHandler<FileLoadedEvent> PropertyChanged;

        private int _height;
        private int _width;
        private string _commands1;
        private string _direction1;
        private int _y1;
        private int _x1;
        private int _x2;
        private int _y2;
        private string _direction2;
        private string _commands2;

        public int Height
        {
            get { return _height; }
            set { _height = value; OnPropertyChanged(value); }
        }
        public int Width
        {
            get { return _width; }
            set { _width = value; OnPropertyChanged(value); }
        }

        public int X1
        {
            get { return _x1; }
            set { _x1 = value; OnPropertyChanged(value); }
        }

        public int Y1
        {
            get { return _y1; }
            set { _y1 = value; OnPropertyChanged(value); }
        }

        public string Direction1
        {
            get { return _direction1; }
            set { _direction1 = value; OnPropertyChanged(value); }
        }
        public string Commands1
        {
            get { return _commands1; }
            set { _commands1 = value; OnPropertyChanged(value); }
        }

        public int X2
        {
            get { return _x2; }
            set { _x2 = value; OnPropertyChanged(value); }
        }
        public int Y2
        {
            get { return _y2; }
            set { _y2 = value; OnPropertyChanged(value); }
        }
        public string Direction2
        {
            get { return _direction2; }
            set { _direction2 = value; OnPropertyChanged(value); }
        }
        public string Commands2
        {
            get { return _commands2; }
            set { _commands2 = value; OnPropertyChanged(value); }
        }

        private void OnPropertyChanged(object value, [CallerMemberName] string memberName = "")
        {
            PropertyChanged?.Invoke(this, new FileLoadedEvent(memberName, value));
        }
    }
}
