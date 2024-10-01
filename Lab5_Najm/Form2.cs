using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Lab5_Najm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              button1.Left += 5;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Thread.Sleep(200);
            //Point p = new Point(0, 0);
            //button1.Location = p; 
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            button1.Left -= 5;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            button1.Top -= 5;
        }

        private void btnBottom_Click(object sender, EventArgs e)
        {
            button1.Top += 5;
        }

        private void btnWidth_Click(object sender, EventArgs e)
        {
            button1.Width += 5;
        }

        private void btnWidthDec_Click(object sender, EventArgs e)
        {
            button1.Width -= 5;
        }

        private void btnHeightInc_Click(object sender, EventArgs e)
        {
            button1.Height += 5;
        }

        private void btnHeightDec_Click(object sender, EventArgs e)
        {
            button1.Height -= 5;
        }
    }
}
