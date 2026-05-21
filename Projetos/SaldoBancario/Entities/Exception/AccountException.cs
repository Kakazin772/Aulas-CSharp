using System;
using System.Collections.Generic;
using System.Text;

namespace SaldoBancario.Entities.Exception
{
    internal class AccountException : ApplicationException
    {
        public AccountException(string message) : base(message)
        {
        }
    }
}
