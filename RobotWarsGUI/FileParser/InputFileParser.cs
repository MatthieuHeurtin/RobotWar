using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using RobotWarsGUI.ViewModel;
using System;

namespace RobotWarsGUI.FileParser
{
    //the file parser could be move to another project ?
    public class InputFileParser : IInputFileParser
    {
        private readonly List<char> WaitedCharacterAsCommand = new List<char> { 'M', 'L', 'R' };

        private readonly List<string> WaitedDirection = new List<string> { "N", "S", "E", "W" };

        public void Parse(string filePath, InputViewModel input)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show(@"File Not found" + filePath);
                return;
            }
            string[] lines = File.ReadAllLines(filePath);
            if (!CheckLength(lines.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray(), 5, "5 lines")) return;

            //Map
            string[] mapSize = lines[0].Split(' ');
            if (!CheckLength(mapSize, 2, "2 intergs on the first line")) return;
            string[] robot1Position = lines[1].Split(' ');
            if (!CheckLength(robot1Position, 3, "2 intergs on the second line and a character")) return;
            string[] robot2Position = lines[3].Split(' ');
            if (!CheckLength(robot2Position, 3, "2 intergs on the second line and a character")) return;

            if (robot1Position[2].Length != 1 || robot2Position[2].Length != 1 || 
                !WaitedDirection.Contains(robot1Position[2]) || !WaitedDirection.Contains(robot2Position[2]))
            { 
                MessageBox.Show("The direction is a letter (N, S, E, W)");
                return;
            }

            input.Direction1 = robot1Position[2];
            input.Direction2 = robot2Position[2];

            try
            {
                input.Width = int.Parse(mapSize[0]);
                input.Height = int.Parse(mapSize[1]);
                input.X1 = int.Parse(robot1Position[0]);
                input.Y1 = int.Parse(robot1Position[1]);
                input.X2 = int.Parse(robot2Position[0]);
                input.Y2 = int.Parse(robot2Position[1]);
            }
            catch (Exception e) //remplace by a more specific exception
            {
                MessageBox.Show("Error while loading the file. Please you don't have mistaken an integer and a character");
                return;
            }

            input.Commands1 = string.Join("", lines[2].Where(x => WaitedCharacterAsCommand.Contains(x)));
            input.Commands2 = string.Join("", lines[4].Where(x => WaitedCharacterAsCommand.Contains(x)));
        }


        private static bool CheckLength(string[] lines, int waitedSize, string message)
        {
            if (lines.Length != waitedSize)
            {
                MessageBox.Show(@"The input file must have " + message);
                return false;
            }
            return true;
        }
    }
}






