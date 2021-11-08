using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.PhoneBookExceptions
{
    class PhoneBookException : Exception
    {
        public PhoneBookException(string message) : base(message) { }      
    }
    class DuplicateContactFullNameException : PhoneBookException
    {
        public DuplicateContactFullNameException() : base("Duplicate contact full name") { }
    }

    class InvalidContactException : PhoneBookException
    {
        public InvalidContactException() : base("Invalid contact") { }
    }
}
