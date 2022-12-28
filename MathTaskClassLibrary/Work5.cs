using System;

namespace MathTaskClassLibrary
{
    public class Work5
    {
        public int Calculate(string num)
        {
            if (!int.TryParse(num, out int res))
            {
                throw new InvalidOperationException("Строка не была числом");
            }
            return res + res;
        }
    }
}