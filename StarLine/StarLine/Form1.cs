using System;
using System.Drawing;

using System.Windows.Forms;

namespace StarLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientSize = new Size(500, 500);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point zeroPoint = new Point(Zero_X, Zero_Y);
            Axis west = new Axis(new Point(0, Zero_Y), zeroPoint);
            Axis south = new Axis(new Point(Zero_X, Max_Y), zeroPoint);
            Axis east = new Axis(new Point(Max_X, Zero_Y), zeroPoint);
            Axis north = new Axis(new Point(Zero_X, 0), zeroPoint);

            Zone southWest = new Zone(west, south);
            Zone southEast = new Zone(east, south);
            Zone northWest = new Zone(west, north);
            Zone northEast = new Zone(east, north);

            CreateGraphics().Clear(BackColor);
            int length = 31 - (int)numericUpDown1.Value;
            DrawStarBlade(southWest, length);
            DrawStarBlade(southEast, length);
            DrawStarBlade(northWest, length);
            DrawStarBlade(northEast, length);
        }
    }

}
