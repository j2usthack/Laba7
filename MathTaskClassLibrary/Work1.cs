using System;

namespace MathTaskClassLibrary
{
    public class Work1
    {
        private const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string BuildString(int n)
        {
            if (n < 1 || n > 26)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Значение должно быть от 1 до 26 включительно");
            }
            return ALPHABET.Substring(0, n);
        }
    }
}