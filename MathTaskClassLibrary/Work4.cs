using System.Text.RegularExpressions;

namespace MathTaskClassLibrary
{
    public class Work4
    {
        private readonly Regex _regex = new Regex(@"^(\w+\.)?\w+@(\w+\.){1,2}\w{1,4}");
        public bool EmailCheck(string email) => _regex.IsMatch(email);
    }
}