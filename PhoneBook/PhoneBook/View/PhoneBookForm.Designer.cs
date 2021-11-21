
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.txtNoContactsMsg = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsPanel = new System.Windows.Forms.Panel();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.picBoxTelephoneIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addContactPicBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.middlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelephoneIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContactPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.32432F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.67567F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(349, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 70);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(53, 44);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(10, 2, 3, 2);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(309, 30);
            this.txtSearchBox.TabIndex = 5;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // txtNoContactsMsg
            // 
            this.txtNoContactsMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoContactsMsg.Font = new System.Drawing.Font("Urdu Typesetting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoContactsMsg.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNoContactsMsg.Location = new System.Drawing.Point(38, 250);
            this.txtNoContactsMsg.Name = "txtNoContactsMsg";
            this.txtNoContactsMsg.Size = new System.Drawing.Size(308, 46);
            this.txtNoContactsMsg.TabIndex = 8;
            this.txtNoContactsMsg.Text = "No contacts in your list";
            this.txtNoContactsMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filwToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(383, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filwToolStripMenuItem
            // 
            this.filwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.filwToolStripMenuItem.Enabled = false;
            this.filwToolStripMenuItem.Name = "filwToolStripMenuItem";
            this.filwToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.filwToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phoneBookToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.newToolStripMenuItem.Text = "New ...";
            // 
            // phoneBookToolStripMenuItem
            // 
            this.phoneBookToolStripMenuItem.Name = "phoneBookToolStripMenuItem";
            this.phoneBookToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.phoneBookToolStripMenuItem.Text = " phone book";
            // 
            // contactsPanel
            // 
            this.contactsPanel.AutoSize = true;
            this.contactsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contactsPanel.Location = new System.Drawing.Point(3, 12);
            this.contactsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contactsPanel.Name = "contactsPanel";
            this.contactsPanel.Size = new System.Drawing.Size(0, 0);
            this.contactsPanel.TabIndex = 4;
            // 
            // middlePanel
            // 
            this.middlePanel.AutoScroll = true;
            this.middlePanel.Controls.Add(this.tableLayoutPanel1);
            this.middlePanel.Controls.Add(this.contactsPanel);
            this.middlePanel.Location = new System.Drawing.Point(0, 98);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(378, 358);
            this.middlePanel.TabIndex = 9;
            // 
            // picBoxTelephoneIcon
            // 
            this.picBoxTelephoneIcon.Image = ((System.Drawing.Image)(resources.GetObject("picBoxTelephoneIcon.Image")));
            this.picBoxTelephoneIcon.Location = new System.Drawing.Point(102, 303);
            this.picBoxTelephoneIcon.Name = "picBoxTelephoneIcon";
            this.picBoxTelephoneIcon.Size = new System.Drawing.Size(182, 121);
            this.picBoxTelephoneIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTelephoneIcon.TabIndex = 7;
            this.picBoxTelephoneIcon.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // addContactPicBox
            // 
            this.addContactPicBox.Image = ((System.Drawing.Image)(resources.GetObject("addContactPicBox.Image")));
            this.addContactPicBox.Location = new System.Drawing.Point(288, 461);
            this.addContactPicBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addContactPicBox.Name = "addContactPicBox";
            this.addContactPicBox.Size = new System.Drawing.Size(83, 89);
            this.addContactPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addContactPicBox.TabIndex = 2;
            this.addContactPicBox.TabStop = false;
            this.addContactPicBox.Click += new System.EventHandler(this.AddContactBtn_Clicked);
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
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.addContactPicBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PhoneBookForm";
            this.Text = "Phone book";
            this.EnabledChanged += new System.EventHandler(this.Form1_EnabledChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.middlePanel.ResumeLayout(false);
            this.middlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelephoneIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addContactPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox addContactPicBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBoxTelephoneIcon;
        private System.Windows.Forms.TextBox txtNoContactsMsg;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneBookToolStripMenuItem;
        private System.Windows.Forms.Panel contactsPanel;
        private System.Windows.Forms.Panel middlePanel;
    }
}

