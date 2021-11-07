using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaintApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Rectangle r = new Rectangle(30, 30, 100, 50);
            var g = pnlPaitingCanvas.CreateGraphics();
            g.DrawEllipse(new System.Drawing.Pen(Color.Black), r);
        }
    }
}
