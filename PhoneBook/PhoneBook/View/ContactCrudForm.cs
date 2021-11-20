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
        private List<PhoneNumber> PhoneNumbers { get; set; }
        private List<ComboBox> cmbBoxPhoneLabels { get; set; } = new List<ComboBox>();
        private List<MaskedTextBox> txtPhoneNumbers { get; set; } = new List<MaskedTextBox>();
        private string[] ComboBoxSuggestions { get; }
        public ContactCrudForm(Contact contact, List<PhoneNumber> phoneNumbers)
        {
            ComboBoxSuggestions = GetComboBoxSuggestions();
            InitializeComponent();
            CurrentContact = contact;
            PhoneNumbers = phoneNumbers;
            LoadSavedContact();
            picBoxDeleteContact.Visible = true;
           
        }
        public ContactCrudForm()
        {
            ComboBoxSuggestions = GetComboBoxSuggestions();
            InitializeComponent();
            picBoxDeleteContact.Visible = false;
            PhoneNumbers = new List<PhoneNumber>();
            AddPhoneRow();
        }

        public string[] GetComboBoxSuggestions()
        {
            return Enum.GetNames(typeof(SuggestingLabel));
        }

        public ComboBox InitComboBox(string text)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(10, 108);
            comboBox.Margin = new Padding(10, 0, 10, 3);
            comboBox.Name = "comboBox1";
            comboBox.Size = new Size(129, 24);
            comboBox.TabIndex = 13;
            comboBox.Text = text;
            comboBox.Items.AddRange(ComboBoxSuggestions);
            return comboBox;
        }

        public MaskedTextBox InitMaskedTextBox(string text)
        {
            var textBox = new MaskedTextBox();
            textBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            textBox.Location = new Point(152, 53);
            textBox.Mask = "###########";
            textBox.Name = "maskedTextBox1";
            textBox.Size = new Size(160, 30);
            textBox.MaximumSize = new Size(160, 30);
            textBox.TabIndex = 10;
            textBox.Text = text;
            return textBox;
        }

        public PictureBox InitRemovePhonePictureBox()
        {
            var pictureBox = new PictureBox();
            pictureBox.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right;
            pictureBox.Image = new Bitmap(@"F:\SG C# course\training\PhoneBook\PhoneBook\images\close.png");
            pictureBox.Size = new Size(66, 35);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
           
            return pictureBox;
        }

        private void LoadSavedContact()
        {
            txtFirstName.Text = CurrentContact.FirstName;
            txtLastName.Text = CurrentContact.LastName;
            txtEmail.Text = CurrentContact.Email;
            if (PhoneNumbers.Count > 0)
            {
                for (int i = 0; i < PhoneNumbers.Count; i++)
                {
                    AddPhoneRow(PhoneNumbers[i]);
                }
            }
            else
            {
                AddPhoneRow();
            }
            picBoxAvatar.Image = CurrentContact.ImageUrl == null ? defaultAvatar : new Bitmap(CurrentContact.ImageUrl);
            picBoxAvatar.ImageLocation = CurrentContact.ImageUrl;
        }

        //Adding empty phone row
        private void AddPhoneRow()
        {
            PhoneNumber newPhone = new PhoneNumber() { Number = null, Label = SuggestingLabel.Mobile.ToString() };
            PhoneNumbers.Add(newPhone);
            AddPhoneRow(newPhone);
        }

        private void AddPhoneRow(PhoneNumber phoneNumber)
        {
            var cmbBox = InitComboBox(phoneNumber.Label);
            var maskedTxtBox = InitMaskedTextBox(phoneNumber.Number);
            var removePhoneIcon = InitRemovePhonePictureBox();
            cmbBoxPhoneLabels.Add(cmbBox);
            txtPhoneNumbers.Add(maskedTxtBox);
            phonesTableLayoutPanel.Controls.Add(cmbBox);
            phonesTableLayoutPanel.Controls.Add(maskedTxtBox);
            phonesTableLayoutPanel.Controls.Add(removePhoneIcon);
            removePhoneIcon.Click += (object sender,EventArgs args) =>
            {
                maskedTxtBox.Text = null;
                phonesTableLayoutPanel.Controls.Remove(cmbBox);
                phonesTableLayoutPanel.Controls.Remove(maskedTxtBox);
                phonesTableLayoutPanel.Controls.Remove(removePhoneIcon);                
            };

        }

        private Contact SaveContactInfo(Contact contact, string firstName, string lastName, string email, string imageUrl)
        {
            contact.FirstName = firstName;
            contact.LastName = lastName;
            contact.Email = email;
            contact.ImageUrl = imageUrl;
            return contact;
        }
        private Contact SaveContactInfo(string firstName, string lastName, string email, string imageUrl)
        {
            Contact newContact = new Contact(firstName, lastName, email, imageUrl);
            PhoneBookForm.OnAddContact(newContact);
            return newContact;
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
            string imageUrl = picBoxAvatar.ImageLocation;

            if (CurrentContact == null)
                CurrentContact = SaveContactInfo(firstName, lastName, email, imageUrl);
            else
                CurrentContact = SaveContactInfo(CurrentContact, firstName, lastName, email, imageUrl);

            PhoneBookForm.OnEditContact(CurrentContact);


            for(int i = 0; i < txtPhoneNumbers.Count; i++)
            {
                PhoneNumbers[i].Number = txtPhoneNumbers[i].Text;
                PhoneNumbers[i].Label = cmbBoxPhoneLabels[i].Text;
            }
            PhoneBookForm.OnUpdatePhone(CurrentContact, PhoneNumbers);

            Dispose();
            PhoneBookForm.OnSaveContact();
        }

        private void picBoxDeleteContact_Click(object sender, EventArgs e)
        {
            PhoneBookForm.OnDeleteContact(CurrentContact);
            Dispose();
        }
        private void ClearInputs()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            //txtMskPhone1.Clear();
        }
    }
}
