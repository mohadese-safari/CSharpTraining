using PhoneBookApp.Model;
namespace PhoneBookApp.View
{
    partial class ContactDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactDetail));
            this.lblLineBreak = new System.Windows.Forms.Label();
            this.lblContactFullName = new System.Windows.Forms.Label();
            this.picBoxPhoneIcon = new System.Windows.Forms.PictureBox();
            this.picBoxEmailIcon = new System.Windows.Forms.PictureBox();
            this.picBoxEditContact = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.picBoxContactAvatar = new PhoneBookApp.Model.OvalPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhoneIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmailIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEditContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxContactAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLineBreak
            // 
            this.lblLineBreak.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblLineBreak.Location = new System.Drawing.Point(14, 199);
            this.lblLineBreak.Name = "lblLineBreak";
            this.lblLineBreak.Size = new System.Drawing.Size(378, 1);
            this.lblLineBreak.TabIndex = 1;
            // 
            // lblContactFullName
            // 
            this.lblContactFullName.AutoSize = true;
            this.lblContactFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactFullName.Location = new System.Drawing.Point(20, 159);
            this.lblContactFullName.Name = "lblContactFullName";
            this.lblContactFullName.Size = new System.Drawing.Size(0, 36);
            this.lblContactFullName.TabIndex = 2;
            // 
            // picBoxPhoneIcon
            // 
            this.picBoxPhoneIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPhoneIcon.Image")));
            this.picBoxPhoneIcon.Location = new System.Drawing.Point(23, 289);
            this.picBoxPhoneIcon.Name = "picBoxPhoneIcon";
            this.picBoxPhoneIcon.Size = new System.Drawing.Size(29, 34);
            this.picBoxPhoneIcon.TabIndex = 3;
            this.picBoxPhoneIcon.TabStop = false;
            // 
            // picBoxEmailIcon
            // 
            this.picBoxEmailIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxEmailIcon.Image")));
            this.picBoxEmailIcon.Location = new System.Drawing.Point(23, 228);
            this.picBoxEmailIcon.Name = "picBoxEmailIcon";
            this.picBoxEmailIcon.Size = new System.Drawing.Size(29, 38);
            this.picBoxEmailIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxEmailIcon.TabIndex = 4;
            this.picBoxEmailIcon.TabStop = false;
            // 
            // picBoxEditContact
            // 
            this.picBoxEditContact.Image = ((System.Drawing.Image)(resources.GetObject("picBoxEditContact.Image")));
            this.picBoxEditContact.Location = new System.Drawing.Point(224, 438);
            this.picBoxEditContact.Name = "picBoxEditContact";
            this.picBoxEditContact.Size = new System.Drawing.Size(168, 66);
            this.picBoxEditContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEditContact.TabIndex = 5;
            this.picBoxEditContact.TabStop = false;
            this.picBoxEditContact.Click += new System.EventHandler(this.picBoxEditContact_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(79, 234);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 29);
            this.lblEmail.TabIndex = 6;
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone1.Location = new System.Drawing.Point(79, 288);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(0, 29);
            this.lblPhone1.TabIndex = 7;
            // 
            // picBoxContactAvatar
            // 
            this.picBoxContactAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxContactAvatar.Location = new System.Drawing.Point(142, 31);
            this.picBoxContactAvatar.Name = "picBoxContactAvatar";
            this.picBoxContactAvatar.Size = new System.Drawing.Size(130, 130);
            this.picBoxContactAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxContactAvatar.TabIndex = 8;
            this.picBoxContactAvatar.TabStop = false;
            // 
            // ContactDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(404, 516);
            this.Controls.Add(this.picBoxContactAvatar);
            this.Controls.Add(this.lblPhone1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.picBoxEditContact);
            this.Controls.Add(this.picBoxEmailIcon);
            this.Controls.Add(this.picBoxPhoneIcon);
            this.Controls.Add(this.lblContactFullName);
            this.Controls.Add(this.lblLineBreak);
            this.MaximizeBox = false;
            this.Name = "ContactDetail";
            this.Text = "ContactDetail";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPhoneIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEmailIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEditContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxContactAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLineBreak;
        private System.Windows.Forms.Label lblContactFullName;
        private System.Windows.Forms.PictureBox picBoxPhoneIcon;
        private System.Windows.Forms.PictureBox picBoxEmailIcon;
        private System.Windows.Forms.PictureBox picBoxEditContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone1;
        private OvalPictureBox picBoxContactAvatar;
    }
}