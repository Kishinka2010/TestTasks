using System;

namespace AreaLibrary
{
    public class Triangle: Figure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        public Triangle(string Figure, double a, double b, double c) : base(Figure)
        {

            if (a < 0 || b < 0 || c < 0)
            {
                throw new TriangleException("Cторона(ы) меньше 0. Проверьте введенные значения.");
            }

            if (a > (b + c) || b > (a + c) || c > (a + b))
            {
                throw new TriangleException("Сторона больше суммы двух других. Проверьте введенные значения");
            }

            A = a;
            B = b;
            C = c;

        }

        public override double Square()
        {
            double p = (A + B + C) / 2;
            double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return S;
        }

        public bool IsRectangular()
        {
            return A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(A, 2))
                          || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(A, 2))
                          || A == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));
        }
    }
}
