using System;

namespace MathTaskClassLibrary
{
    public class Work2
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;
        public Work2(double a, double b, double c)
        {
            if (a == 0) throw new ArgumentException("a = 0");
            _a = a;
            _b = b;
            _c = c;
        }
        private double D => Math.Pow(_b, 2) - (4 * _a * _c);
        public double[] Solve()
        {
            if (D < 0)
            {
                return new double[0];
            }
            double x1 = (-_b + Math.Sqrt(D)) / (2 * _a);
            if (D == 0)
            {
                return new double[1] { x1 };
            }
            double x2 = (-_b - Math.Sqrt(D)) / (2 * _a);
            return new double[2] { x1, x2 };
        }
    }
}