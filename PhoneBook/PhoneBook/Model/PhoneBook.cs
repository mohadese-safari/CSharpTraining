using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook;
namespace PhoneBookApp.Model
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; set; }
        public PhoneBook()
        {
            Contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }
        
    }
}
