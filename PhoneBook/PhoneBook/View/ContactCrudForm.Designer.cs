
using System;
using System.Collections.Generic;
using PhoneBookApp.Model;
namespace PhoneBookApp.View
{
    partial class ContactCrudForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactCrudForm));
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.picBoxDeleteContact = new System.Windows.Forms.PictureBox();
            this.picBoxSaveContact = new System.Windows.Forms.PictureBox();
            this.saveAndDeletePanel = new System.Windows.Forms.Panel();
            this.contactDetailsPanel = new System.Windows.Forms.Panel();
            this.picBoxEditAvatar = new PhoneBookApp.Model.OvalPictureBox();
            this.lblSepratorUp = new System.Windows.Forms.Label();
            this.lblSepratorDown = new System.Windows.Forms.Label();
            this.addRowPicBox = new System.Windows.Forms.PictureBox();
            this.picBoxAvatar = new PhoneBookApp.Model.OvalPictureBox();
            this.contactPhonePanel = new System.Windows.Forms.Panel();
            this.phonesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDeleteContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSaveContact)).BeginInit();
            this.saveAndDeletePanel.SuspendLayout();
            this.contactDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEditAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRowPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.contactPhonePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(152, 125);
            this.txtFirstName.MaxLength = 15;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(185, 30);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(152, 174);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 30);
            this.txtLastName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 125);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "First name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(35, 174);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 25);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(39, 226);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(152, 226);
            this.txtEmail.MaxLength = 15;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 30);
            this.txtEmail.TabIndex = 9;
            // 
            // picBoxDeleteContact
            // 
            this.picBoxDeleteContact.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeleteContact.Image")));
            this.picBoxDeleteContact.Location = new System.Drawing.Point(12, 5);
            this.picBoxDeleteContact.Name = "picBoxDeleteContact";
            this.picBoxDeleteContact.Size = new System.Drawing.Size(35, 35);
            this.picBoxDeleteContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDeleteContact.TabIndex = 15;
            this.picBoxDeleteContact.TabStop = false;
            this.picBoxDeleteContact.Click += new System.EventHandler(this.picBoxDeleteContact_Click);
            // 
            // picBoxSaveContact
            // 
            this.picBoxSaveContact.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSaveContact.Image")));
            this.picBoxSaveContact.Location = new System.Drawing.Point(301, 5);
            this.picBoxSaveContact.Name = "picBoxSaveContact";
            this.picBoxSaveContact.Size = new System.Drawing.Size(91, 38);
            this.picBoxSaveContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSaveContact.TabIndex = 14;
            this.picBoxSaveContact.TabStop = false;
            this.picBoxSaveContact.Click += new System.EventHandler(this.lblSaveContact_Click);
            // 
            // saveAndDeletePanel
            // 
            this.saveAndDeletePanel.BackColor = System.Drawing.Color.Transparent;
            this.saveAndDeletePanel.Controls.Add(this.picBoxDeleteContact);
            this.saveAndDeletePanel.Controls.Add(this.picBoxSaveContact);
            this.saveAndDeletePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveAndDeletePanel.Location = new System.Drawing.Point(0, 0);
            this.saveAndDeletePanel.Name = "saveAndDeletePanel";
            this.saveAndDeletePanel.Size = new System.Drawing.Size(404, 46);
            this.saveAndDeletePanel.TabIndex = 17;
            // 
            // contactDetailsPanel
            // 
            this.contactDetailsPanel.Controls.Add(this.picBoxEditAvatar);
            this.contactDetailsPanel.Controls.Add(this.lblSepratorUp);
            this.contactDetailsPanel.Controls.Add(this.lblSepratorDown);
            this.contactDetailsPanel.Controls.Add(this.addRowPicBox);
            this.contactDetailsPanel.Controls.Add(this.picBoxAvatar);
            this.contactDetailsPanel.Controls.Add(this.txtFirstName);
            this.contactDetailsPanel.Controls.Add(this.lblName);
            this.contactDetailsPanel.Controls.Add(this.txtLastName);
            this.contactDetailsPanel.Controls.Add(this.lblLastName);
            this.contactDetailsPanel.Controls.Add(this.lblEmail);
            this.contactDetailsPanel.Controls.Add(this.txtEmail);
            this.contactDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactDetailsPanel.Location = new System.Drawing.Point(0, 46);
            this.contactDetailsPanel.Name = "contactDetailsPanel";
            this.contactDetailsPanel.Size = new System.Drawing.Size(404, 470);
            this.contactDetailsPanel.TabIndex = 18;
            // 
            // picBoxEditAvatar
            // 
            this.picBoxEditAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxEditAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxEditAvatar.Image")));
            this.picBoxEditAvatar.Location = new System.Drawing.Point(153, 3);
            this.picBoxEditAvatar.Name = "picBoxEditAvatar";
            this.picBoxEditAvatar.Padding = new System.Windows.Forms.Padding(10);
            this.picBoxEditAvatar.Size = new System.Drawing.Size(121, 108);
            this.picBoxEditAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxEditAvatar.TabIndex = 22;
            this.picBoxEditAvatar.TabStop = false;
            this.picBoxEditAvatar.Visible = false;
            this.picBoxEditAvatar.Click += new System.EventHandler(this.picBoxEditAvatar_Click);
            // 
            // lblSepratorUp
            // 
            this.lblSepratorUp.BackColor = System.Drawing.Color.LightGray;
            this.lblSepratorUp.Location = new System.Drawing.Point(4, 1);
            this.lblSepratorUp.Name = "lblSepratorUp";
            this.lblSepratorUp.Size = new System.Drawing.Size(396, 2);
            this.lblSepratorUp.TabIndex = 21;
            // 
            // lblSepratorDown
            // 
            this.lblSepratorDown.BackColor = System.Drawing.Color.LightGray;
            this.lblSepratorDown.Location = new System.Drawing.Point(4, 274);
            this.lblSepratorDown.Name = "lblSepratorDown";
            this.lblSepratorDown.Size = new System.Drawing.Size(396, 2);
            this.lblSepratorDown.TabIndex = 20;
            // 
            // addRowPicBox
            // 
            this.addRowPicBox.Image = ((System.Drawing.Image)(resources.GetObject("addRowPicBox.Image")));
            this.addRowPicBox.Location = new System.Drawing.Point(14, 288);
            this.addRowPicBox.Name = "addRowPicBox";
            this.addRowPicBox.Size = new System.Drawing.Size(195, 36);
            this.addRowPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addRowPicBox.TabIndex = 19;
            this.addRowPicBox.TabStop = false;
            this.addRowPicBox.Click += new System.EventHandler(this.addRowPicBox_Click);
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAvatar.Image")));
            this.picBoxAvatar.Location = new System.Drawing.Point(153, 3);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Padding = new System.Windows.Forms.Padding(10);
            this.picBoxAvatar.Size = new System.Drawing.Size(121, 108);
            this.picBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAvatar.TabIndex = 16;
            this.picBoxAvatar.TabStop = false;
            this.picBoxAvatar.Click += new System.EventHandler(this.picBoxAvatar_Click);
            this.picBoxAvatar.MouseEnter += new System.EventHandler(this.picBoxAvatar_MouseEnter);
            this.picBoxAvatar.MouseLeave += new System.EventHandler(this.picBoxAvatar_MouseLeave);
            // 
            // contactPhonePanel
            // 
            this.contactPhonePanel.AutoScroll = true;
            this.contactPhonePanel.Controls.Add(this.phonesTableLayoutPanel);
            this.contactPhonePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contactPhonePanel.Location = new System.Drawing.Point(0, 376);
            this.contactPhonePanel.Name = "contactPhonePanel";
            this.contactPhonePanel.Size = new System.Drawing.Size(404, 140);
            this.contactPhonePanel.TabIndex = 19;
            // 
            // phonesTableLayoutPanel
            // 
            this.phonesTableLayoutPanel.AutoScroll = true;
            this.phonesTableLayoutPanel.AutoSize = true;
            this.phonesTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.phonesTableLayoutPanel.ColumnCount = 3;
            this.phonesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.91018F));
            this.phonesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.08982F));
            this.phonesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.phonesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phonesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.phonesTableLayoutPanel.Name = "phonesTableLayoutPanel";
            this.phonesTableLayoutPanel.RowCount = 3;
            this.phonesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.phonesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
            this.phonesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.phonesTableLayoutPanel.Size = new System.Drawing.Size(404, 140);
            this.phonesTableLayoutPanel.TabIndex = 13;
            // 
            // ContactCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 516);
            this.Controls.Add(this.contactPhonePanel);
            this.Controls.Add(this.contactDetailsPanel);
            this.Controls.Add(this.saveAndDeletePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ContactCrudForm";
            this.Text = "Add/Modify contact";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CRUDForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDeleteContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSaveContact)).EndInit();
            this.saveAndDeletePanel.ResumeLayout(false);
            this.contactDetailsPanel.ResumeLayout(false);
            this.contactDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEditAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRowPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.contactPhonePanel.ResumeLayout(false);
            this.contactPhonePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox picBoxSaveContact;
        private System.Windows.Forms.PictureBox picBoxDeleteContact;
        private OvalPictureBox picBoxAvatar;
        private System.Windows.Forms.Panel saveAndDeletePanel;
        private System.Windows.Forms.Panel contactDetailsPanel;
        private System.Windows.Forms.Panel contactPhonePanel;
        private System.Windows.Forms.TableLayoutPanel phonesTableLayoutPanel;
        private System.Windows.Forms.PictureBox addRowPicBox;
        private System.Windows.Forms.Label lblSepratorDown;
        private System.Windows.Forms.Label lblSepratorUp;
        private OvalPictureBox picBoxEditAvatar;
    }
}