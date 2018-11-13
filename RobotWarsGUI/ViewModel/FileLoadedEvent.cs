using System;
 
namespace RobotWarsGUI.ViewModel
{
    public class FileLoadedEvent : EventArgs
    {
        public string MemberName { get; private set; }
        public object Value { get; private set; }

        public FileLoadedEvent(string memberName, object value)
        {
            MemberName = memberName;
            Value = value;
        }
    }
}
