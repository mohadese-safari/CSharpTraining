using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.PhoneBookExceptions
{
    class PhoneBookException : Exception
    {
        public string Title { get; set; }
        public PhoneBookException(string title, string message) : base(message)
        {
            Title = title;
        }
    }
    class DuplicateContactFullNameException : PhoneBookException
    {
        public DuplicateContactFullNameException() : base("Duplicate contact full name",
            "Can not add a contact with duplicate full name") { }
    }

    class InvalidContactException : PhoneBookException
    {
        public InvalidContactException() : base("Invalid contact", "Invalid contact Id") { }
    }

    class EmptyContactCredientalsException : PhoneBookException
    {
        public EmptyContactCredientalsException() : base("Empty contact credientals", 
            "Contact should have at least one of the first name or last name.") { }
    }
}
