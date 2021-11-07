using PhoneBookApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookApp.View
{
    public partial class ContactDetail : Form
    {     
        readonly Bitmap defaultAvatar = global::PhoneBook.Properties.Resources.avatar_default_icon;
        private Contact Contact { get; set; }
        public ContactDetail(Contact contact)
        {
            Contact = contact;
            InitializeComponent();
            ShowDetails();
        }

        private void ShowDetails()
        {
            picBoxContactAvatar.Image = Contact.ImageUrl != null ? new Bitmap(Contact.ImageUrl) : defaultAvatar;
            lblContactFullName.Text = $"{Contact.FirstName} {Contact.LastName}";
            lblEmail.Text = Contact.Email;
            lblPhone1.Text = Contact.PhoneNumbers.Count > 0 ? $"{Contact.PhoneNumbers[0].Number}" : "";
        }

        private void picBoxEditContact_Click(object sender, EventArgs e)
        {
            PhoneBookForm.OnEditContact(Contact);
            Dispose();
        }
    }
}
