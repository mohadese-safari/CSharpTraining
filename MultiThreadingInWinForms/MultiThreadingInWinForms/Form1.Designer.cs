
namespace MultiThreadingInWinForms
{
    partial class Form1
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
            this.btnClickMe = new System.Windows.Forms.Button();
            this.lblTestReadAccess = new System.Windows.Forms.Label();
            this.lblAccessGranted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickMe
            // 
            this.btnClickMe.Location = new System.Drawing.Point(38, 32);
            this.btnClickMe.Name = "btnClickMe";
            this.btnClickMe.Size = new System.Drawing.Size(142, 41);
            this.btnClickMe.TabIndex = 0;
            this.btnClickMe.Text = "Click me";
            this.btnClickMe.UseVisualStyleBackColor = true;
            this.btnClickMe.Click += new System.EventHandler(this.btnClickMe_Click);
            // 
            // lblTestReadAccess
            // 
            this.lblTestReadAccess.AutoSize = true;
            this.lblTestReadAccess.Location = new System.Drawing.Point(35, 110);
            this.lblTestReadAccess.Name = "lblTestReadAccess";
            this.lblTestReadAccess.Size = new System.Drawing.Size(218, 17);
            this.lblTestReadAccess.TabIndex = 1;
            this.lblTestReadAccess.Text = "Read access via another thread :";
            // 
            // lblAccessGranted
            // 
            this.lblAccessGranted.AutoSize = true;
            this.lblAccessGranted.Location = new System.Drawing.Point(311, 110);
            this.lblAccessGranted.Name = "lblAccessGranted";
            this.lblAccessGranted.Size = new System.Drawing.Size(0, 17);
            this.lblAccessGranted.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 428);
            this.Controls.Add(this.lblAccessGranted);
            this.Controls.Add(this.lblTestReadAccess);
            this.Controls.Add(this.btnClickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickMe;
        private System.Windows.Forms.Label lblTestReadAccess;
        private System.Windows.Forms.Label lblAccessGranted;
    }
}

