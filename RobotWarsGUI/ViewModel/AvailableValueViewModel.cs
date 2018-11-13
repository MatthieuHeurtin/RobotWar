using System.Collections.Generic;
using System.ComponentModel;

namespace RobotWars.GUI.ViewModel
{
    public class AvailableValueViewModel
    {
        //put the size max in a config file
        private const int MaxSize = 10;

        public AvailableValueViewModel()
        {
            for (int i = 1; i <= MaxSize; i++)
            {
                HeightRange.Add(i);
                WidthRange.Add(i);
            }
            for (int i = 0; i < MaxSize; i++)
            {
                AvailableValueForY2.Add(i);
                AvailableValueForY1.Add(i);
                AvailableValueForX2.Add(i);
                AvailableValueForX1.Add(i);
            }
        }

        public readonly List<int> HeightRange = new List<int>();
        public readonly List<int> WidthRange = new List<int>();

        public readonly List<string> DirectionsRobot1 = new List<string>
        {"N", "S", "E", "W"};

        public readonly List<string> DirectionsRobot2 = new List<string>
        {"N", "S", "E", "W"};

        public readonly BindingList<int> AvailableValueForX1 = new BindingList<int>();
        public readonly BindingList<int> AvailableValueForY1 = new BindingList<int>();
        public readonly BindingList<int> AvailableValueForX2 = new BindingList<int>();
        public readonly BindingList<int> AvailableValueForY2 = new BindingList<int>();
    }
}
