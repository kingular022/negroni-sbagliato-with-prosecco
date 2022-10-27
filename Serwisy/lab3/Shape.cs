namespace _20._10.Serwisy.lab3
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }

        public int GetArea(int x) // polimorfizm
        {
            return Width * Height;
        }

        public int GetArea(double x)
        {
            return Width * Height;
        }

        public int GetShorterSide()
        {
            return new List<int>() { Width, Height}. Min();
        }

    }
}
