using System.Text.RegularExpressions;

namespace MathTaskClassLibrary
{
    public class Work4
    {
        private readonly Regex _regex = new Regex(@".+@.+");
        public bool EmailCheck(string email) => _regex.IsMatch(email);
    }
}