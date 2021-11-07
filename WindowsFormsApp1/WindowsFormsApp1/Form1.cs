using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "mouse clicked";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "mouse hovered";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            var zero = Point.Empty;
            lblMousePosition.Text = $"({e.X},{e.Y})";
            var g = CreateGraphics();
            g.Clear(BackColor);
            g.DrawLine(Pens.Blue, zero, e.Location);
        }


        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // e.Graphics.DrawLine(Pens.Khaki, 30f, 30f, 80f, 80f);
        }
    }
}
