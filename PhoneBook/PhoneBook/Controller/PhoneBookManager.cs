using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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

        }

        public void RemoveContact(Contact toBeRemovedContact)
        {
            RemoveContactPhoneNumbers(toBeRemovedContact);
            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                var removedContact = PhoneBookDBContext.Contacts.Where(c => c.Id == toBeRemovedContact.Id).FirstOrDefault();
                if (removedContact == null)
                {
                    throw new InvalidContactException();
                }
                PhoneBookDBContext.Contacts.Remove(removedContact);
                PhoneBookDBContext.SaveChanges();
            }
        }

        public void RemoveContactPhoneNumbers(Contact contact)
        {
            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                var toBeRemovedPhoneNumbers = PhoneBookDBContext.Contacts.Where(c => c.Id == contact.Id).SelectMany(c => c.PhoneNumbers);
                PhoneBookDBContext.phoneNumbers.RemoveRange(toBeRemovedPhoneNumbers);
                PhoneBookDBContext.SaveChanges();
            }
        }

        //TODO
        public bool ContactExists(Contact newContact)
        {
            return PhoneBook.Contacts.Where(f => f.Equals(newContact)).Count() > 0;
        }


        public List<PhoneNumber> GetContactPhoneNumbers(Contact contact)
        {
            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                #region Fluent linq
                //var result = from c in PhoneBookDBContext.Contacts
                //             from p in PhoneBookDBContext.phoneNumbers
                //             where c.Id == contact.Id
                //             select c.PhoneNumbers;
                //return result.FirstOrDefault();
                #endregion

                //Linq query
                var result = PhoneBookDBContext.Contacts.Where(c => c.Id == contact.Id).SelectMany(c => c.PhoneNumbers);
                return result.ToList();
            }

        }
        public List<Contact> GetAllContacts()
        {
            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                List<Contact> allContacts = PhoneBookDBContext.Contacts.ToList();
                return allContacts;
            }
        }

        public void UpdateContactInfo(Contact contact)
        {
            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                var toBeUpdatedContact = PhoneBookDBContext.Contacts.Where(c => c.Id == contact.Id).FirstOrDefault();
                if (toBeUpdatedContact == null)
                {
                    throw new InvalidContactException();
                }
                toBeUpdatedContact.FirstName = contact.FirstName;
                toBeUpdatedContact.LastName = contact.LastName;
                toBeUpdatedContact.Email = contact.Email;
                toBeUpdatedContact.ImageUrl = contact.ImageUrl;
                PhoneBookDBContext.SaveChanges();
            }
        }

        public void UpdatePhoneNumbers(Contact contact, List<PhoneNumber> phoneNumbers)
        {


            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                foreach (var phone in phoneNumbers)
                {
                    var fetchedPhoneNumber = PhoneBookDBContext.phoneNumbers.Where(p => p.Id == phone.Id).FirstOrDefault();
                    var phoneNumberIsEmpty = string.IsNullOrWhiteSpace(phone.Number);
                    if (fetchedPhoneNumber == null && !phoneNumberIsEmpty)
                    {
                        Contact cn = PhoneBookDBContext.Contacts.Where(c => c.Id == contact.Id).FirstOrDefault();
                        cn.PhoneNumbers = new List<PhoneNumber>() { phone };
                    }
                    else if (fetchedPhoneNumber != null && phoneNumberIsEmpty)
                    {
                        PhoneBookDBContext.phoneNumbers.Remove(fetchedPhoneNumber);
                    }
                    else if(!phoneNumberIsEmpty)
                    {
                        fetchedPhoneNumber.Number = phone.Number;
                    }
                }

                PhoneBookDBContext.SaveChanges();
            }
        }

        public List<Contact> SearchAllContacts(string keyword)
        {
            Expression<Func<Contact, bool>> expression = contact => contact.FirstName.ToLower().Contains(keyword) ||
                     contact.LastName.ToLower().Contains(keyword) ||
                     contact.Email.ToLower().Contains(keyword);
            keyword = keyword.ToLower();
            List<Contact> searchResult;
            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                searchResult = PhoneBookDBContext.Contacts.Where(expression).ToList();
            }
            return searchResult;
        }


        #region Test Attach
        public void TestAttach()
        {
            PhoneNumber phoneNumber = new PhoneNumber()
            {
                Id = 1,
                Number = "1111111",
                Label = "Home"
            };

            using (PhoneBookDBContext = new PhoneBookDBContext())
            {
                PhoneBookDBContext.Entry(phoneNumber).State = EntityState.Modified;
                PhoneBookDBContext.phoneNumbers.Attach(phoneNumber);

                PhoneBookDBContext.SaveChanges();
            }
        }
        #endregion
    }
}
