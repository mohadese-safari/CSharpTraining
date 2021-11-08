using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Model
{
    public delegate void OnAddContact(Contact contact);
    public delegate void OnEditContact(Contact contact);
    public delegate void OnSaveContact();
    public delegate void OnDeleteContact(Contact contact);
}
