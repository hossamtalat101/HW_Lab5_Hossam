using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Najm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button5_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
                groupBox1.Visible = false;
            else
                groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label1.BackColor = Color.Red;
            else if (radioButton2.Checked)
                label1.BackColor = Color.White;
            else if (radioButton3.Checked)
                label1.BackColor = Color.Green;
            else if (radioButton4.Checked)
                label1.BackColor = Color.Blue;

            if (radioButton5.Checked)
                label1.ForeColor = Color.Red;
            else if (radioButton6.Checked)
                label1.ForeColor = Color.White;
            else if (radioButton7.Checked)
                label1.ForeColor = Color.Green;
            else if (radioButton8.Checked)
                label1.ForeColor = Color.Blue;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            if (checkBox1.Checked)
            { Sum += Convert.ToInt32(checkBox1.Text); }
            if (checkBox2.Checked)
            { Sum += Convert.ToInt32(checkBox2.Text); }
            if (checkBox3.Checked)
            { Sum += Convert.ToInt32(checkBox3.Text); }
            if (checkBox4.Checked)
            { Sum += Convert.ToInt32(checkBox4.Text); }
            if (checkBox5.Checked)
            { Sum += Convert.ToInt32(checkBox5.Text); }
            if (checkBox6.Checked)
            {
                Sum += Convert.ToInt32(checkBox6.Text);
            }
            textBox1.Text = Sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled==true)
                groupBox1.Enabled = false;
            else
                groupBox1.Enabled = true;
        }
    }
}
