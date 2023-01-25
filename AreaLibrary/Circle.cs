using System;

namespace AreaLibrary
{
    public class Circle: Figure
    {
        public double Radius { get; set; }

        public Circle(string Figure, double Radius): base(Figure)
        {
            this.Radius = Radius;
        }

        public override double Square()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }
}
