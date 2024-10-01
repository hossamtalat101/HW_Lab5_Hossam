using System;
using System.Windows.Forms;

namespace Lab5_Najm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

       

        private void Form4_Load(object sender, EventArgs e)
        {
            pnlSum.Visible = pnlSub.Visible = pnlMult.Visible = pnlDiv.Visible = false;
            pnlSub.Location = pnlMult.Location = pnlDiv.Location = pnlSum.Location;
            this.Width = 410;
            this.Height = 80;

            // Set up KeyPress event
            textBox2.KeyPress += textBox1_KeyPress;
            txtResultOfSum.KeyPress += textBox1_KeyPress;
            textBox3.KeyPress += textBox1_KeyPress;
            txtResultOfSub.KeyPress += textBox1_KeyPress;
            textBox4.KeyPress += textBox1_KeyPress;
            textBox4.KeyPress += textBox1_KeyPress;
            textBox5.KeyPress += textBox1_KeyPress;
            txtResultOfMult.KeyPress += textBox1_KeyPress;
            textBox6.KeyPress += textBox1_KeyPress;
            textBox7.KeyPress += textBox1_KeyPress;
            txtResultOfDiv.KeyPress += textBox1_KeyPress;
            textBox8.KeyPress += textBox1_KeyPress;

            // Attach close button click events
            btnClose2.Click += btnClose1_Click;
            btnClose3.Click += btnClose1_Click;
            btnClose4.Click += btnClose1_Click;

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlSum);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlSub);
        }

        private void btnMult_Click_1(object sender, EventArgs e)
        {
            ShowPanel(pnlMult);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlDiv);
        }


        private void ShowPanel(Panel panel)
        {
            this.Width = panel.Width + 50;
            this.Height = panel.Height + 100;
            panel.Visible = true;

            // Hide other panels
            foreach (var pnl in new[] { pnlSum, pnlSub, pnlMult, pnlDiv })
            {
                if (pnl != panel)
                {
                    pnl.Visible = false;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCalcSum_Click(object sender, EventArgs e)
        {
            txtResultOfSum.Text= GiveTheResult(btnCalcSum.ToString()).ToString();
        }

        private void btnCalcSub_Click(object sender, EventArgs e)
        {
            txtResultOfSub.Text = GiveTheResult(btnCalcSub.ToString()).ToString();
        }

        private void btnCalcMult_Click(object sender, EventArgs e)
        {
            txtResultOfMult.Text = GiveTheResult(btnCalcMult.ToString()).ToString();

        }

        private void btnCalcDiv_Click(object sender, EventArgs e)
        {
            txtResultOfDiv.Text = GiveTheResult(btnCalcDiv.ToString()).ToString();

        }
        private double GiveTheResult(string btnName)
        {
            double num1, num2;
            double result = 0;

            // Determine which panel is visible to get the appropriate textboxes
            if (pnlSum.Visible)
            {
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                result = num1 + num2;
            }
            else if (pnlSub.Visible)
            {
                num1 = Convert.ToDouble(textBox3.Text);
                num2 = Convert.ToDouble(textBox4.Text);
                result = num1 - num2;
            }
            else if (pnlMult.Visible)
            {
                num1 = Convert.ToDouble(textBox5.Text);
                num2 = Convert.ToDouble(textBox6.Text);
                result = num1 * num2;
            }
            else if (pnlDiv.Visible)
            {
                num1 = Convert.ToDouble(textBox7.Text);
                num2 = Convert.ToDouble(textBox8.Text);
                if (num2 == 0)
                {
                    MessageBox.Show("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = num1 / num2;
                }
            }
            return result;
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            // Hide the current panel and reset the form
            Panel currentPanel = (sender as Button)?.Parent as Panel;
            if (currentPanel != null)
            {
                currentPanel.Visible = false;
                this.Width = 410;
                this.Height = 80;
            }
        }
    }
}


