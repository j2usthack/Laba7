using MathTaskClassLibrary;

namespace Lab7
{
    internal class Program
    {
        private static void Main()
        {
            Work2 work2 = new Work2(1, 3, -4);
            double[] s = work2.Solve();
            System.Console.WriteLine(s[0]);
            System.Console.WriteLine(s[1]);
        }
    }
}