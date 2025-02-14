using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowingEx
{
    public class InvalidPasswordException : System.Exception
    {
        public InvalidPasswordException(string passwordInput, string password) : base($"Invalid Password: '{passwordInput}'")
        {
            PasswordInput = passwordInput;
            Password = password;
        }

        public string PasswordInput { get; }
        public string Password { get; }
    }
}
