using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Model
{
    public class Contact
    {
        public Contact()
        {
            PhoneNumbers = new List<PhoneNumber>();
        }
        public Contact(string name):this()
        {
            FirstName = name;
           
        }

        public Contact(string name, string lastName) : this(name)
        {
            LastName = lastName;
        }
        public Contact(string name, string lastName, string email) : this(name, lastName)
        {
            Email = email;
        }

        public Contact(string name, string lastName, string email, List<PhoneNumber> phoneNumbers) : this(name, lastName, email)
        {
            PhoneNumbers.AddRange(phoneNumbers);
        }
        public Contact(string name, string lastName, string email, List<PhoneNumber> phoneNumbers, string imageUrl) : this(name, lastName, email, phoneNumbers)
        {
            ImageUrl = imageUrl;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string ImageUrl { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }
    }
}
