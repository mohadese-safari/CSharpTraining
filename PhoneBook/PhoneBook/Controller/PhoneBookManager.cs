using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookApp.Model.Domain;
using PhoneBookApp.PhoneBookExceptions;

namespace PhoneBookApp.Model
{
    public class PhoneBookManager
    {
        private PhoneBookDBContext PhoneBookDBContext { get; set; }
        public PhoneBook PhoneBook { get; set; }
        public List<Contact> Contacts
        {
            get { return PhoneBook.Contacts; }
        }
        public PhoneBookManager(PhoneBook phoneBook)
        {
            PhoneBook = phoneBook;
        }


        public PhoneBookManager() : this(new PhoneBook())
        {
            // CreatePhoneBook();
        }

        //private void CreatePhoneBook()
        //{
        //    using (PhoneBookDBContext)
        //    {
        //        PhoneBookDBContext.PhoneBooks.Add(PhoneBook);
        //    }
        //}

        public Contact AddNewContact(Contact newContact)
        {

            if (string.IsNullOrWhiteSpace(newContact.FullName))
            {
                throw new EmptyContactCredientalsException();
            }
            if (ContactExists(newContact))
            {
                throw new DuplicateContactFullNameException();
            }

            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                PhoneBookDBContext.Contacts.Add(newContact);
                PhoneBookDBContext.SaveChanges();
                return newContact;
            }
            return null;
            //PhoneBook.Contacts.Add(newContact);
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


        public List<PhoneNumber> GetContactPhoneNumbers(Contact contact)
        {
            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                //Fluent linq
                //var result = from c in PhoneBookDBContext.Contacts
                //             from p in PhoneBookDBContext.phoneNumbers
                //             where c.Id == contact.Id
                //             select c.PhoneNumbers;
                //return result.FirstOrDefault();

                //Linq query
                var result = PhoneBookDBContext.Contacts.Where(c => c.Id == contact.Id).SelectMany(c => c.PhoneNumbers);
                return result.ToList();
            }
            
        }
        public List<Contact> GetAllContacts()
        {         
            using (PhoneBookDBContext = new PhoneBookDBContext())            {
                List<Contact> allContacts = PhoneBookDBContext.Contacts.ToList();
                return allContacts;
            }
        }

        public void UpdatePhoneNumbers(Contact contact, List<PhoneNumber> phoneNumbers)
        {
            
            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                Contact cn = PhoneBookDBContext.Contacts.Where(c => c.Id == contact.Id).FirstOrDefault();
                cn.PhoneNumbers = phoneNumbers;
                PhoneBookDBContext.SaveChanges();
            }
        }
    }
}
