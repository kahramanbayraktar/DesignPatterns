namespace DesignPatterns.Structural.Adapter.Ex1
{
    public class SquarePegAdapter : RoundPeg
    {
        private readonly SquarePeg _squarePeg = null!;

        public SquarePegAdapter(int radius) : base(radius)
        {
        }

        public double GetRadius()
        {
            return _squarePeg.Width * Math.Sqrt(2) / 2;
        }
    }
}
