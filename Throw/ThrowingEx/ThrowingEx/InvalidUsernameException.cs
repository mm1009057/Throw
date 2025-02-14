using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingEx
{
    public class InvalidUsernameException : System.Exception
    {
        public InvalidUsernameException(string usernameInput, string username) : base($"Invalid Username: '{usernameInput}'")
        {
            UsernameInput = usernameInput;
            Username = username;
        }

        public string UsernameInput { get; }
        public string Username { get; }
    }
}
