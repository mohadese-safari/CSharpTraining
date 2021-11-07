
namespace StarLine
{
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    partial class Form1
    {

        private System.Drawing.Pen pen = System.Drawing.Pens.Gold;
        int Zero_X
        {
            get
            {
                return this.ClientSize.Width / 2;
            }
        }

        int Zero_Y
        {
            get
            {
                return this.ClientSize.Height / 2;
            }
        }

        int Max_X
        {
            get
            {
                return ClientSize.Width;
            }
        }

        int Max_Y
        {
            get
            {
                return ClientSize.Height;
            }
        }

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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(30, 52);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 22);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "resolution (1 to 30):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        void DrawStarBlade(Zone blade, int length)
        {
            button1.Enabled = false;
            var graphics = CreateGraphics();
            int xEnd = blade.HoritzonalLine.EndPoint.X;
            int yEnd = blade.HoritzonalLine.EndPoint.Y;
            int xStart = blade.HoritzonalLine.ZeroPoint.X;
            int yStart = blade.HoritzonalLine.ZeroPoint.Y;

            int verticalStartX = blade.VerticalLine.ZeroPoint.X;
            int verticalEndY = blade.VerticalLine.EndPoint.Y;

            int xEndDirection = xEnd > verticalStartX ? -1 : 1;
            int yStartDirection = yEnd > verticalEndY ? -1 : 1;

            int repetition = (Max_X / length) / 2;

            for (int i = 0; i <= repetition; i++)
            {
                graphics.DrawLine(pen, xEnd, yEnd, xStart, yStart);
                xEnd += xEndDirection * length;
                yStart += yStartDirection * length;
                Thread.Sleep(50);
            }
            button1.Enabled = true;
        }
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }

    class Zone
    {
        public Zone(Axis horitzonalLine, Axis verticalLine)
        {
            HoritzonalLine = horitzonalLine;
            VerticalLine = verticalLine;
        }

        public Axis HoritzonalLine
        {
            get;
        }

        public Axis VerticalLine
        {
            get;
        }

    }

    class Axis
    {
        public Axis(Point end, Point zeroPoint)
        {
            EndPoint = end;
            ZeroPoint = zeroPoint;
        }
        public Point ZeroPoint
        {
            get;
        }

        public Point EndPoint
        {
            get;
        }
    }

}

