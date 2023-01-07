using System;
using System.Linq;

namespace MathTaskClassLibrary
{
    public class Work5
    {
        public int Calculate(string num)
        {
            return num.Sum(x => ToInt32(x));
        }
        private int ToInt32(char value)
        {
            if (int.TryParse(value.ToString(), out int res))
            {
                return res;
            }
            throw new InvalidOperationException("Невозможно конвертировать");
        }
    }
}