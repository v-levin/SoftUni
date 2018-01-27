using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    public class InvalidCommandException : Exception
    {
        private const string DisplayInvalidCommandMessage = "The command '{0}' is invalid";
        
        public InvalidCommandException(string command) : base(string.Format(DisplayInvalidCommandMessage, command))
        {
        }

    }
}
