using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBookApp.Model;
using PhoneBookApp.Controller;
using PhoneBookApp.PhoneBookExceptions;

namespace PhoneBookApp.View
{
    public partial class PhoneBookForm : Form
    {
        public static OnAddContact OnAddContact { get; set; }
        public static OnEditContact OnEditContact { get; set; }
        public static OnSaveContact OnSaveContact { get; set; }
        public static OnDeleteContact OnDeleteContact { get; set; }
        public static OnUpdatePhone OnUpdatePhone { get; set; }

        readonly Bitmap defaultAvatar = global::PhoneBookApp.Properties.Resources.avatar_default_icon;
        readonly int LBL_CONTACT_NAME_WIDTH;
        const int LBL_CONTACT_NAME_HEIGHT = 70;
        private PhoneBookManager PhoneBookManager { get; }
        public PhoneBookForm(PhoneBookManager phoneBookmanager)
        {
            PhoneBookManager = phoneBookmanager;
            InitializeComponent();
            LBL_CONTACT_NAME_WIDTH = ClientSize.Width - 10;
            HorizontalScroll.Enabled = false;
            HorizontalScroll.Visible = false;
            HorizontalScroll.Enabled = false;
            HorizontalScroll.Visible = false;
            middlePanel.HorizontalScroll.Enabled = false;
            middlePanel.HorizontalScroll.Visible = false;
            SetUpSubscribers();
            RefreshForm();
        }

        private void SetUpSubscribers()
        {
            OnAddContact += OnAddContactAction;
            OnSaveContact += OnSaveContactButtonPressed;
            OnEditContact += OnEditContactAction;
            OnDeleteContact += OnDeleteContactButtonPressed;
            OnUpdatePhone += OnUpdatePhoneAction;
        }

        private void OnEditContactAction(Contact contact)
        {
            PhoneBookManager.UpdateContactInfo(contact);
        }

        public void OnUpdatePhoneAction(Contact contact, List<PhoneNumber> phoneNumbers)
        {
            PhoneBookManager.UpdatePhoneNumbers(contact, phoneNumbers);
        }

        private void OnAddContactAction(Contact contact)
        {
            try
            {
                PhoneBookManager.AddNewContact(contact);
            }
            catch (DuplicateContactFullNameException ex)
            {
                MessageBox.Show(ex.Message, ex.Title);
            }
            catch (EmptyContactCredientalsException ex)
            {
                MessageBox.Show(ex.Message, ex.Title);
            }

        }

        //private void OnEditContactButtonPressed(Contact contact)
        //{
        //    new ContactCrudForm(contact).Show();
        //    Enabled = false;
        //    Visible = false;
        //}

        private void OnSaveContactButtonPressed()
        {
            Enabled = true;
            Visible = true;
            BringToFront();
            LoadContacts();
        }


        private void OnDeleteContactButtonPressed(Contact contact)
        {
            try
            {
                PhoneBookManager.RemoveContact(contact);
                Enabled = true;
                Visible = true;
                BringToFront();
            }
            catch (InvalidContactException ex)
            {
                MessageBox.Show("Contact does not exist", ex.Message);
            }
            finally
            {
                LoadContacts();
            }

        }

        private void AddContactBtn_Clicked(object sender, EventArgs e)
        {
            new ContactCrudForm().Show();
            Enabled = false;
            Visible = false;
        }
        private void LoadContacts()
        {
            LoadContacts(PhoneBookManager.GetAllContacts());
        }

        private void LoadContacts(List<Contact> contacts)
        {
            ClearLayout(contacts.Count);

            foreach (Contact contact in contacts)
            {
                LoadContactAvatar(contact);
                LoadContactInfo(contact);
            }
        }


        private void LoadContactAvatar(Contact contact)
        {
            var pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = contact.ImageUrl != null ? new Bitmap(contact.ImageUrl) : defaultAvatar;
            pictureBox.Size = new Size(64, 64);
            pictureBox.TabIndex = 7;
            tableLayoutPanel1.Controls.Add(pictureBox);
        }

        private void LoadContactInfo(Contact contact)
        {
            Label l;
            l = new Label();
            l.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            l.Size = new Size(LBL_CONTACT_NAME_WIDTH, LBL_CONTACT_NAME_HEIGHT);
            l.TabIndex = 7;
            l.TextAlign = ContentAlignment.MiddleLeft;
            l.Text = $"{contact.FirstName} {contact.LastName}";
            tableLayoutPanel1.Controls.Add(l);
            l.Tag = contact;
            l.MouseClick += ContactLabelClicked;
        }

        private void ContactLabelClicked(object sender, EventArgs e)
        {
            var label = sender as Label;
            Contact contatct = label.Tag as Contact;
            var phoneNumbers = PhoneBookManager.GetContactPhoneNumbers(contatct);
            new ContactCrudForm(contatct, phoneNumbers).Show();
        }

        private void ClearLayout(int newRowCount)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Size = new Size(LBL_CONTACT_NAME_WIDTH, (newRowCount * LBL_CONTACT_NAME_HEIGHT));
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtSearchBox.Text;
            var result = SearchContacts(keyword);
            LoadContacts(result);
        }

        private List<Contact> SearchContacts(string keyword)
        {
            return PhoneBookManager.SearchAllContacts(keyword);
        }

        private void ShowEmptyContactListMessage()
        {
            txtNoContactsMsg.Visible = true;
            picBoxTelephoneIcon.Visible = true;
        }

        private void HideEmptyContactListMessage()
        {
            txtNoContactsMsg.Visible = false;
            picBoxTelephoneIcon.Visible = false;
        }


        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            if (PhoneBookManager.Contacts.Count == 0)
                HideEmptyContactListMessage();
            //ShowEmptyContactListMessage();
            else
                HideEmptyContactListMessage();

            LoadContacts();
        }

        private void PhoneBookForm_Load(object sender, EventArgs e)
        {
            PhoneBookManager.TestAttach();
        }
    }
}
