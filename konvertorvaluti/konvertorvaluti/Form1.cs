using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace konvertorvaluti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int est = Convert.ToInt32(textBox1.Text);
            if (rub1.Checked)
            {
                if (rub2.Checked)
                {
                    textBox2.Text = Convert.ToString(est);
                }
                if (usd2.Checked)
                {
                    textBox2.Text = Convert.ToString(est / 72);
                }
                if (eur2.Checked)
                {
                    textBox2.Text = Convert.ToString(est / 82);
                }
                if (gbp2.Checked)
                {
                    textBox2.Text = Convert.ToString(est / 98);
                }
            }
            if (usd1.Checked)
            {
                if (rub2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 72);
                }
                if (usd2.Checked)
                {
                    textBox2.Text = Convert.ToString(est);
                }
                if (eur2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 0.8);
                }
                if (gbp2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 0.7);
                }
            }
            if (eur1.Checked)
            {
                if (rub2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 82);
                }
                if (usd2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 1.1);
                }
                if (eur2.Checked)
                {
                    textBox2.Text = Convert.ToString(est);
                }
                if (gbp2.Checked)
                {
                    textBox2.Text = Convert.ToString(est / 0.8);
                }
            }
            if (gbp1.Checked)
            {
                if (rub2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 98);
                }
                if (usd2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 1.3);
                }
                if (eur2.Checked)
                {
                    textBox2.Text = Convert.ToString(est * 1.2);
                }
                if (gbp2.Checked)
                {
                    textBox2.Text = Convert.ToString(est);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
