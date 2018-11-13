using System;
using NUnit.Framework;
using RobotWarsGUI.FileParser;
using RobotWarsGUI.ViewModel;

namespace RobotWars.GUI.Test.FileParser
{
    public class FileParserTest
    {
        private string _path =AppDomain.CurrentDomain.BaseDirectory + @"FileParser\InputsCase";

        [Test]
        public void Should_return_false_when_the_point_is_not_on_the_map(int x, int y)
        {
            InputFileParser parser = new InputFileParser();
            InputViewModel input = new InputViewModel();
            parser.Parse(_path + @"StandardInput.txt", input);
            Assert.AreEqual(input.Height, 10);
            Assert.AreEqual(input.Width, 10);
            Assert.AreEqual(input.X1, 5);
            Assert.AreEqual(input.Y1, 8);
            Assert.AreEqual(input.Direction1, "W");
            Assert.AreEqual(input.X2, 4);
            Assert.AreEqual(input.Y2, 7);
            Assert.AreEqual(input.Direction2, "S");
            Assert.AreEqual(input.Commands1, "MMLMMMRMMRRMLMRMMMLMRMLLMMM");
            Assert.AreEqual(input.Commands2, "MMLMMMRMMRRMLMRMMMLMRMLLMMM");

        }
    }
}