namespace DesignPatterns.Structural.Adapter.Ex1
{
    public class RoundHole
    {
        private int _radius { get; set; }

        public RoundHole(int radius)
        {
            _radius = radius;
        }

        public bool Fits(RoundPeg roundPeg)
        { 
            return roundPeg.Radius >= _radius;
        }
    }
}
