using RobotWarsGUI.ViewModel;

namespace RobotWarsGUI.FileParser
{
    public interface IInputFileParser
    {
        void Parse(string filePath, InputViewModel input);
    }
}