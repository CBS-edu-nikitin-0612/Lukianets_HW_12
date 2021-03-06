namespace Task3
{
    internal class Point
    {
        private int _x, _y;
        private string _name;

        public int X => _x;
        public int Y => _y;
        public string Name => _name;

        public Point(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }

        public override string ToString()
        {
            return $"{_name} ({_x}; {_y})";
        }
    }
}
