using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBookApp.Model;

namespace PhoneBookApp.View
{
    public partial class ContactCrudForm : Form
    {
        readonly Bitmap defaultAvatar = global::PhoneBookApp.Properties.Resources.avatar_default_icon;

        private Contact CurrentContact { get; set; }
        public ContactCrudForm(Contact contact) : this()
        {
            CurrentContact = contact;
            LoadSavedContact();
            picBoxDeleteContact.Visible = true;
        }
        public ContactCrudForm()
        {
            InitializeComponent();
            string[] comboBoxSuggestions = Enum.GetNames(typeof(SuggestingLabel));
            cmbBoxPhoneLabel.Items.AddRange(comboBoxSuggestions);
            picBoxDeleteContact.Visible = false;
        }

        private void LoadSavedContact()
        {
            txtFirstName.Text = CurrentContact.FirstName;
            txtLastName.Text = CurrentContact.LastName;
            txtEmail.Text = CurrentContact.Email;
            txtMskPhone1.Text = CurrentContact.PhoneNumbers?[0].Number;
            cmbBoxPhoneLabel.Text = CurrentContact.PhoneNumbers?[0].Label;
            picBoxAvatar.Image = CurrentContact.ImageUrl == null ? defaultAvatar : new Bitmap(CurrentContact.ImageUrl);
            picBoxAvatar.ImageLocation = CurrentContact.ImageUrl;
        }

        private void SaveContact(Contact contact, string firstName, string lastName, string email, string imageUrl, List<PhoneNumber> phoneNumbers)
        {
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Email = email;
            contact.ImageUrl = imageUrl;
            contact.PhoneNumbers = phoneNumbers;
        }
        private void SaveContact(string firstName, string lastName, string email, string imageUrl, List<PhoneNumber> phoneNumbers)
        {
            Contact newContact = new Contact(firstName, lastName, email, phoneNumbers, imageUrl);
            PhoneBookForm.OnAddContact(newContact);
        }

        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMskPhone1.Clear();
        }

        private void picBoxAvatar_Click(object sender, EventArgs e)
        {
            var imageChooserDialog = new OpenFileDialog
            {
                Filter = "Image files (*.JPG;*.PNG)|*.JPG;*.PNG"
            };
            var result = imageChooserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //using (ResXResourceReader resxReader = new ResXResourceReader(@"..\..\Properties\Resources.resx"))
                //{
                //    foreach (DictionaryEntry entry in resxReader)
                //    {
                //       // if (((string)entry.Key).StartsWith("EarlyAuto"))

                //    }
                //}
                string imageUrl = imageChooserDialog.FileName;
                picBoxAvatar.Image = new Bitmap(imageUrl);
                picBoxAvatar.ImageLocation = imageUrl;
            }
        }

        private void CRUDForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PhoneBookForm.OnSaveContact();
        }

        private void lblSaveContact_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phone = txtMskPhone1.Text;
            string phoneLabel = cmbBoxPhoneLabel.Text;
            string imageUrl = picBoxAvatar.ImageLocation;
            List<PhoneNumber> phoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber(phone,phoneLabel)
            };
            if (CurrentContact == null)
                SaveContact(firstName, lastName, email, imageUrl, phoneNumbers);
            else
                SaveContact(CurrentContact, firstName, lastName, email, imageUrl, phoneNumbers);

            Dispose();
            PhoneBookForm.OnSaveContact();
        }

        private void picBoxDeleteContact_Click(object sender, EventArgs e)
        {
            PhoneBookForm.OnDeleteContact(CurrentContact);
            Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
