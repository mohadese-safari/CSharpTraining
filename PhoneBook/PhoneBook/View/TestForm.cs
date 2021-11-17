using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookApp.View
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label l;
            l = new Label();
            l.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            l.Size = new Size(100,50);
            l.TabIndex = 7;
            l.TextAlign = ContentAlignment.MiddleLeft;
            l.Text = $"{tableLayoutPanel1.Controls.Count+1}";
            tableLayoutPanel1.Controls.Add(l);
        }
    }
}
