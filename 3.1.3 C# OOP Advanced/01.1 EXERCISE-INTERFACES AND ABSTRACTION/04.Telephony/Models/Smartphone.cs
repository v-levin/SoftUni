using System.Linq;
using Telephony.Interfaces;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowseable
    {
        public string Call(string number)
        {
            return number.Any(ch => !char.IsDigit(ch)) ? "Invalid number!" : $"Calling... {number}";
        }

        public string Browse(string url)
        {
            return url.Any(ch => char.IsDigit(ch)) ? "Invalid URL!" : $"Browsing: {url}!";
        }
    }
}
