
namespace PhoneBookApp.View
{
    partial class PhoneBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneBookForm));
            this.contactsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBoxTelephoneIcon = new System.Windows.Forms.PictureBox();
            this.txtNoContactsMsg = new System.Windows.Forms.TextBox();
            this.contactsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelephoneIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // contactsPanel
            // 
            this.contactsPanel.AutoScroll = true;
            this.contactsPanel.AutoSize = true;
            this.contactsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contactsPanel.Controls.Add(this.tableLayoutPanel1);
            this.contactsPanel.Location = new System.Drawing.Point(8, 63);
            this.contactsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contactsPanel.Name = "contactsPanel";
            this.contactsPanel.Size = new System.Drawing.Size(355, 87);
            this.contactsPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.32432F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.67567F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(349, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 70);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 452);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(52, 20);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(309, 30);
            this.txtSearchBox.TabIndex = 5;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // picBoxTelephoneIcon
            // 
            this.picBoxTelephoneIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTelephoneIcon.Image")));
            this.picBoxTelephoneIcon.Location = new System.Drawing.Point(102, 297);
            this.picBoxTelephoneIcon.Name = "picBoxTelephoneIcon";
            this.picBoxTelephoneIcon.Size = new System.Drawing.Size(182, 121);
            this.picBoxTelephoneIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTelephoneIcon.TabIndex = 7;
            this.picBoxTelephoneIcon.TabStop = false;
            // 
            // txtNoContactsMsg
            // 
            this.txtNoContactsMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoContactsMsg.Font = new System.Drawing.Font("Urdu Typesetting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoContactsMsg.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNoContactsMsg.Location = new System.Drawing.Point(38, 235);
            this.txtNoContactsMsg.Name = "txtNoContactsMsg";
            this.txtNoContactsMsg.Size = new System.Drawing.Size(308, 46);
            this.txtNoContactsMsg.TabIndex = 8;
            this.txtNoContactsMsg.Text = "No contacts in your list";
            this.txtNoContactsMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhoneBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(383, 553);
            this.Controls.Add(this.txtNoContactsMsg);
            this.Controls.Add(this.picBoxTelephoneIcon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contactsPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PhoneBookForm";
            this.Text = "Phone book";
            this.Load += new System.EventHandler(this.PhoneBookForm_Load);
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            this.contactsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelephoneIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel contactsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBoxTelephoneIcon;
        private System.Windows.Forms.TextBox txtNoContactsMsg;
    }
}

