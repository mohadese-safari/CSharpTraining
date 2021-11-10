
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
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.txtMskPhone1 = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneLabel1 = new System.Windows.Forms.Label();
            this.cmbBoxPhoneLabel = new System.Windows.Forms.ComboBox();
            this.picBoxDeleteContact = new System.Windows.Forms.PictureBox();
            this.picBoxSaveContact = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxAvatar = new PhoneBookApp.Model.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDeleteContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSaveContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(153, 176);
            this.txtFirstName.MaxLength = 15;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(185, 30);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(153, 238);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 30);
            this.txtLastName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(33, 178);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "First name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(35, 238);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 25);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last name";
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone1.Location = new System.Drawing.Point(37, 354);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(69, 25);
            this.lblPhone1.TabIndex = 7;
            this.lblPhone1.Text = "Phone";
            // 
            // txtMskPhone1
            // 
            this.txtMskPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMskPhone1.Location = new System.Drawing.Point(153, 352);
            this.txtMskPhone1.Mask = "#######";
            this.txtMskPhone1.Name = "txtMskPhone1";
            this.txtMskPhone1.Size = new System.Drawing.Size(185, 30);
            this.txtMskPhone1.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(37, 299);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(153, 297);
            this.txtEmail.MaxLength = 15;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 30);
            this.txtEmail.TabIndex = 9;
            // 
            // lblPhoneLabel1
            // 
            this.lblPhoneLabel1.AutoSize = true;
            this.lblPhoneLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneLabel1.Location = new System.Drawing.Point(39, 403);
            this.lblPhoneLabel1.Name = "lblPhoneLabel1";
            this.lblPhoneLabel1.Size = new System.Drawing.Size(60, 25);
            this.lblPhoneLabel1.TabIndex = 11;
            this.lblPhoneLabel1.Text = "Label";
            // 
            // cmbBoxPhoneLabel
            // 
            this.cmbBoxPhoneLabel.FormattingEnabled = true;
            this.cmbBoxPhoneLabel.Location = new System.Drawing.Point(153, 405);
            this.cmbBoxPhoneLabel.Name = "cmbBoxPhoneLabel";
            this.cmbBoxPhoneLabel.Size = new System.Drawing.Size(133, 24);
            this.cmbBoxPhoneLabel.TabIndex = 12;
            // 
            // picBoxDeleteContact
            // 
            this.picBoxDeleteContact.Image = ((System.Drawing.Image)(resources.GetObject("picBoxDeleteContact.Image")));
            this.picBoxDeleteContact.Location = new System.Drawing.Point(38, 15);
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
            this.picBoxSaveContact.Location = new System.Drawing.Point(301, 12);
            this.picBoxSaveContact.Name = "picBoxSaveContact";
            this.picBoxSaveContact.Size = new System.Drawing.Size(91, 38);
            this.picBoxSaveContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSaveContact.TabIndex = 14;
            this.picBoxSaveContact.TabStop = false;
            this.picBoxSaveContact.Click += new System.EventHandler(this.lblSaveContact_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxAvatar
            // 
            this.picBoxAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAvatar.Image")));
            this.picBoxAvatar.Location = new System.Drawing.Point(144, 47);
            this.picBoxAvatar.Name = "picBoxAvatar";
            this.picBoxAvatar.Padding = new System.Windows.Forms.Padding(10);
            this.picBoxAvatar.Size = new System.Drawing.Size(121, 108);
            this.picBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAvatar.TabIndex = 16;
            this.picBoxAvatar.TabStop = false;
            this.picBoxAvatar.Click += new System.EventHandler(this.picBoxAvatar_Click);
            // 
            // ContactCrudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 516);
            this.Controls.Add(this.picBoxAvatar);
            this.Controls.Add(this.picBoxDeleteContact);
            this.Controls.Add(this.picBoxSaveContact);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbBoxPhoneLabel);
            this.Controls.Add(this.lblPhoneLabel1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMskPhone1);
            this.Controls.Add(this.lblPhone1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.MaximizeBox = false;
            this.Name = "ContactCrudForm";
            this.Text = "Add/Modify contact";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CRUDForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDeleteContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSaveContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.MaskedTextBox txtMskPhone1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhoneLabel1;
        private System.Windows.Forms.ComboBox cmbBoxPhoneLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxSaveContact;
        private System.Windows.Forms.PictureBox picBoxDeleteContact;
        private OvalPictureBox picBoxAvatar;
    }
}