using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookApp.Model;
using PhoneBookApp.PhoneBookExceptions;
namespace PhoneBookApp.Model
{
    public class PhoneBookManager
    {
        public PhoneBook PhoneBook { get; set; }
        public List<Contact> Contacts
        {
            get { return PhoneBook.Contacts; }
        }
        public PhoneBookManager(PhoneBook phoneBook)
        {
            PhoneBook = phoneBook;
        }


        public PhoneBookManager() : this(new PhoneBook()) { }

        public void AddNewContact(Contact newContact)
        {
            if (string.IsNullOrWhiteSpace(newContact.FullName))
            {
                throw new EmptyContactCredientalsException();
            }
            if (ContactExists(newContact))
            {
                throw new DuplicateContactFullNameException();
            }
            PhoneBook.Contacts.Add(newContact);
        }

        public void RemoveContact(Contact toBeRemovedContact)
        {
            bool successfullyRemoved = PhoneBook.Contacts.Remove(toBeRemovedContact);
            if (!successfullyRemoved)
            {
                throw new InvalidContactException();
            }
        }

        public bool ContactExists(Contact newContact)
        {
            return PhoneBook.Contacts.Where(f => f.Equals(newContact)).Count() > 0;
        }
    }
}
