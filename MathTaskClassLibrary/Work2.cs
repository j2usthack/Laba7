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
        public double[] Solve()
        {
            double d = (_b * _b) - (4 * _a * _c);

            if (d < 0)
            {
                return new double[0];
            }
            double x1 = Math.Round((-_b + Math.Sqrt(d)) / (2 * _a), 2);
            if (d == 0)
            {
                return new double[1] { x1 };
            }
            double x2 = Math.Round((-_b - Math.Sqrt(d)) / (2 * _a), 2);
            return new double[2] { x1, x2 };
        }
    }
}