namespace RobotWars.Model
{
    //map could be a singleton ?
    public class Map
    {
        private readonly int _height;
        private readonly int _width;

        public Map(int height, int width)
        {
            _height = height;
            _width = width;
        }

        public bool IsOnTheMap(int x, int y)
        {
            return (0 <= x && x < _width) && (0 <= y && y < _height);
        }
    }
}
